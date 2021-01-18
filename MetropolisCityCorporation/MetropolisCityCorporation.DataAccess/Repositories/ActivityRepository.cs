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

        public void Add(Activity itemEntity)
        {
            _dbContext.Activities.Add(itemEntity);
            _dbContext.SaveChanges();
        }

        public bool Delete(int id)
        {
           Activity item = _dbContext.Activities.Where(e => e.Id == id).FirstOrDefault();
            if (item != null)
            {
                _dbContext.Remove(item);
                _dbContext.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<Activity> GetItems()
        {
            return _dbContext.Activities.ToList();
        }

        public List<Activity> GetAllItems()
        {
            return _dbContext.Activities.ToList();
        }
        public Activity Update(Activity itemChange, int id)
        {
            Activity item = _dbContext.Activities.Where(x => x.Id == id).FirstOrDefault();
            if (item != null)
            {
                item.Name = itemChange.Name;
                item.Type = itemChange.Type;
                item.Description = itemChange.Description;
                item.Date = itemChange.Date;
                _dbContext.SaveChanges();

            }
            return item;
        }

        public List<Activity> GetAllActivities()
        {
            throw new NotImplementedException();
        }

        public List<Activity> GetActivities()
        {
            throw new NotImplementedException();
        }
    }
}
