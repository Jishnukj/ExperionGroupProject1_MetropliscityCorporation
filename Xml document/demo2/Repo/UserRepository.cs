using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using demo2.Models;

namespace demo2.Repo
{
    public class UserRepository : IUserRepository
    {
        private readonly ActivityContext _dbContext;
        public UserRepository(ActivityContext dbContext)
        {
            _dbContext = dbContext;
        }
        public List<Users> GetAllUsers()
        {
            return _dbContext.Users.ToList();
        }
    }
}
