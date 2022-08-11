using Microsoft.EntityFrameworkCore;
using Cliente.Models;

namespace Cliente.Data
{
    public class Connection : DbContext
    {
        public Connection(DbContextOptions<Connection> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        // Refatorar Código, retirar nulabilidade

        public DbSet<Cons>? Clientes { get; set; }
        public DbSet<Endereço>? Endereços { get; set; }
        public DbSet<Genero>? Generos { get; set; }
        public DbSet<UnidadeFederativa>? Uf { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cons>(entity => {

                entity.HasKey(x => x.Id);
            });

            
                
        }
    }
}