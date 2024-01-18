import { Livro } from "./livro.models";
import { Usuario } from "./usuario.models";

export interface LivroFavoritado {
    usuarioId: number;
    livroId: number;
    usuario: Usuario;
    livro: Livro;
}