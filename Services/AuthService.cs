using Domain.Contracts.Repositroy;
using Domain.Contracts.Service;
using Domain.Dto;
using Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Services
{
    public class AuthService(IAuthRepository context) : IAuthService
    {

        public void Register(RegisterDto registerDto)
        {

            var newuser = new User
            {
                Name = registerDto.Name,
                Family = registerDto.Family,
                Email = registerDto.Email,
                Username = registerDto.Username,
                Password = registerDto.Password,
            };
            context.CreateUser(newuser);
        }
        public User Login(LoginDto loginDto)
        {
            var user = context.GetUserByUsername(loginDto.Username);
            if (user != null&&user.Password==loginDto.Password) return user;
            return null!;
        }
    }
}
