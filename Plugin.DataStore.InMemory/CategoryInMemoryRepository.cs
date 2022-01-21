using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.DataStorePluginInterfaces;

namespace Plugin.DataStore.InMemory
{
    public class CategoryInMemoryRepository : ICategoryRepository
    {
        private List<Category> _categories;
        public CategoryInMemoryRepository()
        {
            _categories = new List<Category>() 
            { 
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
            };
        }
        public IEnumerable<Category> GetCategories()
        {
            throw new NotImplementedException();
        }
    }
}
