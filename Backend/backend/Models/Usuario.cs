namespace backend.Models;

public class Usuario
{
    public int UsuarioId { get; set; }
    public string Username { get; set; } = "";
    public string Senha { get; set; } = "";
    public ICollection<LivroFavoritado> LivrosFavoritados { get; set; }

}