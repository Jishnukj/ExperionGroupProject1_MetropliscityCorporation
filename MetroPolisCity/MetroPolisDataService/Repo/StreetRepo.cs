using MetroPolisDataService.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MetroPolisDataService.Repo
{
    class StreetRepo:IStreetRepo
    {
        private readonly ApplicationDbContext _dbContext;
        public StreetRepo(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Street> GetAllStreets()
        {
            return _dbContext.Streets.ToList();
        }
        public Street GetStreet(int id)
        {
            Street street = _dbContext.Streets.Where(e => e.Id == id).FirstOrDefault();
            return street;
        }
    }
}
