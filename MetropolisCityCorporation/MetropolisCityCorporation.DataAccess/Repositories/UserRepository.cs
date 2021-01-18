using MetropolisCityCorporation.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MetropolisCityCorporation.DataAccess.Repositories
{
    public class UserRepository:IUserRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public UserRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public List<User> GetAllUsers()
        {
            return _dbContext.Users.ToList();
        }
    }
}
