using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using demo2.Repo;
using demo2.Models;
using demo2.service.Dto;

namespace demo2.service
{
    public class SqlActivity : IActivitydata
    {
        private readonly IActivityRepository _activityRepository;

        private ActivityContext _activityContext;
        public SqlActivity(ActivityContext activityContext)
        {
            _activityContext = activityContext;
        }
        public List<Activities> Activity => throw new NotImplementedException();

        public Activities AddActivity(Activities activity)
        {
            List<Activities> data = new List<Activities>();
            data = _activityRepository.GetActivities(); // fetch the entire database
            int Total = data.Where(x => x.Date == activity.Date).Count();
           

            if (Total < 15)
            {
                _activityRepository.Add(activity);
                foreach (var Element in data)
                {
                    if (Element.Name == activity.Name && Element.Date == activity.Date)
                    {
                        _activityRepository.Add(activity);
                        break;
                        // " with same name already exist for the date";
                    }

                    

                }
            }
            throw new NotImplementedException();
        }

        public void DeleteActivity(Activities activity)
        {
            throw new NotImplementedException();
        }

        public Activities EditActivity(Activities activity)
        {
            throw new NotImplementedException();
        }

        public object GetActivities()
        {
            return _activityContext.Activities.ToList();
        }

        public Activities GetActivity(Guid id)
        {
            var activity = _activityContext.Activities.Find(id);
            return activity;
        }


        // newpart
        public IEnumerable<ActivityDto> GetAllActivities()
        {

            var products = _activityRepository.GetAllActivities();

            return products.Select(p => new ActivityDto
            {
                Name = p.Name,
                Date = p.Date,
                Id = p.Id,
         
                Type = p.Type,



            });
        }

        

    }
}
