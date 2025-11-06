using Domain.Contracts.Repositroy;
using Domain.Contracts.Service;
using Domain.Dto;
using Domain.Entities;

namespace Services
{

    public class UserService(IUserRepository _userRepository) : IUserService
    {
        public List<GetUserDto> GetAllUsers()
        {
            var users = _userRepository.GetAll();
            return users.Select(u => new GetUserDto
            {
                Id = u.Id,
                Name = u.Name,
                Family = u.Family,
                Email = u.Email,
                Username = u.Username,
                Password = u.Password,
                Role = u.Role,
                CreatedAt = u.CreatedAt,
            }).ToList()!;
        }

        public GetUserDto GetUserById(int id)
        {

            var user = _userRepository.GetById(id);
            return new GetUserDto
            {
                Id = user.Id,
                Name = user.Name,
                Family = user.Family,
                Username = user.Username,
                Password = user.Password,
                Email = user.Email,
                Role = user.Role,
            };
        }

        public int UpdateUser(GetUserDto user)
        {
            var updatedUser = new User
            {
                Id = user.Id,
                Name = user.Name,
                Family = user.Family,
                Email = user.Email,
                Username = user.Username,
                Password = user.Password,
                Role = user.Role,
            };

            _userRepository.Update(updatedUser);


            return _userRepository.Save();
        }

        public bool DeleteUser(int id)
        {
            _userRepository.Delete(id);
            int rowsAffected = _userRepository.Save();
            return rowsAffected > 0;
        }


    }

}

