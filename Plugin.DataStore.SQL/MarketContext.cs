using System;
using CoreBusiness;
using Microsoft.EntityFrameworkCore;

namespace Plugin.DataStore.SQL
{
    public class MarketContext : DbContext
    {
        public MarketContext(DbContextOptions options):base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Transaction> Transactions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
                .HasMany(c => c.Products)
                .WithOne(p => p.Category)
                .HasForeignKey(p => p.CategoryId);

            //seeding some data
            modelBuilder.Entity<Category>()
                .HasData(
                    new Category
                        {
                            CategoryId = 1,
                            Name = "Beverage",
                            Description = "Beverage"
                        },
                    new Category
                    {
                        CategoryId = 2,
                        Name = "Food",
                        Description = "Food"
                    },
                    new Category
                    {
                        CategoryId = 3,
                        Name = "Cosmetics",
                        Description = "Cosmetics"
                    }
                );
            modelBuilder.Entity<Product>()
                .HasData(
                    new Product
                    {
                        ProductId = 1,
                        CategoryId = 1,
                        Name = "Ice Tea",
                        Quantity = 100,
                        Price = 3.00
                    },
                    new Product
                    {
                        ProductId = 2,
                        CategoryId = 1,
                        Name = "Beer",
                        Quantity = 150,
                        Price = 7.00
                    },
                    new Product
                    {
                        ProductId = 3,
                        CategoryId = 2,
                        Name = "Bread",
                        Quantity = 90,
                        Price = 2.50
                    },
                    new Product
                    {
                        ProductId = 4,
                        CategoryId = 2,
                        Name = "Donut",
                        Quantity = 30,
                        Price = 5.00
                    },
                    new Product
                    {
                        ProductId = 5,
                        CategoryId = 3,
                        Name = "Face cream",
                        Quantity = 100,
                        Price = 12.50
                    },
                    new Product
                    {
                        ProductId = 6,
                        CategoryId = 3,
                        Name = "Shampoo",
                        Quantity = 40,
                        Price = 19.00
                    },
                    new Product
                    {
                        ProductId = 7,
                        CategoryId = 1,
                        Name = "Coca Cola Zero",
                        Quantity = 100,
                        Price = 4.50
                    },
                    new Product
                    {
                        ProductId = 8,
                        CategoryId = 1,
                        Name = "Wine",
                        Quantity = 100,
                        Price = 120.00
                    }
                );
        }
    }
}
