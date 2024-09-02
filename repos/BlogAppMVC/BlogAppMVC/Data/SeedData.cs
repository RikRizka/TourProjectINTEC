using BlogApp.Models;
using Microsoft.EntityFrameworkCore;

namespace BlogApp.Data
{
    public class SeedData
    {
        public static void AddRecords(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Blog>().HasData(
            new Blog { Id = 1, Name = "Author 1", Description = "Description 1" },
            new Blog { Id = 2, Name = "Author 2", Description = "Description 1" }
        );
            modelBuilder.Entity<Post>().HasData( //
                new Post { Id = 1, Title = "Book 1", BlogId = 1, Content = "Content 1", CreatedAt = DateTime.Now },
                new Post { Id = 2, Title = "Book 2", BlogId = 2, Content = "Content 2", CreatedAt = DateTime.Now },
                new Post { Id = 3, Title = "Book 3", BlogId = 2, Content = "Content 3", CreatedAt = DateTime.Now },
                new Post { Id = 4, Title = "Book 4", BlogId = 1, Content = "Content 4", CreatedAt = DateTime.Now },
                new Post { Id = 5, Title = "Book 5", BlogId = 1, Content = "Content 5", CreatedAt = DateTime.Now }
        );
        }
    }
}
