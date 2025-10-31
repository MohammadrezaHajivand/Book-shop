

using BookStore.Domain.Dto;

namespace BookStore.Domain.Contracts.Service;

public interface ICategoryService
{
    void Create(string name, string description);
    List<GetCategoryDto> GetPopularCategories(int count);
    List<GetCategoryDto> GetCategories();

}