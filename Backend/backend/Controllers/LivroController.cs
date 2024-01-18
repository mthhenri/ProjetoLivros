using backend.Database;
using backend.DTOs;
using backend.Models;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers;

[ApiController]
[Route("livros")]
public class LivroController : ControllerBase
{
    private readonly BancoDeDados _db;
    public LivroController(BancoDeDados db)
    {
        _db = db;
    }

    [HttpPost("cadastrar")]
    public IActionResult CadastrarLivro([FromBody] LivroDTO livroDTO)
    {
        try
        {
            Livro livroNovo = new()
            {
                Titulo = livroDTO.Titulo,
                Sinopse = livroDTO.Sinopse,
                QuantidadePaginas = livroDTO.QuantidadePaginas,
                DataLancamento = livroDTO.DataLançamento,
                Categoria = livroDTO.Categoria,
                Genero = livroDTO.Genero,
                Editora = livroDTO.Editora,
                Autor = livroDTO.Autor
            };

            _db.Livros.Add(livroNovo);
            _db.SaveChanges();
            return Created("", livroNovo);
        }
        catch (Exception error)
        {
            Console.WriteLine(error);
            return BadRequest();
        }
        
    }

    [HttpGet("buscar/{id}")]
    public IActionResult ListarLivrosEditora([FromRoute] int id)
    {
        try
        {
            Livro livro = _db.Livros.FirstOrDefault(l => l.LivroId == id);

            if(livro == null)
            {
                return BadRequest("Não encontrado!");
            }

            return Ok(livro);
        }
        catch (Exception error)
        {
            Console.WriteLine(error);
            return BadRequest();
        }
    }

    [HttpGet("listar/todos")]
    public IActionResult ListarLivrosTodos()
    {
        try
        {
            List<Livro> livros = _db.Livros.ToList();

            return Ok(livros);
        }
        catch (Exception error)
        {
            Console.WriteLine(error);
            return BadRequest();
        }
    }

    [HttpGet("listar/{editora}")]
    public IActionResult ListarLivrosEditora([FromRoute] string editora)
    {
        try
        {
            List<Livro> livros = _db.Livros.Where(l => l.Editora.ToLower() == editora.ToLower()).ToList();

            return Ok(livros);
        }
        catch (Exception error)
        {
            Console.WriteLine(error);
            return BadRequest();
        }
    }

    [HttpPut("recomendacao/positiva/{idLivro}")]
    public IActionResult RecomendarLivro([FromRoute] int idLivro){
        try
        {
            Livro? livro = _db.Livros.FirstOrDefault(l => l.LivroId == idLivro);

            if(livro == null)
            {
                return NotFound("Livro não encontrado");
            }

            livro.RecomendacaoPositiva += 1;

            _db.Livros.UpdateRange(livro);
            _db.SaveChanges();

            return Ok("Livro recomendado!");
        }
        catch (Exception error)
        {
            Console.WriteLine(error);
            return BadRequest();
        }
    }

    [HttpPut("recomendacao/negativa/{idLivro}")]
    public IActionResult NaoRecomendarLivro([FromRoute] int idLivro){
        try
        {
            Livro? livro = _db.Livros.FirstOrDefault(l => l.LivroId == idLivro);

            if(livro == null)
            {
                return NotFound("Livro não encontrado");
            }

            livro.RecomendacaoNegativa += 1;

            _db.Livros.UpdateRange(livro);
            _db.SaveChanges();

            return Ok("Livro não recomendado!");
        }
        catch (Exception error)
        {
            Console.WriteLine(error);
            return BadRequest();
        }
    }

    
}