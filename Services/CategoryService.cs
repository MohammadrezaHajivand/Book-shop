

using BookStore.Domain.Contracts.Repository;
using BookStore.Domain.Contracts.Service;
using BookStore.Domain.Dto;

namespace Services
{
    public class CategoryService(ICategoryRepository categoryRepository): ICategoryService
    {
        public void Create(string name, string description)
        {
            categoryRepository.Create(name, description);
        }

        public List<GetCategoryDto> GetPopularCategories(int count)
        {
            return categoryRepository.GetPopularCategories(count);
        }
        public List<GetCategoryDto> GetCategories()
        {
            return categoryRepository.GetCategories();
        }
    }
}
