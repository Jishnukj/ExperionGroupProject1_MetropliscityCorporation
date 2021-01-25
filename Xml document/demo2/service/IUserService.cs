using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using demo2.Repo;
using demo2.Models;

namespace demo2.service
{
    /// <summary>
    /// Interface for Users
    /// </summary>
    public interface IUserdata
    {
        /// <summary>
        /// Fetching list of users
        /// </summary>
        /// <returns>return the list of users</returns>
        List<Models.Users> GetUsers();
        /// <param name="id">id</param>
        /// <returns>return user by id</returns>
        Models.Users GetUser(Guid id);
    }
}
