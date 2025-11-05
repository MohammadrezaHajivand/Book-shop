using Domain.Entities;

namespace Domain.Contracts.Repositroy
{
    public interface IUserRepository
    {
        void Add(User user);
        List<User> GetAll();
        User GetById(int id);
        void Update(User user);
        void Delete(int id);
        int Save();
    }
}
