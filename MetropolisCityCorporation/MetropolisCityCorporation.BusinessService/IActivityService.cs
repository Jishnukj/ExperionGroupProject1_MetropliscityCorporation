using MetropolisCityCorporation.BusinessService.Dtos;
using MetropolisCityCorporation.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetropolisCityCorporation.BusinessService
{
    public interface IActivityService
    {
        List<ActivityDto> GetActivities();
        void Add(Activity newActivity);
        void Update(Activity activityChange, int id);
        void Delete(int id);
    }
}
