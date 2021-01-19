using MetropolisCityCorporation.DataAccess.Entities;
using MetropolisCityCorporation.DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MetropolisCityCorporation.BusinessService
{
    public class StreetService : IStreetService
    {
        private readonly StreetRepository _streetRepository;

        public StreetService(StreetRepository streetRepository)
        {
            _streetRepository = streetRepository;
        }
        public List<Street> GetUsers()
        {
            List<Street> orders = new List<Street>();
            orders = _streetRepository.GetAllStreets();
            return orders.ToList();



        }
    }
}