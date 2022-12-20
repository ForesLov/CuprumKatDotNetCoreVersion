using CuprumKatDotNetCore.Modeles;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuprumKatDotNetCore.Database
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext()
        {
            Database.EnsureCreated();
        }
        public DbSet<User> Users => Set<User>();

        public DbSet<CompanyPose> CompanyPoses => Set<CompanyPose>();
        public DbSet<EDelivery> eDeliveries=> Set<EDelivery>();
        public DbSet<Manufacturer> Manufacturers => Set<Manufacturer>();
        public DbSet<ProductWriteOff> ProductWriteOffs=> Set<ProductWriteOff>();
        public DbSet<Product> Products => Set<Product>();
        public DbSet<Storehouse> Storehouses => Set<Storehouse>();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=CuprumKat.db");
        }
    }
}
