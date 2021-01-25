using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using demo2.Repo;
using demo2.Models;

namespace demo2.service
{  
    /// <summary>
    /// User Class
    /// </summary>
    public class SqlUsers : IUserdata
    {
        /// <summary>
        /// Create Object
        /// </summary>
        private ActivityContext _activityContext;
        /// <summary>
        /// Constructor for Ativity Context Class
        /// </summary>
        /// <param name="activityContext">activityContext</param>
        public SqlUsers(ActivityContext activityContext)
        {
            _activityContext = activityContext;
        }
        /// <summary>
        /// Get the User by Id
        /// </summary>
        /// <param name="id">id</param>
        /// <returns>returns user</returns>
        public Users GetUser(Guid id)
        {
            var user = _activityContext.Users.Find(id);
            return user;
        }
        /// <summary>
        /// Get list of Users
        /// </summary>
        /// <returns>returns list of users</returns>
        public List<Users> GetUsers()
        {
            return _activityContext.Users.ToList(); ;
        }
    }
}
