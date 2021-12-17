using CoreBusiness;
using UserCases.DataStorePluginInterfaces;

namespace UserCases
{
    public class ViewCategoriesUserCase
    {
        private readonly ICategoryRepository categoryRepository;

        public ViewCategoriesUserCase(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }
        public IEnumerable<Category> Execute()
        {
            return categoryRepository.GetCategories();
        }
    }
}
