using Domain.Contracts.Repositroy;
using Domain.Entities;
using Domain.Enums;
using Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class AuthRepository(AppDbContext context) : IAuthRepository
    {
        public bool CreateUser(User newuser)
        {
            context.Add(newuser);
            context.SaveChanges();
            return true;
        }

        public User GetUserByUsername(string username)
        {
            return context.Users.FirstOrDefault(u => u.Username == username)!;
        }
    }
}
