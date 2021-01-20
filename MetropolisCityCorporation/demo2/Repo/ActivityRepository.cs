using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using demo2.Repo;
using demo2.service;
using demo2.Models;

namespace demo2.Repo
{
    public class ActivityRepository : IActivityRepository
    {
        private readonly ActivityContext _dbContext;
        public ActivityRepository(ActivityContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Add(Activities activityEntity)
        {
            _dbContext.Activities.Add(activityEntity);
            _dbContext.SaveChanges();
        }

        public bool Delete(int id)
        {
            Activities activity = _dbContext.Activities.Where(e => e.Id == id).FirstOrDefault();
            if (activity != null)
            {
                _dbContext.Remove(activity);
                _dbContext.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<Activities> GetActivities()
        {
            return _dbContext.Activities.ToList();
        }

        public List<Activities> GetAllActivities()
        {
            return _dbContext.Activities.ToList();
        }
        public Activities Update(Activities activityChange, int id)
        {
            Activities activity = _dbContext.Activities.Where(x => x.Id == id).FirstOrDefault();
            if (activity != null)
            {
                activity.Name = activityChange.Name;
                activity.Type = activityChange.Type;
                activity.Description = activityChange.Description;
                activity.Date = activityChange.Date;
                _dbContext.SaveChanges();

            }
            return activity;
        }
    }
}
