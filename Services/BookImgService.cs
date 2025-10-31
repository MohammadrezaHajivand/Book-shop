using Domain.Contracts.Repositroy;
using Domain.Contracts.Service;
using Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class BookImgService(IBookImgRepository bookImgRepository) : IBookImgService
    {
        public void Create(string imgUrl, bool isMainImg, int bookId)
        {
            bookImgRepository.Create(imgUrl, isMainImg, bookId);
        }
    }
}
