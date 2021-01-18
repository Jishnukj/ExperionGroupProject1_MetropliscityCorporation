using MetropolisCityCorporation.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetropolisCityCorporation.BusinessService
{
    public interface IUserService
    {
        List<User> GetUsers();
    }
}
