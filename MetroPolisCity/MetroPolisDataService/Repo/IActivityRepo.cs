using MetroPolisDataService.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetroPolisDataService.Repo
{
    public interface IActivityRepo
    {
        List<Activity> GetAllActivities();
        Activity GetActivity(int id);
        bool Add(Activity itemEntity);
        Activity Update(Activity itemChange, int id);
        bool Delete(int id);
        
    }
}
