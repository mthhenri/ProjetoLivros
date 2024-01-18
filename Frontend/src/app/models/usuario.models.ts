import { LivroFavoritado } from "./livroFavoritado.models";

export interface Usuario {
    usuarioId?: number;
    username: string;
    senha: string;
    livrosFavoritados?: LivroFavoritado[];
}