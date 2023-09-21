using CadastroPessoas.Models;
using Microsoft.EntityFrameworkCore;

namespace CadastroPessoas.Data
{
        public class ApplicationDbContext : DbContext
        {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Pessoa> Pessoas { get; set; }
        // Adicione outros DbSets para outras entidades, se necessário

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configurações de mapeamento e restrições aqui
        }
        }

}
