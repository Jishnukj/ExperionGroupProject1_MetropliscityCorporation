using MetropolisCityCorporation.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MetropolisCityCorporation.DataAccess.Repositories
{
    public class StreetRepository: IStreetRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public StreetRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public List<Street> GetAllOrders()
        {
            return _dbContext.Streets.ToList();
        }

        public List<Street> GetAllStreets()
        {
            throw new NotImplementedException();
        }
    }
}
