using Microsoft.EntityFrameworkCore;
using RockySite.Models;

namespace RockySite.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> oprtions) : base(oprtions) 
        {

        }

        public DbSet<Category> Category { get; set; }

        public DbSet<Product> Product { get; set; }
    }
}

