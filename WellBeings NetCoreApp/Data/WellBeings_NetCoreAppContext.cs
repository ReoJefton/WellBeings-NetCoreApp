using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WellBeings_NetCoreApp.Models;

namespace WellBeings_NetCoreApp.Data
{
    public class WellBeings_NetCoreAppContext : DbContext
    {
        public WellBeings_NetCoreAppContext(DbContextOptions<WellBeings_NetCoreAppContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {

            builder.Entity<Products>().HasData(
                new { ProductId = 1, TypeId = 1, Name = "Diesel 5lb", Price = 89.99F, Description = "Description1" },
                new { ProductId = 2, TypeId = 2, Name = "Progressive Collagen 600g", Price = 49.99F, Description = "Description2" },
                new { ProductId = 3, TypeId = 3, Name = "Progressive Multivitamin Active Men 216 Caps", Price = 59.99F, Description = "Description3" });
        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);
        //    new DbInitializer(modelBuilder).Seed();
        //}

        public DbSet<WellBeings_NetCoreApp.Models.Products> Products { get; set; }
        public DbSet<WellBeings_NetCoreApp.Models.ProductType> ProductType { get; set; }
    }

    //public class DbInitializer
    //{
    //    private readonly ModelBuilder modelBuilder;

    //    public DbInitializer(ModelBuilder modelBuilder)
    //    {
    //        this.modelBuilder = modelBuilder;
    //    }

    //    public void Seed()
    //    {
    //        modelBuilder.Entity<Products>().HasData(
    //            new { ProductId = 1, TypeId = 1, Name = "Diesel 5lb", Price = 89.99F, Description = "Description1" },
    //            new { ProductId = 2, TypeId = 2, Name = "Progressive Collagen 600g", Price = 49.99F, Description = "Description2" },
    //            new { ProductId = 3, TypeId = 3, Name = "Progressive Multivitamin Active Men 216 Caps", Price = 59.99F, Description = "Description3" }
    //        );
    //    }

    //    public static void Initialize(WellBeings_NetCoreAppContext context)
    //    {
    //        context.Database.EnsureCreated();

    //        if (context.Products.Any())
    //        {
    //            return;
    //        }
    //        var products = new Products[]
    //                { new Products{ ProductId = 1, TypeId = 1, Name = "Diesel 5lb", Price = 89.99F, Description = "Description1" },
    //                new Products{ ProductId = 2, TypeId = 2, Name = "Progressive Collagen 600g", Price = 49.99F, Description = "Description2" },
    //                new Products{ ProductId = 3, TypeId = 3, Name = "Progressive Multivitamin Active Men 216 Caps", Price = 59.99F, Description = "Description3" }
    //                };

    //        foreach (Products b in products)
    //        {
    //            context.Products.Add(b);
    //        }
    //        context.SaveChanges();

    //    }
    //}
}
