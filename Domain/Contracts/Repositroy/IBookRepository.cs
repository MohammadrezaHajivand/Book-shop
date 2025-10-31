

using BookStore.Domain.Dto;

namespace BookStore.Domain.Contracts.Repository;

public interface IBookRepository
{
    int Create(CreateBookDto createBookDto);
    List<GetBookDto> GetRecentlyBooks(int count);
    List<GetBookDto> GetBooks();
    void Delete(int bookId);
    GetBookDto? GetBookById(int id);

}