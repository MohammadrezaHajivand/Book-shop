using Domain.Entities;

namespace Domain.Contracts.Service
{
    public interface IUserService
    {
        List<User> GetAllUsers();
        User GetUserById(int id);
        bool CreateUser(User user);
        int UpdateUser(User user);
        bool DeleteUser(int id);
    }
}
