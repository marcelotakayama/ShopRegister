﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ShopRegisterAPI.Models;

namespace ShopRegisterAPI.Migrations
{
    [DbContext(typeof(ProductDetailContext))]
    partial class ProductDetailContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("ShopRegisterAPI.Models.ProductDetail", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("ProductCode")
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("ProductName")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("ProductPrice")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("ProductRegisterDate")
                        .HasColumnType("nvarchar(5)");

                    b.HasKey("ProductId");

                    b.ToTable("ProductDetails");
                });
#pragma warning restore 612, 618
        }
    }
}