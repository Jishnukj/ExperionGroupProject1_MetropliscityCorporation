using MetroPolisDataService.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetroPolisDataService.Repo
{
    public interface IStreetRepo
    {
        List<Street> GetAllStreets();
        Street GetStreet(int id);
    }
}
