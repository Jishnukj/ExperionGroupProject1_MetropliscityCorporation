using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using demo2.Models;

namespace demo2.Repo
{
    /// <summary>
    /// User Class
    /// </summary>
    public class UserRepository : IUserRepository
    {
        /// <summary>
        /// Create a readonly Object
        /// </summary>
        private readonly ActivityContext _dbContext;
        /// <summary>
        /// Constructor for Activity Context Class
        /// </summary>
        /// <param name="dbContext">dbContext</param>
        public UserRepository(ActivityContext dbContext)
        {
            _dbContext = dbContext;
        }
        /// <summary>
        /// Get a list of Users
        /// </summary>
        /// <returns>returns list of users</returns>
        public List<Users> GetAllUsers()
        {
            return _dbContext.Users.ToList();
        }
    }
}
