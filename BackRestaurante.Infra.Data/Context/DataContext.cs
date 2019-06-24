using BackRestaurante.Domain.Entities;
using BackRestaurante.Infra.Data.Map;
using Microsoft.EntityFrameworkCore;

namespace BackRestaurante.Infra.Data.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Restaurante> Restaurantes { get; set; }

        public DbSet<Prato> Pratos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.ApplyConfiguration(new PratoMap());
            modelBuilder.ApplyConfiguration(new RestauranteMap());
            base.OnModelCreating(modelBuilder);


        }



        

    }
}
