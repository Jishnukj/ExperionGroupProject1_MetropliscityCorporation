using MetroPolisDataService.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MetroPolisDataService.Repo
{
    public class ActivityRepo : IActivityRepo
    {
        private readonly ApplicationDbContext _dbContext;
        public ActivityRepo(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public bool Add(Activity activityEntity)
        {
            _dbContext.Activities.Add(activityEntity);
            _dbContext.SaveChanges();
            return true;
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

        public Activity GetActivity(int id)
        {
            Activity activity = _dbContext.Activities.Where(e => e.Id == id).FirstOrDefault();
            return activity;
        }

        public List<Activity> GetAllActivities()
        {
            return _dbContext.Activities.ToList();
        }
        public bool Update(Activity activityChange, int id)
        {
            Activity activity = _dbContext.Activities.Where(x => x.Id == id).FirstOrDefault();
            if (activity != null)
            {
                activity.Name = activityChange.Name;
                activity.StreetId = activityChange.StreetId;
                activity.StreetName = activityChange.StreetName;
                activity.IsStreetClosed = activityChange.IsStreetClosed;
                activity.Type = activityChange.Type;
                activity.Description = activityChange.Description;
                activity.Date = activityChange.Date;
                _dbContext.SaveChanges();
                return true;

            }
            else
            {
                return false;
            }
        }
    }
}
