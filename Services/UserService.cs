using Domain.Contracts.Repositroy;
using Domain.Contracts.Service;
using Domain.Entities;

namespace Services
{

    public class UserService(IUserRepository _userRepository) : IUserService
    {
        List<User> IUserService.GetAllUsers()
        {
            return _userRepository.GetAll();
        }

        public User GetUserById(int id)
        {

            return _userRepository.GetById(id);
        }

        public bool CreateUser(User user)
        {

            if (_userRepository.GetAll().Any(u => u.Username == user.Username))
            {

                return false;
            }

            _userRepository.Add(user);


            int rowsAffected = _userRepository.Save();
            return rowsAffected > 0;
        }

        public int UpdateUser(User user)
        {

            _userRepository.Update(user);


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

