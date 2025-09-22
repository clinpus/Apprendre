using Domain;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Infrastructure
{
    public class ApplicationDbContext : DbContext
    {
        // DbSet représente la table 'Products' dans votre base de données
        public DbSet<Product> Products { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
    }
}