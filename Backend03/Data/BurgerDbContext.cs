using Backend03.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend03.Data
{
    public class BurgerDbContext : DbContext
    {
        public DbSet<Restaurant> Restaurants { get; set;}
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=BurgerDb;Trusted_Connection=True;TrustServerCertificate=True");
            base.OnConfiguring(optionsBuilder);
        }

        public BurgerDbContext()
        {
            Database.EnsureCreated();
        }
    }
}
