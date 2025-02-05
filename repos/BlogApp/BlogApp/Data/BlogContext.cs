﻿using BlogApp.Models;
using Microsoft.EntityFrameworkCore;

namespace BlogApp.Data
{
    public class BlogContext : DbContext
    {
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }
        public BlogContext(DbContextOptions<BlogContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Configuration for Book
            modelBuilder.Entity<Post>()
                .HasKey(b => b.Id);

            modelBuilder.Entity<Post>()
                .HasOne(b => b.Blog)
                .WithMany(a => a.Posts)
                .HasForeignKey(b => b.BlogId)
                .OnDelete(DeleteBehavior.Cascade); // Use cascade delete
        }
    }
}
