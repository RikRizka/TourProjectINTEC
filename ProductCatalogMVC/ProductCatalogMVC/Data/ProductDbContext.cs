using Microsoft.EntityFrameworkCore;
using ProductCatalog.Models;

namespace ProductCatalog.Data
{
    public class ProductDbContext : DbContext
    {
        
        public ProductDbContext (DbContextOptions<ProductDbContext> options) : base(options) { }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //configure Auteur entity
            modelBuilder.Entity<Category>()
                .HasKey(a => a.CategoryId);
            modelBuilder.Entity<Category>()
                .HasMany(a => a.Products)
                .WithOne(b => b.Category)
                .HasForeignKey(b => b.ProductId)
                .OnDelete(DeleteBehavior.NoAction);


             // configure Boek entity
            modelBuilder.Entity<Product>()
                .HasKey(b => b.ProductId);
            modelBuilder.Entity<Product>()
                .HasOne(b => b.Category)
                .WithMany(a => a.Products)
                .HasForeignKey(b => b.ProductId)
                .OnDelete(DeleteBehavior.NoAction);

            SeedData.AddRecords(modelBuilder);
        }

    }



}
