using Microsoft.EntityFrameworkCore;
using PetshopWebApp.Models;

namespace PetshopWebApp.Data
{
    public class PetshopContext : DbContext
    {
        public PetshopContext(DbContextOptions<PetshopContext> options) : base(options)
        {
        }

        public DbSet<Products> Products { get; set; }
        public DbSet<Categories> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Products>().ToTable("Products");
            modelBuilder.Entity<Categories>().ToTable("Categories");
        }
    }
}
