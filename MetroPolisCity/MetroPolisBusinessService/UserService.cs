using MetroPolisDataService.Entities;
using MetroPolisDataService.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MetroPolisBusinessService
{
    public class UserService:IUserService
    {
        private readonly IUserRepo _userRepository;
        public UserService(IUserRepo userRepository)
        {
            _userRepository = userRepository;
        }
        public List<User> GetUsers()
        {
            List<User> users = new List<User>();
            users = _userRepository.GetAllUsers();
            return users.ToList();

        }
        public User GetUser(int id)
        {
            User user = _userRepository.GetUser(id);
            return user;
        }
    }
}
