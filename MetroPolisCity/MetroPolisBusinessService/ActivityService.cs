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
        public List<Activity> GetSorted()
        {
            var activities = _activityRepository.GetAllActivities();
         
            var sort = activities.OrderByDescending(s => s.IsStreetClosed).ThenBy(s => s.StreetName).ThenBy(d => d.Date);
            var datefilter1 = sort.Where(s => s.Date.Date >= DateTime.Now.Date);
            var datefilter = sort.Where(s => s.Date.Date <= DateTime.Now.Date.AddDays(5));
            return datefilter.ToList();

        }
        public ActivityDto GetActivity(int id)
        {
            var activity = _activityRepository.GetActivity(id);

            if (activity != null)
            {
                return new ActivityDto
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
            return null;

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
        public bool Update(Activity activityChange, int id)
        {
            var activity = _activityRepository.GetActivity(id);
            List<Activity> data = new List<Activity>();
            data = _activityRepository.GetAllActivities(); // fetch the entire database
            int count = data.Where(x => x.Date == activityChange.Date && activityChange.IsStreetClosed == true).Count();

            if(count==6 && activity.IsStreetClosed==false && activityChange.IsStreetClosed == true)
            {
                return false;
            }
            else
            {
                _activityRepository.Update(activityChange, id);
                return true;
            }

        }

        public bool Add(Activity New_data)
        {
            List<Activity> data = new List<Activity>();
            data = _activityRepository.GetAllActivities(); // fetch the entire database
            int name = 0;
            int Total = data.Where(x => x.Date == New_data.Date).Count();
            int count = data.Where(x => x.Date == New_data.Date && New_data.IsStreetClosed==true).Count();
            name = data.Where(x => x.Name == New_data.Name && x.Date == New_data.Date).Count();
            if (Total >= 15)
            {
                //total is greater than 15
                return false;
            }
            else if (count >= 6)
            {
                //Closed street count is greater than 6
                return false;
            }else if (name > 0)
            {
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
