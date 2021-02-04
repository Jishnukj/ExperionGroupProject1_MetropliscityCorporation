using MetroPolisDataService.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MetroPolisDataService.Repo
{
    public class UserRepo:IUserRepo
    {
        private readonly ApplicationDbContext _dbContext;
        public UserRepo(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public  List<User>  GetAllUsers()
        {
            return  _dbContext.Users.ToList();
        }
        public User GetUser(int id)
        {
            User user = _dbContext.Users.Where(e => e.UserId == id).FirstOrDefault();
            return user;
        }
    }
}
