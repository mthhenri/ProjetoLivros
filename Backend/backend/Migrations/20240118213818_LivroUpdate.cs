using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace backend.Migrations
{
    public partial class LivroUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DataLançamento",
                table: "Livros",
                newName: "DataLancamento");

            migrationBuilder.AddColumn<string>(
                name: "Autor",
                table: "Livros",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Livros",
                columns: new[] { "LivroId", "Autor", "Categoria", "DataCadastro", "DataLancamento", "Editora", "Genero", "QuantidadePaginas", "RecomendacaoNegativa", "RecomendacaoPositiva", "Sinopse", "Titulo" },
                values: new object[] { 1, "George Orwell", "Ficção", new DateTime(2024, 1, 18, 18, 38, 17, 989, DateTimeKind.Local).AddTicks(9610), "08/06/1949", "Editora Secker and Warburg", "Distopia", 135, 13, 43, "Distopia sobre um regime totalitário de vigilância.", "1984" });

            migrationBuilder.InsertData(
                table: "Livros",
                columns: new[] { "LivroId", "Autor", "Categoria", "DataCadastro", "DataLancamento", "Editora", "Genero", "QuantidadePaginas", "RecomendacaoNegativa", "RecomendacaoPositiva", "Sinopse", "Titulo" },
                values: new object[] { 2, "J.R.R. Tolkien", "Fantasia", new DateTime(2024, 1, 18, 18, 38, 17, 989, DateTimeKind.Local).AddTicks(9634), "29/07/1954", "Allen & Unwin", "Alta Fantasia", 92, 49, 17, "Épico de fantasia sobre a luta contra o mal em uma terra mítica.", "O Senhor dos Anéis" });

            migrationBuilder.InsertData(
                table: "Livros",
                columns: new[] { "LivroId", "Autor", "Categoria", "DataCadastro", "DataLancamento", "Editora", "Genero", "QuantidadePaginas", "RecomendacaoNegativa", "RecomendacaoPositiva", "Sinopse", "Titulo" },
                values: new object[] { 3, "Antoine de Saint-Exupéry", "Infantil", new DateTime(2024, 1, 18, 18, 38, 17, 989, DateTimeKind.Local).AddTicks(9639), "06/04/1943", "Reynal & Hitchcock", "Fábula", 321, 15, 26, "Uma fábula sobre amor e perda, vista através dos olhos de um príncipe viajante.", "O Pequeno Príncipe" });

            migrationBuilder.InsertData(
                table: "Livros",
                columns: new[] { "LivroId", "Autor", "Categoria", "DataCadastro", "DataLancamento", "Editora", "Genero", "QuantidadePaginas", "RecomendacaoNegativa", "RecomendacaoPositiva", "Sinopse", "Titulo" },
                values: new object[] { 4, "John Green", "Romance", new DateTime(2024, 1, 18, 18, 38, 17, 989, DateTimeKind.Local).AddTicks(9643), "10/01/2012", "Dutton Books", "Drama", 309, 38, 41, "Uma emocionante história de amor e tragédia de dois adolescentes com câncer.", "A Culpa é das Estrelas" });

            migrationBuilder.InsertData(
                table: "Livros",
                columns: new[] { "LivroId", "Autor", "Categoria", "DataCadastro", "DataLancamento", "Editora", "Genero", "QuantidadePaginas", "RecomendacaoNegativa", "RecomendacaoPositiva", "Sinopse", "Titulo" },
                values: new object[] { 5, "Miguel de Cervantes", "Romance", new DateTime(2024, 1, 18, 18, 38, 17, 989, DateTimeKind.Local).AddTicks(9647), "16/01/1605", "Francisco de Robles", "Paródia", 68, 20, 19, "As aventuras de um nobre espanhol obcecado por histórias de cavalaria.", "Dom Quixote" });

            migrationBuilder.InsertData(
                table: "Livros",
                columns: new[] { "LivroId", "Autor", "Categoria", "DataCadastro", "DataLancamento", "Editora", "Genero", "QuantidadePaginas", "RecomendacaoNegativa", "RecomendacaoPositiva", "Sinopse", "Titulo" },
                values: new object[] { 6, "George Orwell", "Ficção", new DateTime(2024, 1, 18, 18, 38, 17, 989, DateTimeKind.Local).AddTicks(9651), "17/08/1945", "Secker and Warburg", "Sátira", 148, 27, 40, "Uma sátira política sobre animais que buscam liberdade em uma fazenda.", "A Revolução dos Bichos" });

            migrationBuilder.InsertData(
                table: "Livros",
                columns: new[] { "LivroId", "Autor", "Categoria", "DataCadastro", "DataLancamento", "Editora", "Genero", "QuantidadePaginas", "RecomendacaoNegativa", "RecomendacaoPositiva", "Sinopse", "Titulo" },
                values: new object[] { 7, "Markus Zusak", "Histórico", new DateTime(2024, 1, 18, 18, 38, 17, 989, DateTimeKind.Local).AddTicks(9654), "23/09/2005", "Intrínseca", "Drama", 351, 10, 39, "Uma história emocionante ambientada na Alemanha nazista, narrada pela Morte.", "A Menina que Roubava Livros" });

            migrationBuilder.InsertData(
                table: "Livros",
                columns: new[] { "LivroId", "Autor", "Categoria", "DataCadastro", "DataLancamento", "Editora", "Genero", "QuantidadePaginas", "RecomendacaoNegativa", "RecomendacaoPositiva", "Sinopse", "Titulo" },
                values: new object[] { 8, "Ray Bradbury", "Ficção", new DateTime(2024, 1, 18, 18, 38, 17, 989, DateTimeKind.Local).AddTicks(9658), "19/10/1953", "Ballantine Books", "Distopia", 213, 21, 22, "Em um futuro distópico, os livros são proibidos e os 'bombeiros' queimam qualquer um que encontram.", "Fahrenheit 451" });

            migrationBuilder.InsertData(
                table: "Livros",
                columns: new[] { "LivroId", "Autor", "Categoria", "DataCadastro", "DataLancamento", "Editora", "Genero", "QuantidadePaginas", "RecomendacaoNegativa", "RecomendacaoPositiva", "Sinopse", "Titulo" },
                values: new object[] { 9, "Harper Lee", "Ficção", new DateTime(2024, 1, 18, 18, 38, 17, 989, DateTimeKind.Local).AddTicks(9661), "11/07/1960", "J. B. Lippincott & Co.", "Drama", 134, 13, 50, "Um clássico da literatura americana que aborda questões de justiça e preconceito racial.", "O Sol é Para Todos" });

            migrationBuilder.InsertData(
                table: "Livros",
                columns: new[] { "LivroId", "Autor", "Categoria", "DataCadastro", "DataLancamento", "Editora", "Genero", "QuantidadePaginas", "RecomendacaoNegativa", "RecomendacaoPositiva", "Sinopse", "Titulo" },
                values: new object[] { 10, "Lewis Carroll", "Fantasia", new DateTime(2024, 1, 18, 18, 38, 17, 989, DateTimeKind.Local).AddTicks(9665), "26/11/1865", "Macmillan", "Literatura Infantil", 343, 32, 18, "A clássica história de uma menina que cai em um buraco de coelho e entra em um mundo de fantasia.", "Alice no País das Maravilhas" });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "UsuarioId", "Senha", "Username" },
                values: new object[] { 1, "1234", "dev" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Livros",
                keyColumn: "LivroId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Livros",
                keyColumn: "LivroId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Livros",
                keyColumn: "LivroId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Livros",
                keyColumn: "LivroId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Livros",
                keyColumn: "LivroId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Livros",
                keyColumn: "LivroId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Livros",
                keyColumn: "LivroId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Livros",
                keyColumn: "LivroId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Livros",
                keyColumn: "LivroId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Livros",
                keyColumn: "LivroId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "UsuarioId",
                keyValue: 1);

            migrationBuilder.DropColumn(
                name: "Autor",
                table: "Livros");

            migrationBuilder.RenameColumn(
                name: "DataLancamento",
                table: "Livros",
                newName: "DataLançamento");
        }
    }
}
