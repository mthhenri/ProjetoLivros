using System.Text.Json.Serialization;

namespace backend.Models;

public class LivroFavoritado
{
    [JsonIgnore]
    public int UsuarioId { get; set; }
    [JsonIgnore]
    public int LivroId { get; set; }
    public Usuario Usuario { get; set; }
    public Livro Livro { get; set; }
}