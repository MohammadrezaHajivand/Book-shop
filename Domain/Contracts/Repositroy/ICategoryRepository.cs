using BookStore.Domain.Dto;


namespace BookStore.Domain.Contracts.Repository;

public interface ICategoryRepository
{
    void Create(string name, string description);
    List<GetCategoryDto> GetPopularCategories(int count);
    List<GetCategoryDto> GetCategories();
}