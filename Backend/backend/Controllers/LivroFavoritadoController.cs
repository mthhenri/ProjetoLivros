using backend.Database;
using backend.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[ApiController]
[Route("livroFavoritado")]
public class LivroFavoritadoContoller : ControllerBase
{
    private readonly BancoDeDados _db;
    public LivroFavoritadoContoller(BancoDeDados db)
    {
        _db = db;
    }

    [HttpGet("listar/{usuarioUsername}")]
    public IActionResult BuscarFavoritos([FromRoute] string usuarioUsername)
    {
        try
        {
            List<LivroFavoritado> livrosFav = _db.LivrosFavoritados
                .Where(lv => lv.Usuario.Username.ToLower() == usuarioUsername.ToLower())
                    .Include(l => l.Livro)
                .ToList();

            if(livrosFav == null)
            {
                return BadRequest("Não há livros favoritados!");
            }

            return Ok(livrosFav);
        }
        catch (Exception error)
        {
            Console.WriteLine(error);
            return BadRequest();
        }
    }
}