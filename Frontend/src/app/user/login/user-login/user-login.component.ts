import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { Usuario } from 'src/app/models/usuario.models';
import { faPlus, faCheck } from '@fortawesome/free-solid-svg-icons';
import { FormControl } from '@angular/forms';
import { AppComponent } from 'src/app/app.component';
import { Message } from 'primeng/api';

@Component({
  selector: 'app-user-login',
  templateUrl: './user-login.component.html',
  styleUrls: ['./user-login.component.css']
})
export class UserLoginComponent {
  constructor(
    private router: Router,
    private client: HttpClient,
    private app: AppComponent
  ){}

  ngOnInit(){
  }

  doneIcon = faCheck
  newicon = faPlus
  username = new FormControl('')
  senha = new FormControl('')
  mensagem!: Message[]

  logar(){
    let username = this.username.value?.toString()
    let senha = this.senha.value?.toString()
    if(username != undefined && senha != undefined && username != null && senha != null){

      console.log(username, senha)

      let usuario : Usuario = {
        username : username,
        senha : senha
      }

      console.log(usuario)

      this.client.put<Usuario>(`https://localhost:7038/usuario/entrar`, usuario)
      .subscribe({
        next: (usuario) => {
          this.mensagem = 
          [
            {
              severity: 'success',
              summary: "Logado com sucesso!",
              detail: "Seja muito bem-vindo!"
            }
          ]
          this.app.usuario = usuario
          console.log(usuario)
          this.router.navigate(["usuario"])
        },
        error: (error) => {
          this.mensagem = 
          [
            {
              severity: 'error',
              summary: "Usuário ou senha incorretos!",
              detail: "Tente novamente."
            }
          ]
          console.log(error)       
        }
      })
    }
  }

  cadastrar(){
    this.router.navigate(["usuario/cadastrar"])
  }
}
