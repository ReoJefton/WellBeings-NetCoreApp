using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WellBeings_NetCoreApp.Models;

namespace WellBeings_NetCoreApp.Data
{
    public class WellBeings_NetCoreAppContext : DbContext
    {
        public WellBeings_NetCoreAppContext (DbContextOptions<WellBeings_NetCoreAppContext> options)
            : base(options)
        {
        }

        //protected override void OnModelCreating(ModelBuilder builder)
        //{

        //    builder.Entity<Products>().HasData(
        //        new { ProductId = 1, TypeId = 1, Name = "Diesel 5lb", Price = 89.99, Description = "Description1" },
        //        new { ProductId = 2, TypeId = 2, Name = "Progressive Collagen 600g", Price = 49.99, Description = "Description2" },
        //        new { ProductId = 3, TypeId = 3, Name = "Progressive Multivitamin Active Men 216 Caps", Price = 59.99, Description = "Description3" });
        //}

        public DbSet<WellBeings_NetCoreApp.Models.Products> Products { get; set; }
        public DbSet<WellBeings_NetCoreApp.Models.ProductType> ProductType { get; set; }
    }
}
