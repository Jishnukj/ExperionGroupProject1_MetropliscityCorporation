using MetroPolisBusinessService.Dto;
using MetroPolisDataService.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetroPolisBusinessService
{
    public interface IActivityService
    {
        List<ActivityDto> GetActivities();
        ActivityDto GetActivity(int id);
        void Add(Activity newActivity);
        void Update(Activity activityChange, int id);
        void Delete(int id);
    }
}
