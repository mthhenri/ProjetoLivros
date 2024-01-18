using System.Text.Json.Serialization;

namespace backend.Models;

public class Livro
{
    public int LivroId { get; set; }
    public string Titulo { get; set; } = "";
    public string Sinopse { get; set; } = "";
    public int QuantidadePaginas { get; set; }
    public int RecomendacaoPositiva { get; set; }
    public int RecomendacaoNegativa { get; set; }
    public DateTime DataCadastro { get; set; } = DateTime.Now;
    public string DataLancamento { get; set; } = "";
    public string Categoria { get; set; } = "";
    public string Genero { get; set; } = "";
    public string Editora { get; set; } = "";
    public string Autor { get; set; } = "";
    [JsonIgnore]
    public ICollection<LivroFavoritado> LivrosFavoritados { get; set; }
}