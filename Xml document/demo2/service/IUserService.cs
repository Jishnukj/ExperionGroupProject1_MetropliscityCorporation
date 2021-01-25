using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using demo2.Repo;
using demo2.Models;

namespace demo2.service
{
    public interface IUserdata
    {

        List<Models.Users> GetUsers();
        Models.Users GetUser(Guid id);
    }
}
