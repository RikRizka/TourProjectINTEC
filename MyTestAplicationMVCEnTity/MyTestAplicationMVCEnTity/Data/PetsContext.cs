using Microsoft.EntityFrameworkCore;
using MyTestAplicationMVCEnTity.Controllers;
using MyTestAplicationMVCEnTity.Models;

namespace MyTestAplicationMVCEnTity.Data
{
    public class PetsContext : DbContext
    {
        public PetsContext(DbContextOptions<PetsContext> options) : base(options)
        {

        }
        public DbSet<Pets> Pets { get; set; }

        
    }
}
