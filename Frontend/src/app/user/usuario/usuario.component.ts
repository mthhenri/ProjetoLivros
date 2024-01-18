import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { Usuario } from 'src/app/models/usuario.models';
import { faPlus, faCheck, faStarHalfStroke, faHeart, faHeartCrack } from '@fortawesome/free-solid-svg-icons';
import { HttpClient } from '@angular/common/http';
import { AppComponent } from 'src/app/app.component';
import { LivroFavoritado } from 'src/app/models/livroFavoritado.models';
import { MessageService } from 'primeng/api';
import { delay } from 'rxjs';


@Component({
  selector: 'app-usuario',
  templateUrl: './usuario.component.html',
  styleUrls: ['./usuario.component.css'],
  providers: [MessageService]
})
export class UsuarioComponent {
  constructor(
    private router: Router,
    private client: HttpClient,
    private app: AppComponent,
    private messageService: MessageService
  ){}

  ngOnInit(){
    this.logado();
    if(this.app.usuario != null)
    {
      this.buscarFavs();
    }
  }
  
  usuarioLog : Usuario = this.app.usuario
  livros : LivroFavoritado[] = []
  doneIcon = faCheck
  newicon = faPlus
  unFav = faStarHalfStroke
  like = faHeart
  unlike = faHeartCrack

  logado(){
    if(this.app.usuario != null){
      return ["mostrar", "esconder"]
    }
    return ["esconder", "mostrar"]
  }

  // usernamePegar(){
  //   return this.app.usuario.username
  // }

  loginGo(){
    this.router.navigate(["usuario/login"])
  }

  cadastrarGo(){
    this.router.navigate(["usuario/cadastrar"])
  }

  calcRecomendacao(positivo: number, negativo: number){
    let total = positivo + negativo
    if(total == 0)
    {
      return `Sem Reviews`
    } else {
      let posVal = (positivo * 100) / total
      let negVal = (negativo * 100) / total
      
      return ` ${posVal.toFixed(1)}% / ${negVal.toFixed(1)}% `
    }
  }

  buscarFavs(){
    this.client.get<LivroFavoritado[]>(`https://localhost:7038/livroFavoritado/listar/${this.app.usuario.username}`)
      .subscribe({
        next: (livros) => {
          this.livros = livros
          this.app.usuario.livrosFavoritados = livros
        },
        error: (error) => {
          console.log(error)
        }
      })
  }

  tirarFav(id: number){
    let username : string = this.app.usuario.username
    if(username != undefined && username != null && id > 0)
    {
      this.client.delete(`https://localhost:7038/usuario/desfavoritar/${username}/${id}`)
      .subscribe({
        next: (response) => {
          this.buscarFavs();
          window.location.reload();
          console.log(response)
        },
        error: (error) => {
          console.log(error)
        }
      })
    } else {
      console.log(username, id)
    }
  }
  
}
