using GroceryShopApp.Models.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace GroceryShopApp.Database.DatabaseContext
{
    public class GroceryShopDb : DbContext 
    {
        public DbSet<Brand> Brands { get; set; }
        public DbSet<BrandPhoto> BrandPhotos { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<CategoryPhoto> CategoryPhotos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Brand>().HasIndex(b => b.Name).IsUnique();
            modelBuilder.Entity<Category>().HasIndex(c => c.Name).IsUnique();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = @"Data Source = DESKTOP-HHA0TOP; 
                                    Initial Catalog = GroceryShopDB; 
                                    Integrated Security = SSPI;";
            optionsBuilder.UseSqlServer(connectionString);
            optionsBuilder.EnableSensitiveDataLogging();
        }
    }
}
