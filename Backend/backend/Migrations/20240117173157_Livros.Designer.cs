﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using backend.Database;

#nullable disable

namespace backend.Migrations
{
    [DbContext(typeof(BancoDeDados))]
    [Migration("20240117173157_Livros")]
    partial class Livros
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.21");

            modelBuilder.Entity("backend.Models.Livro", b =>
                {
                    b.Property<int>("LivroId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Categoria")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("TEXT");

                    b.Property<string>("DataLançamento")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Editora")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Genero")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("QuantidadePaginas")
                        .HasColumnType("INTEGER");

                    b.Property<int>("RecomendacaoNegativa")
                        .HasColumnType("INTEGER");

                    b.Property<int>("RecomendacaoPositiva")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Sinopse")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("UsuarioId")
                        .HasColumnType("INTEGER");

                    b.HasKey("LivroId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Livros");
                });

            modelBuilder.Entity("backend.Models.Usuario", b =>
                {
                    b.Property<int>("UsuarioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("UsuarioId");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("backend.Models.Livro", b =>
                {
                    b.HasOne("backend.Models.Usuario", null)
                        .WithMany("LivrosFavoritados")
                        .HasForeignKey("UsuarioId");
                });

            modelBuilder.Entity("backend.Models.Usuario", b =>
                {
                    b.Navigation("LivrosFavoritados");
                });
#pragma warning restore 612, 618
        }
    }
}