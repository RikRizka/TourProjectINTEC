﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProductCatalog.Data;

#nullable disable

namespace ProductCatalog.Migrations
{
    [DbContext(typeof(ProductDbContext))]
    [Migration("20240531095744_Add Db")]
    partial class AddDb
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ProductCatalog.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            Name = "Kids Book"
                        },
                        new
                        {
                            CategoryId = 2,
                            Name = "Food"
                        },
                        new
                        {
                            CategoryId = 3,
                            Name = "Comik"
                        },
                        new
                        {
                            CategoryId = 4,
                            Name = "Adult Book"
                        });
                });

            modelBuilder.Entity("ProductCatalog.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductId"));

                    b.Property<int?>("BindingType")
                        .HasColumnType("int");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<bool?>("IsAvailable")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsBestSeller")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsNewRelease")
                        .HasColumnType("bit");

                    b.Property<decimal>("Price")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ProductId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            CategoryId = 3,
                            Price = 10.1m,
                            ProductName = "Binggo"
                        },
                        new
                        {
                            ProductId = 2,
                            CategoryId = 2,
                            Price = 3.5m,
                            ProductName = "Cimochi"
                        },
                        new
                        {
                            ProductId = 3,
                            CategoryId = 4,
                            Price = 2.19m,
                            ProductName = "Loulou"
                        },
                        new
                        {
                            ProductId = 5,
                            CategoryId = 4,
                            Price = 6.1m,
                            ProductName = "Coucou"
                        },
                        new
                        {
                            ProductId = 6,
                            CategoryId = 3,
                            Price = 6.1m,
                            ProductName = "Desparcito"
                        },
                        new
                        {
                            ProductId = 7,
                            CategoryId = 4,
                            Price = 6.1m,
                            ProductName = "Belachelijk"
                        },
                        new
                        {
                            ProductId = 8,
                            CategoryId = 1,
                            Price = 6.1m,
                            ProductName = "Marsupilami"
                        },
                        new
                        {
                            ProductId = 9,
                            CategoryId = 2,
                            Price = 6.1m,
                            ProductName = "NumNum"
                        },
                        new
                        {
                            ProductId = 10,
                            CategoryId = 1,
                            Price = 6.1m,
                            ProductName = "Tom&Jery"
                        });
                });

            modelBuilder.Entity("ProductCatalog.Models.Product", b =>
                {
                    b.HasOne("ProductCatalog.Models.Category", "Category")
                        .WithMany("Producten")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("ProductCatalog.Models.Category", b =>
                {
                    b.Navigation("Producten");
                });
#pragma warning restore 612, 618
        }
    }
}
