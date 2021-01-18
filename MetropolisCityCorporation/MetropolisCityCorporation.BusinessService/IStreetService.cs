using MetropolisCityCorporation.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetropolisCityCorporation.BusinessService
{
     public interface IStreetService
    {
        List<Street> GetUsers();
    }
}
