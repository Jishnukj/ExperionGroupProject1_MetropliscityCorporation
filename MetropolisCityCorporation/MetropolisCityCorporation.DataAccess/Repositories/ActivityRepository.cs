using MetropolisCityCorporation.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MetropolisCityCorporation.DataAccess.Repositories
{
    public class ActivityRepository: IActivityRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public ActivityRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Add(Activity activityEntity)
        {
            _dbContext.Activities.Add(activityEntity);
            _dbContext.SaveChanges();
        }

        public bool Delete(int id)
        {
           Activity activity = _dbContext.Activities.Where(e => e.Id == id).FirstOrDefault();
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

        public List<Activity> GetActivities()
        {
            return _dbContext.Activities.ToList();
        }

        public List<Activity> GetAllActivities()
        {
            return _dbContext.Activities.ToList();
        }
        public Activity Update(Activity activityChange, int id)
        {
            Activity activity = _dbContext.Activities.Where(x => x.Id == id).FirstOrDefault();
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
