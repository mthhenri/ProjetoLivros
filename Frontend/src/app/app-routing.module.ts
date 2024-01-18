import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './home/home/home.component';
import { UsuarioComponent } from './user/usuario/usuario.component';
import { HomeLivrosComponent } from './book/home-livros/home-livros.component';
import { UserCadastroComponent } from './user/cadastro/user-cadastro/user-cadastro.component';
import { UserLoginComponent } from './user/login/user-login/user-login.component';

const routes: Routes = [
  {
    path: "",
    component: HomeComponent
  },
  {
    path: "usuario",
    component: UsuarioComponent
  },
  {
    path: "livros",
    component: HomeLivrosComponent
  },
  {
    path: "usuario/cadastrar",
    component: UserCadastroComponent
  },
  {
    path: "usuario/login",
    component: UserLoginComponent
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
