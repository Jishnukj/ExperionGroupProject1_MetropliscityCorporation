using MetroPolisDataService.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetroPolisBusinessService
{
    public interface IStreetService
    {
        List<Street> GetStreets();
        Street GetStreet(int id);
    }
}
