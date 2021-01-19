using MetropolisCityCorporation.BusinessService;
using MetropolisCityCorporation.BusinessService.Dtos;
using MetropolisCityCorporation.DataAccess.Entities;
using MetropolisCityCorporation.DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BakedInHeaven.BusinessService
{
    public class ActivityService : IActivityService
    {
        private readonly IActivityRepository _activityRepository;

        public ActivityService(IActivityRepository activityRepository)
        {
            _activityRepository = activityRepository;
        }



        public IEnumerable<ActivityDto> GetAllProducts()
        {

            var products = _activityRepository.GetAllActivities();

            return products.Select(p => new ActivityDto
            {
                Name = p.Name,
                Date = p.Date,
                Id = p.Id,
                IsStreetClosed = p.IsStreetClosed,
                Type = p.Type,
                
               
               
            });
        }

        public void Delete(int id)
        {
            _activityRepository.Delete(id);
        }
        public void Update(Activity activityChange, int id)
        {
            _activityRepository.Update(activityChange, id);

        }

        public void AddActivity(Activity New_data)
        {
            List<Activity> data = new List<Activity>();
            data = _activityRepository.GetActivities(); // fetch the entire database
            int Total = data.Where(x => x.Date == New_data.Date).Count();
            int flag = 0;
            int count = 0;

            if (Total < 15)
            {
                foreach (var Element in data)
                {
                    if (Element.Name == New_data.Name && Element.Date == New_data.Date)
                    {
                        break;
                        // " with same name already exist for the date";
                    }

                    else { flag = 1; }

                }
            }
            if (flag == 1)
            {

                if (New_data.IsStreetClosed == true)
                {
                    foreach (var Element in data)
                    {
                        if (Element.Date == New_data.Date)
                        {
                            if (Element.IsStreetClosed == true)
                            {
                                count++;
                            }
                        }

                    }
                    if (count < 4)
                    {

                    }


                }
                else
                {
                    _activityRepository.Add(New_data);
                }
            }
        }

        public List<ActivityDto> GetActivities()
        {
            throw new NotImplementedException();
        }

        public void Add(Activity newActivity)
        {
            throw new NotImplementedException();
        }
    }
}
