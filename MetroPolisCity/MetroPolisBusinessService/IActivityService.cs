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
        bool Add(Activity newActivity);
        Activity Update(Activity activityChange, int id);
        bool Delete(int id);
    }
}
