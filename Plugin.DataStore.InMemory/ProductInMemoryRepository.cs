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

        public void AddProduct(Product product)
        {
            if(products.Any(x => x.Name.Equals(product.Name , StringComparison.OrdinalIgnoreCase)))
            {
                return;
            }
            if (products != null && products.Count > 0)
            {
                var maxId = products.Max(x => x.ProductId);
                product.ProductId = maxId + 1;
            }
            else
            {
                product.ProductId = 1;
            }
            products.Add(product);
        }

        public void DeleteProduct(int productId)
        {
            var productToDelete = GetProductById(productId);
            if(productToDelete != null)
            {
                products.Remove(productToDelete);
            }
        }

        public Product GetProductById(int productId)
        {
            return products.FirstOrDefault(x => x.ProductId == productId);
        }

        public IEnumerable<Product> GetProducts()
        {
            return products;
        }

        public IEnumerable<Product> GetProductsByCategoryId(int categoryId)
        {
            return products.Where(p => p.CategoryId == categoryId);
        }

        public void UpdateProduct(Product product)
        {
            var productToUpdate = GetProductById(product.ProductId);
            if (productToUpdate != null)
            {
                productToUpdate.Name = product.Name;
                productToUpdate.CategoryId = product.CategoryId;
                productToUpdate.Quantity = product.Quantity;
                productToUpdate.Price = product.Price;
            }
        }
    }
}
