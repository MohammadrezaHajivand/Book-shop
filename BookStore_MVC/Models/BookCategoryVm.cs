using BookStore.Domain.Dto;

namespace BookStore_MVC.Models
{
    public class BookCategoryVm
    {
        public List<GetBookDto> Books { get; set; }
        public List<GetCategoryDto> Categories { get; set; }
    }
}
