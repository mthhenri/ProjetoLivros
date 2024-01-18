using System.Security.Cryptography;
using backend.Database;
using backend.DTOs;
using backend.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace backend.Controllers;

[ApiController]
[Route("usuario")]
public class UsuarioController : ControllerBase
{
    private readonly BancoDeDados _db;
    public UsuarioController(BancoDeDados db)
    {
        _db = db;
    }

    static bool VerificarSenha(string senhaEnviada, string senhaReal)
    {
        if(senhaEnviada != senhaReal)
        {
            return false;
        }
        return true;
    }

    [HttpPost("cadastrar")]
    public IActionResult CadastrarUsuario([FromBody] UsuarioDTO usuarioDTO)
    {
        try
        {
            Usuario usuario = new()
            {
                Username = usuarioDTO.Username,
                Senha = usuarioDTO.Senha
            };

            if(_db.Usuarios.FirstOrDefault(u => u.Username.ToLower() == usuarioDTO.Username.ToLower()) != null)
            {
                return BadRequest("Usuário já existente!"); 
            }

            _db.Usuarios.Add(usuario);
            _db.SaveChanges();

            return Created("", usuario);
        }
        catch (Exception error)
        {
            Console.WriteLine(error);
            return BadRequest();
        }
    }

    [HttpPut("entrar")]
    public IActionResult EntrarConta([FromBody] UsuarioDTO usuarioDTO)
    {
        try
        {
            Usuario usuario = _db.Usuarios
                .FirstOrDefault(u => u.Username.ToLower() == usuarioDTO.Username.ToLower());

            if(usuario == null)
            {
                return BadRequest("Usuário não encontrado!");
            }

            if(VerificarSenha(usuarioDTO.Senha, usuario.Senha))
            {
                return Ok(usuario);                
            }

            return BadRequest("Senha incorreta!");
        }
        catch (Exception error)
        {
            Console.WriteLine(error);
            return BadRequest();
        }
    }

    [HttpGet("buscar/{username}")]
    public IActionResult BuscarUsuario([FromRoute] string username)
    {
        try
        {
            Usuario usuario = _db.Usuarios
                .FirstOrDefault(u => u.Username.ToLower() == username.ToLower());
            
            return Ok(usuario);
        }
        catch (Exception error)
        {
            Console.WriteLine(error);
            return BadRequest();
        }
    }


    [HttpPut("favoritar/{usernameUsuario}/{idLivro}")]
    public IActionResult FavoritarLivro([FromRoute] string usernameUsuario, [FromRoute] int idLivro)
    {
        try
        {
            Usuario usuario = _db.Usuarios.FirstOrDefault(u => u.Username.ToLower() == usernameUsuario.ToLower());
            Livro livro = _db.Livros.FirstOrDefault(l => l.LivroId == idLivro);

            LivroFavoritado favorito = new()
            {
                Usuario = usuario,
                Livro = livro
            };

            _db.LivrosFavoritados.Add(favorito);
            _db.SaveChanges();

            return Ok("Favoritado!");
        }
        catch (Exception error)
        {
            Console.WriteLine(error);
            return BadRequest();
        }
    }

    [HttpDelete("desfavoritar/{usernameUsuario}/{idLivro}")]
    public IActionResult DesfavoritarLivro([FromRoute] string usernameUsuario, [FromRoute] int idLivro)
    {
        try
        {
            Usuario usuario = _db.Usuarios.FirstOrDefault(u => u.Username.ToLower() == usernameUsuario.ToLower());
            LivroFavoritado favorito = _db.LivrosFavoritados.FirstOrDefault(l => l.UsuarioId == usuario.UsuarioId && l.LivroId == idLivro);

            if(favorito != null){
                _db.LivrosFavoritados.Remove(favorito);
                _db.SaveChanges();

                return Ok("Desfavoritado!");
            }
            return BadRequest("Não encontrado!");
        }
        catch (Exception error)
        {
            Console.WriteLine(error.Message);
            return BadRequest();
        }
    }
}