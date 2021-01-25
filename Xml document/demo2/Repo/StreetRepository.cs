using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using demo2.Models;

namespace demo2.Repo
{
    /// <summary>
    /// Street Class
    /// </summary>
    public class StreetRepository : IStreetRepository
    {
        /// <summary>
        /// Create a readonly Object
        /// </summary>
        private readonly ActivityContext _dbContext;
        /// <summary>
        /// Constructor for Activity Context Class
        /// </summary>
        /// <param name="dbContext">dbContext</param>
        public StreetRepository(ActivityContext dbContext)
        {
            _dbContext = dbContext;
        }

        /// <summary>
        /// Get list of Streets
        /// </summary>
        /// <returns>returns list of Streets</returns>
        public List<Streets> GetAllStreets()
        {
            return _dbContext.Streets.ToList();
        }
    }
}
