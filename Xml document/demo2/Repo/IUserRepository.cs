using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using demo2.Models;

namespace demo2.Repo
{
    public interface IUserRepository
    {
        List<Users> GetAllUsers();
    }
}
