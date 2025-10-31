using Domain.Contracts.Repositroy;
using Domain.Entities;
using Infrastructure.Persistence;

namespace Infrastructure.Repositories
{
    public class BookImgRepository(AppDbContext context) : IBookImgRepository
    {
        public void Create(string imgUrl, bool isMainImg, int bookId)
        {
            var img = new BookImg()
            {
                ImageUrl = imgUrl,
                IsMainImg = isMainImg,
                BookId = bookId
            };
            context.Add(img);
            context.SaveChanges();
        }
    }
}
