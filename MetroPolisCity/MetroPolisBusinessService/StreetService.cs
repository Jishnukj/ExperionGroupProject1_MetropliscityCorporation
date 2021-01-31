using MetroPolisDataService.Entities;
using MetroPolisDataService.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MetroPolisBusinessService
{
    public class StreetService:IStreetService
    {
        private readonly IStreetRepo _streetRepository;

        public StreetService(IStreetRepo streetRepository)
        {
            _streetRepository = streetRepository;
        }
        public List<Street> GetStreets()
        {
            List<Street> streets = new List<Street>();
            streets = _streetRepository.GetAllStreets();
            return streets.ToList();
        }
        public Street GetStreet(int id)
        {
            Street street=_streetRepository.GetStreet(id);
            return street;
        }
    }
}
