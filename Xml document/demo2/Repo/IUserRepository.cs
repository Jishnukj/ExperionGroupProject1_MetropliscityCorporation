using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using demo2.Models;

namespace demo2.Repo
{
    /// <summary>
    /// User Interface
    /// </summary>
    public interface IUserRepository
    {
        /// <summary>
        /// Get a list of Users
        /// </summary>
       
        List<Users> GetAllUsers();
    }
}
