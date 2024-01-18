namespace backend.DTOs;

public class LivroDTO
{
    public string Titulo { get; set; } = "";
    public string Sinopse { get; set; } = "";
    public int QuantidadePaginas { get; set; }
    public string DataLançamento { get; set; } = "";
    public string Categoria { get; set; } = "";
    public string Genero { get; set; } = "";
    public string Editora { get; set; } = "";
    public string Autor { get; set; } = "";
}