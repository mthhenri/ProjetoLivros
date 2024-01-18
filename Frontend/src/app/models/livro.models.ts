import { LivroFavoritado } from "./livroFavoritado.models";

export interface Livro {
    livroId: number;
    titulo: string;
    sinopse: string;
    quantidadePaginas: number;
    recomendacaoPositiva: number;
    recomendacaoNegativa: number;
    dataCadastro: string;
    dataLancamento: string;
    categoria: string;
    genero: string;
    editora: string;
    autor: string;
    livrosFavoritados: LivroFavoritado[];
}