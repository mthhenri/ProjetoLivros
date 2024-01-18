import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { AppComponent } from 'src/app/app.component';
import { Livro } from 'src/app/models/livro.models';
import { faHeart, faHeartCrack, faStar } from '@fortawesome/free-solid-svg-icons';
import { MessageService } from 'primeng/api';
import { LivroFavoritado } from 'src/app/models/livroFavoritado.models';
import { delay } from 'rxjs';

@Component({
  selector: 'app-home-livros',
  templateUrl: './home-livros.component.html',
  styleUrls: ['./home-livros.component.css'],
  providers: [MessageService]
})
export class HomeLivrosComponent {
  constructor(
    private router: Router,
    private client: HttpClient,
    private app: AppComponent,
    private messageService: MessageService
  ){}

  ngOnInit(){
    this.buscarLivros();
  }

  livros: Livro[] = []
  like = faHeart
  unlike = faHeartCrack
  fav = faStar
  btnClicado = false

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

  buscarLivros(){
    this.client.get<Livro[]>("https://localhost:7038/livros/listar/todos")
    .subscribe({
      next: (livros) => {
        this.livros = livros
      },
      error: (error) => {
        console.log(error)
      }
    })
  }

  recomendar(id: number){
    this.client.put(`https://localhost:7038/livros/recomendacao/positiva/${id}`, null)
    .subscribe({
      next: (response) => {
        this.buscarLivros();
        window.location.reload();
        console.log(response)
      },
      error: (error) => {
        console.log(error)
      }
    })
  }

  naorecomendar(id: number){
    this.client.put(`https://localhost:7038/livros/recomendacao/negativa/${id}`, null)
    .subscribe({
      next: (response) => {
        this.buscarLivros();
        window.location.reload();    
        console.log(response)
      },
      error: (error) => {
        console.log(error)
      }
    })
  }

  favoritar(id: number){
    this.client.put(`https://localhost:7038/usuario/favoritar/${this.app.usuario.username}/${id}`, null)
    .subscribe({
      next: (response) => {
        this.buscarLivros();
        this.app.ngOnInit();
        window.location.reload();
        console.log(response)
      },
      error: (error) => {
        console.log(error)
      }
    })
  }

  jaFavoritado(id: number) : boolean{
    let livrosUser : LivroFavoritado[] | undefined = this.app.usuario.livrosFavoritados
    let check : boolean = false
    if(livrosUser != undefined && livrosUser != null)
    {
      livrosUser.forEach(livro => {
        if(livro.livro.livroId == id)
        {
          check = true
        }
      });
      if(check)
      {
        return true;
      }
      return false;
    }
    return false
    // this.client.get<LivroFavoritado[]>(`https://localhost:7038/livroFavoritado/listar/${this.app.usuario.username}`)
    // .subscribe({
    //   next: (livros) => {
    //     let livroCheck : boolean = false
    //     livros.forEach(livro => {
    //       if(livro.livro.livroId == id)
    //       {
    //         livroCheck = true
    //       }
    //     });
    //     if(livroCheck)
    //     {
    //       return true;
    //     }
    //     return false;
    //   },
    //   error: (error) => {
    //     console.log(error)
    //     return false;
    //   }
    // })
    // return false;
  }

}
