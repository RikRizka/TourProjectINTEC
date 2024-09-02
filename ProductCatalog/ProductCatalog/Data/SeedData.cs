using Microsoft.EntityFrameworkCore;
using ProductCatalog.Models;

namespace ProductCatalog.Data
{
    public class SeedData
    {
        public static void AddRecords(ModelBuilder modelBuilder)
        {

            // seeding data
            modelBuilder.Entity<Product>().HasData(
                               new Product { ProductId = 1, ProductName = "Binggo", Price = 10.1m, CategoryId = 3 },
                               new Product { ProductId = 2, ProductName = "Cimochi", Price = 3.5m, CategoryId = 2 },
                               new Product { ProductId = 3, ProductName = "Loulou", Price = 2.19m, CategoryId = 4 },
                               new Product { ProductId = 5, ProductName = "Coucou", Price = 6.1m, CategoryId = 4 },
                               new Product { ProductId = 6, ProductName = "Desparcito", Price = 6.1m, CategoryId = 3 },
                               new Product { ProductId = 7, ProductName = "Belachelijk", Price = 6.1m, CategoryId = 4 },
                               new Product { ProductId = 8, ProductName = "Marsupilami", Price = 6.1m, CategoryId = 1 },
                               new Product { ProductId = 9, ProductName = "NumNum", Price = 6.1m, CategoryId = 2 },
                               new Product { ProductId = 10, ProductName = "Tom&Jery", Price = 6.1m, CategoryId = 1 }
                      
            );


            modelBuilder.Entity<Category>().HasData(
                               new Category { CategoryId = 1, Name = "Kids Book" },
                               new Category { CategoryId = 2, Name = "Food" },
                               new Category { CategoryId = 3, Name = "Comik" },
                               new Category { CategoryId = 4, Name = "Adult Book" }
                             

           );
        }
    }
}

