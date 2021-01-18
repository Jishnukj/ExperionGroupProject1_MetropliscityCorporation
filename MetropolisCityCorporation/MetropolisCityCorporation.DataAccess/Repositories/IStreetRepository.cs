using MetropolisCityCorporation.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetropolisCityCorporation.DataAccess.Repositories
{
    public interface IStreetRepository
    {
        List<Street> GetAllStreets();
    }
}
