namespace Domain.Contracts.Service
{
    public interface IBookImgService
    {
        void Create(string imgUrl, bool isMainImg, int bookId);
    }
}
