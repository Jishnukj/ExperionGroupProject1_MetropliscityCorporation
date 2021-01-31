using MetroPolisDataService.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetroPolisDataService.Repo
{
    public interface IUserRepo
    {
        List<User> GetAllUsers();
        User GetUser(int id);
    }
}
