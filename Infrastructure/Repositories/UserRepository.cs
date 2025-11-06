using Domain.Contracts.Repositroy;
using Domain.Entities;
using Infrastructure.Persistence;


namespace Infrastructure.Repositories
{
    public class UserRepository(AppDbContext context) : IUserRepository
    {
        public void Add(User user)
        {
            context.Users.Add(user);
        }

        public void Delete(int id)
        {
            var user = context.Users.FirstOrDefault(u => u.Id == id);
            if (user != null)
            {
                context.Users.Remove(user);
            }
        }

        public List<User> GetAll()
        {
            return context.Users.ToList()!;
        }

        public User GetById(int id)
        {
            return context.Users.FirstOrDefault(u => u.Id == id)!;
        }
        public void Update(User user)
        {
            context.Users.Update(user);
        }

        public int Save()
        {
            return context.SaveChanges();
        }

    }
}
