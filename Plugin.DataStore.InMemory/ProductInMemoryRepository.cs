using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.DataStorePluginInterfaces;

namespace Plugin.DataStore.InMemory
{
    public class ProductInMemoryRepository : IProductRepository
    {
        private List<Product> products;
        public ProductInMemoryRepository()
        {
            //Init with default values 
            products = new List<Product>() 
            { 
                new Product
                {
                    ProductId = 1,
                    CategoryId = 1,
                    Name = "Ice Tea",
                    Quantity = 100,
                    Price = 3.99
                },
                new Product
                {
                    ProductId = 2,
                    CategoryId = 1,
                    Name = "Beer",
                    Quantity = 150,
                    Price = 7.99
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
                    Price = 12.30
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
                    Price = 4.5
                },
                new Product
                {
                    ProductId = 8,
                    CategoryId = 1,
                    Name = "Wine",
                    Quantity = 100,
                    Price = 124.99
                }
            };
        }
        public IEnumerable<Product> GetProducts()
        {
            return products;
        }
    }
}
