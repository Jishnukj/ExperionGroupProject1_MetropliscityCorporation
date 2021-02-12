using MetroPolisDataService.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetroPolisBusinessService
{
    public interface IUserService
    {
        List<User> GetUsers();
        User GetUser(int id);
    }
}
