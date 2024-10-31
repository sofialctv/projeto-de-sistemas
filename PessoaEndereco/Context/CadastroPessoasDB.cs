using CadastroPessoas.Models;
using Microsoft.EntityFrameworkCore;

// "A DbContext instance represents a session with the database and can be used to query and save instances of your entities."

namespace CadastroPessoas.Context
{
    public class CadastroPessoasDB : DbContext
    {
        public CadastroPessoasDB(DbContextOptions<CadastroPessoasDB> options) : base(options) { }

        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pessoa>() // Configurando entidade Pessoa
                .HasMany(p => p.Enderecos)      // Uma pessoa pode ter vários endereços
                .WithOne(e => e.Pessoa)         // Um endereço está associado a somente uma pessoa
                .HasForeignKey(e => e.PessoaId)
                .OnDelete(DeleteBehavior.Cascade);    // Se uma pessoa for deletada, todos os seus endereços relacionados também serão deletados automaticamente   
        }
    }
}

// "A DbSet<TEntity> can be used to query and save instances of TEntity." - TEntity = The type of entity being operated on by this set.

// A classe DbSet<TEntity> representa uma coleção para uma determinada entidade dentro do modelo e é a porta de entrada para as operações de banco de dados em uma entidade.

// O método Property() no Entity Framework é usado para configurar propriedades específicas de uma entidade. No caso, quero definir que PessoaId pode ser nulo