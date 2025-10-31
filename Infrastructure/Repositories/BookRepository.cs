using BookStore.Domain.Contracts.Repository;
using BookStore.Domain.Dto;
using Domain.Entities;
using Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class BookRepository(AppDbContext context) : IBookRepository
    {
        public int Create(CreateBookDto createBookDto)
        {
            var book = new Book()
            {
                Name = createBookDto.Name,
                AuthorName = createBookDto.AuthorName,
                CategoryId = createBookDto.CategoryId,
                Price = createBookDto.Price,
                PageCount = createBookDto.PageCount
            };
            context.Add(book);
            context.SaveChanges();
            return book.Id;
        }

        public List<GetBookDto> GetRecentlyBooks(int count)
        {
            return context.Books
                .OrderByDescending(b => b.CreatedAt)
                .Take(count)
                .Include(b => b.BookImgs)
                .Select(b => new GetBookDto()
                {
                    Id = b.Id,
                    AuthorName = b.AuthorName,
                    BookName = b.Name,
                    img = b.BookImgs.FirstOrDefault(b => b.IsMainImg),
                    PageCount = b.PageCount,
                    Price = b.Price
                }).ToList();
        }
        public List<GetBookDto> GetBooks()
        {
            return context.Books
                .OrderByDescending(b => b.CreatedAt)
                .Include(b => b.BookImgs)
                .Select(b => new GetBookDto()
                {
                    Id = b.Id,
                    AuthorName = b.AuthorName,
                    BookName = b.Name,
                    img = b.BookImgs.FirstOrDefault(b => b.IsMainImg),
                    PageCount = b.PageCount,
                    Price = b.Price
                }).ToList();
        }

        public void Delete(int bookId)
        {
            context.Books.Where(b => b.Id == bookId).ExecuteDelete();
            context.SaveChanges();
        }

        public GetBookDto? GetBookById(int id)
        {
            return context.Books.Where(b => b.Id == id).Select(b => new GetBookDto()
            {
                Id = b.Id,
                CategoryId = b.CategoryId,
                img = b.BookImgs.FirstOrDefault(i => i.IsMainImg)!,
                PageCount = b.PageCount,
                Price = b.Price,
                AuthorName = b.AuthorName,
                BookName = b.Name

            }).FirstOrDefault();
        }
    }
}
