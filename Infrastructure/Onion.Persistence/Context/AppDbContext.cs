using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using Onion.Domain.Entities;

namespace Onion.Persistence.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {


        }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Product> Products { get; set; }

    }
}
