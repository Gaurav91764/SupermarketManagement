using CoreBusiness;
using UserCases.DataStorePluginInterfaces;

namespace Plugins.DataStore.InMemory
{
    public class CategoryInMemoryRepository : ICategoryRepository
    {
        private List<Category> categories;

        public CategoryInMemoryRepository()
        {
            categories = new List<Category>()
            {
                new Category() { Name = "Beverage", CategoryId = 1 , Description = "Beverage"},
                new Category() { Name = "Bekary", CategoryId = 2 , Description = "Bekary"},
                new Category() { Name = "Vegetables", CategoryId = 3 , Description = "Vegetables"}
            };
        }
        public IEnumerable<Category> GetCategories()
        {
            return categories;
        }
    }
}
