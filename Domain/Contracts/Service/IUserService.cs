using Domain.Dto;
using Domain.Entities;

namespace Domain.Contracts.Service
{
    public interface IUserService
    {
        List<GetUserDto> GetAllUsers();
        GetUserDto GetUserById(int id);
        int UpdateUser(GetUserDto user);
        bool DeleteUser(int id);
    }
}
