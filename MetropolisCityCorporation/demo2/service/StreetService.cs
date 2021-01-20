using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using demo2.Repo;
using demo2.Models;
using demo2.service;

namespace demo2.service
{
    public class SqlStreets : IStreetdata
    {
        private ActivityContext _activityContext;
        public SqlStreets(ActivityContext activityContext)
        {
            _activityContext = activityContext;
        }
        public Streets GetStreet(int id)
        {
            var street = _activityContext.Streets.Find(id);
            return street;
        }

        public List<Streets> GetStreets()
        {
            return _activityContext.Streets.ToList();
        }
    }
}
