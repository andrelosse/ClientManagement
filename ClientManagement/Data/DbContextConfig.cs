using Microsoft.EntityFrameworkCore;
using ClientManagement.Models;

namespace ClientManagement.Data
{
    public class DbContextConfig : DbContext
    {
        public DbContextConfig(DbContextOptions<DbContextConfig> options) : base(options) {
        
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<PessoaFisica> PessoasFisicas { get; set; }
        public DbSet<Genero> Generos { get; set; }
        public DbSet<TipoPessoa> TiposPessoas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Genero>().HasData(
                new Genero { GeneroId = 1, NomeGenero = "Outro" },
                new Genero { GeneroId = 2, NomeGenero = "Feminino" },
                new Genero { GeneroId = 3, NomeGenero = "Masculino" }
                );

            modelBuilder.Entity<TipoPessoa>().HasData(
                new TipoPessoa { TipoPessoaId = 1, NomeTipo = "Física" },
                new TipoPessoa { TipoPessoaId = 2, NomeTipo = "Jurídica" }
                );
        }
    }
}
