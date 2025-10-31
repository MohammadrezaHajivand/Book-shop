

using BookStore.Domain.Contracts.Repository;
using BookStore.Domain.Dto;
using Domain.Entities;
using Infrastructure.Persistence;
using System;

namespace Infrastructure.Repositories
{
    public class CategoryRepository(AppDbContext context) : ICategoryRepository
    {
        public void Create(string name, string description)
        {
            var category = new Category()
            {
                Name = name,
                Description = description
            };
            context.Add(category);
            context.SaveChanges();
        }

        public List<GetCategoryDto> GetPopularCategories(int count)
        {
            return context.Categories
                .OrderByDescending(c => c.Books.Count)
                .Take(count)
                .Select(c => new GetCategoryDto
                {
                    Id = c.Id,
                    Name = c.Name,
                    ImgUrl = c.ImgUrl,
                    Description = c.Description
                })
                .ToList();
        }
        public List<GetCategoryDto> GetCategories()
        {
            return context.Categories
                .OrderByDescending(c => c.Books.Count)
                .Select(c => new GetCategoryDto
                {
                    Id = c.Id,
                    Name = c.Name,
                    ImgUrl = c.ImgUrl,
                    Description = c.Description
                })
                .ToList();
        }


    }
}
