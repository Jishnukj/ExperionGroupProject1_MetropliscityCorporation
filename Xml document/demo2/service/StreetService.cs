using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using demo2.Repo;
using demo2.Models;
using demo2.service;

namespace demo2.service
{   
    /// <summary>
    /// Street Class
    /// </summary>
    public class SqlStreets : IStreetdata
    {   
        /// <summary>
        /// Create Object
        /// </summary>
        private ActivityContext _activityContext;
        /// <summary>
        /// Contructor for Activity context class
        /// </summary>
        /// <param name="activityContext">activityContext</param>
        public SqlStreets(ActivityContext activityContext)
        {
            _activityContext = activityContext;
        }
        /// <summary>
        /// Get the street by Id
        /// </summary>
        /// <param name="id">id</param>
        /// <returns>returns street</returns>
        public Streets GetStreet(int id)
        {
            var street = _activityContext.Streets.Find(id);
            return street;
        }
        /// <summary>
        /// Get the list of streets
        /// </summary>
        /// <returns>returns list of street </returns>
        public List<Streets> GetStreets()
        {
            return _activityContext.Streets.ToList();
        }
    }
}
