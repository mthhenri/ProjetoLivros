import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';
import { FormControl } from '@angular/forms';
import { Router } from '@angular/router';
import { faCheck, faPlus } from '@fortawesome/free-solid-svg-icons';
import { Message } from 'primeng/api';
import { AppComponent } from 'src/app/app.component';
import { Usuario } from 'src/app/models/usuario.models';

@Component({
  selector: 'app-user-cadastro',
  templateUrl: './user-cadastro.component.html',
  styleUrls: ['./user-cadastro.component.css']
})
export class UserCadastroComponent {
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
  senha1 = new FormControl('')
  senha2 = new FormControl('')
  mensagem: Message[] = []

  cadastrar(){
    if(this.senha1.value === this.senha2.value)
    {
      let username = this.username.value?.toString()
      let senha = this.senha1.value?.toString()

      if(username != undefined && senha != undefined && username != null && senha != null)
      {

        console.log(username, senha)
  
        let usuario : Usuario = {
          username : username,
          senha : senha
        }
  
        console.log(usuario)
  
        this.client.post<Usuario>(`https://localhost:7038/usuario/cadastrar`, usuario)
        .subscribe({
          next: (usuario) => {
            this.mensagem = [
              {
                severity: 'success',
                summary: "Cadastrado com sucesso!",
                detail: "Seja muito bem-vindo!"
              }
            ]
            this.app.usuario = usuario
            this.router.navigate(["usuario"])
          },
          error: (error) => {
            this.mensagem = [
              {
                severity: 'error',
                summary: "Informações inválidas!",
                detail: "Tente novamente."
              }
            ]
            console.log(error)
            return;      
          }
        })
      }
    } else {
      this.mensagem = [
        {
          severity: 'error',
          summary: "As senhas não são idênticas!",
          detail: "Tente novamente."
        }
      ]
    }
  }
}
