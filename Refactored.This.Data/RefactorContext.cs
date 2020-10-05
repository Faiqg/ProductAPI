using System.Linq;
using Microsoft.EntityFrameworkCore;
using Refactored.This.Model.Entities;

namespace Refactored.This.Data
{
    public class RefactorContext : DbContext
    {
        public DbSet<Product> Product { get; set; }
        public DbSet <ProductOption> ProductOption { get; set; }
        public DbSet<Location> Location { get; set; }
        public RefactorContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }
            modelBuilder.Entity<Product>()
                .Property(p => p.Price)
                .HasColumnType("decimal(18,2)");
            modelBuilder.Entity<Product>()
                .Property(p => p.DeliveryPrice)
                .HasColumnType("decimal(18,2)");
        }
    }
}
