using MetropolisCityCorporation.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetropolisCityCorporation.DataAccess.Repositories
{
    public interface IUserRepository
    {
        List<User> GetAllUsers();
    }
}
