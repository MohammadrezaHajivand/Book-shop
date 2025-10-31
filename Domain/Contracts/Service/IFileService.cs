
using Microsoft.AspNetCore.Http;

namespace BookStore.Domain.FileAgg
{
    public interface IFileService
    {
        public string Upload(IFormFile file, string folder);
        public void Delete(string fileName);
    }
}
