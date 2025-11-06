using Domain.Dto;
using Domain.Entities;

namespace BookStore_MVC.Models
{
    public class ManageUserVm
    {
        public List<GetUserDto>? Users { get; set; }
    }
}
