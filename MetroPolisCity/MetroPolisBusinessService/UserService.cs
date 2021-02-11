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
        public bool checkAdmin(User user)
        {
            User p= _userRepository.GetUserByName(user.UserName);
            if (p != null)
            {
                if(p.UserName==user.UserName && p.Password == user.Password)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }
    }
}
