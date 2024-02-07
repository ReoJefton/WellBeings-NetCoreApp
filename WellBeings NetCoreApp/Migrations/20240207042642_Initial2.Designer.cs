﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WellBeings_NetCoreApp.Data;

namespace WellBeings_NetCoreApp.Migrations
{
    [DbContext(typeof(WellBeings_NetCoreAppContext))]
    [Migration("20240207042642_Initial2")]
    partial class Initial2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WellBeings_NetCoreApp.Models.ProductType", b =>
                {
                    b.Property<int>("ProductTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProductTypeId");

                    b.ToTable("ProductType");
                });

            modelBuilder.Entity("WellBeings_NetCoreApp.Models.Products", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.Property<int?>("ProductTypeId")
                        .HasColumnType("int");

                    b.Property<int>("TypeId")
                        .HasColumnType("int");

                    b.HasKey("ProductId");

                    b.HasIndex("ProductTypeId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            Description = "Description1",
                            Name = "Diesel 5lb",
                            Price = 89.99f,
                            TypeId = 1
                        },
                        new
                        {
                            ProductId = 2,
                            Description = "Description2",
                            Name = "Progressive Collagen 600g",
                            Price = 49.99f,
                            TypeId = 2
                        },
                        new
                        {
                            ProductId = 3,
                            Description = "Description3",
                            Name = "Progressive Multivitamin Active Men 216 Caps",
                            Price = 59.99f,
                            TypeId = 3
                        });
                });

            modelBuilder.Entity("WellBeings_NetCoreApp.Models.Products", b =>
                {
                    b.HasOne("WellBeings_NetCoreApp.Models.ProductType", "productType")
                        .WithMany("products")
                        .HasForeignKey("ProductTypeId");
                });
#pragma warning restore 612, 618
        }
    }
}
