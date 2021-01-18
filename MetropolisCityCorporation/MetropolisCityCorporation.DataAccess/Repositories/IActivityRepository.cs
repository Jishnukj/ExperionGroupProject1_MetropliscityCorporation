using MetropolisCityCorporation.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetropolisCityCorporation.DataAccess.Repositories
{
    public interface IActivityRepository
    {
        List<Activity> GetAllActivities();
        void Add(Activity itemEntity);
        Activity Update(Activity itemChange, int id);
        bool Delete(int id);
        List<Activity> GetActivities();

    }
}
