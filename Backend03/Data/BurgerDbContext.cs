﻿using Backend03.Models;
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
        public DbSet<Worker> Workers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=BurgerDb;Trusted_Connection=True;TrustServerCertificate=True");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Restaurant>()
                .HasMany(r => r.Workers)
                .WithOne(p => p.Restaurant)
                .HasForeignKey(p => p.RestaurantId);

            modelBuilder.Entity<Restaurant>()
                .HasMany(r => r.Products)
                .WithMany(p => p.Restaurants);
                

            base.OnModelCreating(modelBuilder);
        }

        public BurgerDbContext()
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        //olvasni
        //https://www.entityframeworktutorial.net/code-first/configure-many-to-many-relationship-in-code-first.aspx
    }
}
