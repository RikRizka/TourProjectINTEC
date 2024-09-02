using EF_RevisitedMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace EF_RevisitedMVC.Data
{
    public class StudentContext : DbContext
    {
        public StudentContext(DbContextOptions<StudentContext>opstions):base (opstions) 
        { 

        }
        public DbSet<Student> Students { get; set; }

    }
}
