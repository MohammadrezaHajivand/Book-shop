

namespace Domain.Contracts.Repositroy
{
    public interface IBookImgRepository
    {
        void Create(string imgUrl, bool isMainImg, int bookId);
    }
}
