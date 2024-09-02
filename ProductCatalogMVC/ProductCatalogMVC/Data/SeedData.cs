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
                               new Product { ProductId = 1, ProductName = "Binggo", price = 10.1, CategoryId = 3 },
                               new Product { ProductId = 2, ProductName = "Cimochi", price = 3.5, CategoryId = 2 },
                               new Product { ProductId = 3, ProductName = "Loulou", price = 2.19, CategoryId = 4 },
                               new Product { ProductId = 4, ProductName = "Coucou", price = 6.1, CategoryId = 4 },
                               new Product { ProductId = 4, ProductName = "Desparcito", price = 6.1, CategoryId = 5 },
                               new Product { ProductId = 4, ProductName = "Belachelijk", price = 6.1, CategoryId = 4 },
                               new Product { ProductId = 4, ProductName = "Marsupilami", price = 6.1, CategoryId = 1 },
                               new Product { ProductId = 4, ProductName = "NumNum", price = 6.1, CategoryId = 2 },
                               new Product { ProductId = 4, ProductName = "Tom&Jery", price = 6.1, CategoryId = 1 }
            );

            modelBuilder.Entity<Category>().HasData(
                               new Category { CategoryId = 1, CategoryName = "Kids Book" },
                               new Category { CategoryId = 2, CategoryName = "Food" },
                               new Category { CategoryId = 3, CategoryName = "Comik" },
                               new Category { CategoryId = 4, CategoryName = "Adult Book" }
                             

           );
        }
    }
}

