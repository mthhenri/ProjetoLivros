import { Component, Injectable } from '@angular/core';
import { faUser ,faBookBookmark, faHouse } from '@fortawesome/free-solid-svg-icons';
import { Router } from '@angular/router';
import { Usuario } from './models/usuario.models';
import { MessageService } from 'primeng/api';
import { HttpClient } from '@angular/common/http';
import { LivroFavoritado } from './models/livroFavoritado.models';

@Injectable({
  providedIn: 'root',
})
@Component({
  selector: 'app-root',
  templateUrl: `./app.component.html`,
  styleUrls: ["./app.component.css"],
  providers: [MessageService]
})
export class AppComponent {
  title = 'Frontend';

  constructor(
    private router: Router,
    private client: HttpClient,
    private messageService: MessageService
  ){}

  ngOnInit(){
    
  }

  homeIcon = faHouse
  booksIcon = faBookBookmark
  userIcon = faUser
  usuario!: Usuario
  // mensagem: Message[] = []

  goToHome(){
    this.router.navigate([""])
  }

  goToUser(){
    this.router.navigate(["usuario"])
  }

  goToBooks(){
    if(this.usuario != null)
    {
      this.router.navigate(["livros"])
    } else [
      this.messageService.add({ severity: 'error', summary: 'Usuário não encontrado!', detail: 'Crie uma conta ou entre para acessar a função!' })
      // this.mensagem = 
      // [
      //   {
      //     severity: "error",
      //     summary: "Você não está logado!",
      //     detail: "Crie uma conta ou logue para acessar a função."
      //   }
      // ]
    ]
  }
}
