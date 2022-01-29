﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Plugin.DataStore.SQL;

namespace Plugin.DataStore.SQL.Migrations
{
    [DbContext(typeof(MarketContext))]
    [Migration("20220129094755_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CoreBusiness.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            Description = "Beverage",
                            Name = "Beverage"
                        },
                        new
                        {
                            CategoryId = 2,
                            Description = "Food",
                            Name = "Food"
                        },
                        new
                        {
                            CategoryId = 3,
                            Description = "Cosmetics",
                            Name = "Cosmetics"
                        });
                });

            modelBuilder.Entity("CoreBusiness.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CategoryId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("Price")
                        .IsRequired()
                        .HasColumnType("float");

                    b.Property<int?>("Quantity")
                        .IsRequired()
                        .HasColumnType("int");

                    b.HasKey("ProductId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            CategoryId = 1,
                            Name = "Ice Tea",
                            Price = 3.0,
                            Quantity = 100
                        },
                        new
                        {
                            ProductId = 2,
                            CategoryId = 1,
                            Name = "Beer",
                            Price = 7.0,
                            Quantity = 150
                        },
                        new
                        {
                            ProductId = 3,
                            CategoryId = 2,
                            Name = "Bread",
                            Price = 2.5,
                            Quantity = 90
                        },
                        new
                        {
                            ProductId = 4,
                            CategoryId = 2,
                            Name = "Donut",
                            Price = 5.0,
                            Quantity = 30
                        },
                        new
                        {
                            ProductId = 5,
                            CategoryId = 3,
                            Name = "Face cream",
                            Price = 12.5,
                            Quantity = 100
                        },
                        new
                        {
                            ProductId = 6,
                            CategoryId = 3,
                            Name = "Shampoo",
                            Price = 19.0,
                            Quantity = 40
                        },
                        new
                        {
                            ProductId = 7,
                            CategoryId = 1,
                            Name = "Coca Cola Zero",
                            Price = 4.5,
                            Quantity = 100
                        },
                        new
                        {
                            ProductId = 8,
                            CategoryId = 1,
                            Name = "Wine",
                            Price = 120.0,
                            Quantity = 100
                        });
                });

            modelBuilder.Entity("CoreBusiness.Transaction", b =>
                {
                    b.Property<int>("TransactionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BeforeQuantity")
                        .HasColumnType("int");

                    b.Property<string>("CashierName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<string>("ProductName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SoldQuantity")
                        .HasColumnType("int");

                    b.Property<DateTime>("TimeStamp")
                        .HasColumnType("datetime2");

                    b.HasKey("TransactionId");

                    b.ToTable("Transactions");
                });

            modelBuilder.Entity("CoreBusiness.Product", b =>
                {
                    b.HasOne("CoreBusiness.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("CoreBusiness.Category", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
