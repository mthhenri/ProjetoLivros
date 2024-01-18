using backend.Models;
using Microsoft.EntityFrameworkCore;

namespace backend.Database;
public class BancoDeDados : DbContext
{
    public BancoDeDados(DbContextOptions<BancoDeDados> options) : base(options)
    {
    }

    public DbSet<Usuario> Usuarios {get; set;}
    public DbSet<Livro> Livros {get; set;}
    public DbSet<LivroFavoritado> LivrosFavoritados { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite("Data Source=database.db");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        var random = new Random();
        modelBuilder.Entity<Livro>().HasData(
        new Livro
        {
            LivroId = 1,
            Titulo = "1984",
            Sinopse = "Distopia sobre um regime totalitário de vigilância.",
            QuantidadePaginas = random.Next(50, 401),
            RecomendacaoPositiva = random.Next(10, 51),
            RecomendacaoNegativa = random.Next(10, 51),
            DataLancamento = "08/06/1949",
            Categoria = "Ficção",
            Genero = "Distopia",
            Editora = "Editora Secker and Warburg",
            Autor = "George Orwell"
        },
        new Livro
        {
            LivroId = 2,
            Titulo = "O Senhor dos Anéis",
            Sinopse = "Épico de fantasia sobre a luta contra o mal em uma terra mítica.",
            QuantidadePaginas = random.Next(50, 401),
            RecomendacaoPositiva = random.Next(10, 51),
            RecomendacaoNegativa = random.Next(10, 51),
            DataLancamento = "29/07/1954",
            Categoria = "Fantasia",
            Genero = "Alta Fantasia",
            Editora = "Allen & Unwin",
            Autor = "J.R.R. Tolkien"
        },
        new Livro
        {
            LivroId = 3,
            Titulo = "O Pequeno Príncipe",
            Sinopse = "Uma fábula sobre amor e perda, vista através dos olhos de um príncipe viajante.",
            QuantidadePaginas = random.Next(50, 401),
            RecomendacaoPositiva = random.Next(10, 51),
            RecomendacaoNegativa = random.Next(10, 51),
            DataLancamento = "06/04/1943",
            Categoria = "Infantil",
            Genero = "Fábula",
            Editora = "Reynal & Hitchcock",
            Autor = "Antoine de Saint-Exupéry"
        },
        new Livro
        {
            LivroId = 4,
            Titulo = "A Culpa é das Estrelas",
            Sinopse = "Uma emocionante história de amor e tragédia de dois adolescentes com câncer.",
            QuantidadePaginas = random.Next(50, 401),
            RecomendacaoPositiva = random.Next(10, 51),
            RecomendacaoNegativa = random.Next(10, 51),
            DataLancamento = "10/01/2012",
            Categoria = "Romance",
            Genero = "Drama",
            Editora = "Dutton Books",
            Autor = "John Green"
        },
        new Livro
        {
            LivroId = 5,
            Titulo = "Dom Quixote",
            Sinopse = "As aventuras de um nobre espanhol obcecado por histórias de cavalaria.",
            QuantidadePaginas = random.Next(50, 401),
            RecomendacaoPositiva = random.Next(10, 51),
            RecomendacaoNegativa = random.Next(10, 51),
            DataLancamento = "16/01/1605",
            Categoria = "Romance",
            Genero = "Paródia",
            Editora = "Francisco de Robles",
            Autor = "Miguel de Cervantes"
        },
        new Livro
        {
            LivroId = 6,
            Titulo = "A Revolução dos Bichos",
            Sinopse = "Uma sátira política sobre animais que buscam liberdade em uma fazenda.",
            QuantidadePaginas = random.Next(50, 401),
            RecomendacaoPositiva = random.Next(10, 51),
            RecomendacaoNegativa = random.Next(10, 51),
            DataLancamento = "17/08/1945",
            Categoria = "Ficção",
            Genero = "Sátira",
            Editora = "Secker and Warburg",
            Autor = "George Orwell"
        },
        new Livro
        {
            LivroId = 7,
            Titulo = "A Menina que Roubava Livros",
            Sinopse = "Uma história emocionante ambientada na Alemanha nazista, narrada pela Morte.",
            QuantidadePaginas = random.Next(50, 401),
            RecomendacaoPositiva = random.Next(10, 51),
            RecomendacaoNegativa = random.Next(10, 51),
            DataLancamento = "23/09/2005",
            Categoria = "Histórico",
            Genero = "Drama",
            Editora = "Intrínseca",
            Autor = "Markus Zusak"
        },
        new Livro
        {
            LivroId = 8,
            Titulo = "Fahrenheit 451",
            Sinopse = "Em um futuro distópico, os livros são proibidos e os 'bombeiros' queimam qualquer um que encontram.",
            QuantidadePaginas = random.Next(50, 401),
            RecomendacaoPositiva = random.Next(10, 51),
            RecomendacaoNegativa = random.Next(10, 51),
            DataLancamento = "19/10/1953",
            Categoria = "Ficção",
            Genero = "Distopia",
            Editora = "Ballantine Books",
            Autor = "Ray Bradbury"
        },
        new Livro
        {
            LivroId = 9,
            Titulo = "O Sol é Para Todos",
            Sinopse = "Um clássico da literatura americana que aborda questões de justiça e preconceito racial.",
            QuantidadePaginas = random.Next(50, 401),
            RecomendacaoPositiva = random.Next(10, 51),
            RecomendacaoNegativa = random.Next(10, 51),
            DataLancamento = "11/07/1960",
            Categoria = "Ficção",
            Genero = "Drama",
            Editora = "J. B. Lippincott & Co.",
            Autor = "Harper Lee"
        },
        new Livro
        {
            LivroId = 10,
            Titulo = "Alice no País das Maravilhas",
            Sinopse = "A clássica história de uma menina que cai em um buraco de coelho e entra em um mundo de fantasia.",
            QuantidadePaginas = random.Next(50, 401),
            RecomendacaoPositiva = random.Next(10, 51),
            RecomendacaoNegativa = random.Next(10, 51),
            DataLancamento = "26/11/1865",
            Categoria = "Fantasia",
            Genero = "Literatura Infantil",
            Editora = "Macmillan",
            Autor = "Lewis Carroll"
        }
        );

        modelBuilder.Entity<Usuario>().HasData(
            new Usuario{
                UsuarioId = 1,
                Username = "dev",
                Senha = "1234"
            }
        );

        modelBuilder.Entity<LivroFavoritado>()
            .HasKey(lf => new { lf.UsuarioId, lf.LivroId });

        modelBuilder.Entity<LivroFavoritado>()
            .HasOne(lf => lf.Usuario)
            .WithMany(u => u.LivrosFavoritados)
            .HasForeignKey(lf => lf.UsuarioId);

        modelBuilder.Entity<LivroFavoritado>()
            .HasOne(lf => lf.Livro)
            .WithMany(l => l.LivrosFavoritados)
            .HasForeignKey(lf => lf.LivroId);

        base.OnModelCreating(modelBuilder);
    }
}
