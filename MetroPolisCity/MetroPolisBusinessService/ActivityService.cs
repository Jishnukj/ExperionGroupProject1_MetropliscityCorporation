using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MetroPolisBusinessService.Dto;
using MetroPolisDataService;
using MetroPolisDataService.Entities;
using MetroPolisDataService.Repo;

namespace MetroPolisBusinessService
{
    public class ActivityService: IActivityService
    {
        private readonly IActivityRepo _activityRepository;

        public ActivityService(IActivityRepo activityRepository)
        {
            _activityRepository = activityRepository;
        }



        public List<ActivityDto> GetActivities()
        {

            var activities = _activityRepository.GetAllActivities();

            return activities.Select(a => new ActivityDto
            {
                
                Id=a.Id,
                Name=a.Name,
                StreetId=a.StreetId,
                StreetName=a.StreetName,
                IsStreetClosed=a.IsStreetClosed,
                Type=a.Type,
                Date=a.Date,
                Description=a.Description


            }).ToList();
        }
        public ActivityDto GetActivity(int id)
        {
            var activity = _activityRepository.GetActivity(id);
            return  new ActivityDto
            {
                Id = activity.Id,
                Name = activity.Name,
                StreetId = activity.StreetId,
                StreetName = activity.StreetName,
                IsStreetClosed = activity.IsStreetClosed,
                Type = activity.Type,
                Date = activity.Date,
                Description = activity.Description
            };

        }

        public bool Delete(int id)
        {
            var activity = _activityRepository.GetActivity(id);
            if (activity != null)
            {
                _activityRepository.Delete(id);
                return true;
            }
            else
            {
                return false;
            }
        }
        public Activity Update(Activity activityChange, int id)
        {
            var activity = _activityRepository.GetActivity(id);
            List<Activity> data = new List<Activity>();
            data = _activityRepository.GetAllActivities(); // fetch the entire database
            int count = data.Where(x => x.Date == activityChange.Date && activityChange.IsStreetClosed == true).Count();

            if(count==6 && activity.IsStreetClosed==false && activityChange.IsStreetClosed == true)
            {
                throw new InvalidOperationException("Closed street count is greater than 6");
            }
            else
            {
                _activityRepository.Update(activityChange, id);
                return activityChange;
            }

        }

        public bool Add(Activity New_data)
        {
            List<Activity> data = new List<Activity>();
            data = _activityRepository.GetAllActivities(); // fetch the entire database
            int Total = data.Where(x => x.Date == New_data.Date).Count();
            int count = data.Where(x => x.Date == New_data.Date && New_data.IsStreetClosed==true).Count();

            if (Total >= 15)
            {
                //total is greater than 15
                return false;
            }
            else if (count >= 6)
            {
                //Closed street count is greater than 6
                return false;
            }
            else
            {
                _activityRepository.Add(New_data);
                return true;
            }
        }

       
        
    }
}
