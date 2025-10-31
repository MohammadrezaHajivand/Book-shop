using BookStore.Domain.Dto;

namespace BookStore.Domain.Contracts.Service;

public interface IBookService
{
    void Create(CreateBookDto createBookDto);
    List<GetBookDto> GetRecentlyBooks(int count);
}