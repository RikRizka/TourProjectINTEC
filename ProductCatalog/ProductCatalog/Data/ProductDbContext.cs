using Microsoft.EntityFrameworkCore;
using ProductCatalog.Models;
namespace ProductCatalog.Data
{
    public class ProductDbContext : DbContext
    {


        public ProductDbContext(DbContextOptions<ProductDbContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasKey(a => a.CategoryId);
            modelBuilder.Entity<Category>().HasMany(a => a.Producten)
                .WithOne(b => b.Category)
                .HasForeignKey(b => b.CategoryId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Product>().HasKey(a => a.ProductId);
            modelBuilder.Entity<Product>().HasOne(x => x.Category)
                .WithMany(x => x.Producten)
                .HasForeignKey(x => x.CategoryId);

            SeedData.AddRecords(modelBuilder);
        }
    }
        


}
