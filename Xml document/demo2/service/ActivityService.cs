using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using demo2.Repo;
using demo2.Models;
using demo2.service.Dto;

namespace demo2.service
{   
    ///<summary>
    ///The main class 
    ///</summary>
    ///<remarks>For adding,deleting ,editing and fetching activity</remarks>
    public class SqlActivity : IActivitydata
    {   
        /// <summary>
        /// Creating an object
        /// </summary>
        private readonly IActivityRepository _activityRepository;

        ///<summary>
        ///Creating an object
        ///</summary>
        private ActivityContext _activityContext;
        ///<summary>
        ///Constructor of SqlActivity class 
        ///</summary>
        /// ///<param name="activityContext">Setting Activity</param>
        public SqlActivity(ActivityContext activityContext)
        {
            _activityContext = activityContext;
        }

        ///<list>list of activities</list>
        ///<exception cref="NotImplementedException"></exception>
        public List<Activities> Activity => throw new NotImplementedException();

        ///<summary>
        ///Method for adding activity
        ///</summary>
        ///<param name="activity">Activity to add</param>
        ///<exception cref="NotImplementedException">Thrown when total greater than 15</exception>
        public Activities AddActivity(Activities activity)
        {
            List<Activities> data = new List<Activities>();
            ///<summary>
            /// fetch the entire database
            ///</summary>
            data = _activityRepository.GetActivities(); 
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
        ///<summary>
        ///Method for deleting activity
        ///</summary>
        ///<param name="activity">Activity to delete</param>
        /// <exception cref="NotImplementedException">Thrown when deletion fails</exception>
        public void DeleteActivity(Activities activity)
        {
            throw new NotImplementedException();
        }
        ///<summary>
        ///Method for editing activity
        ///</summary>
        /// <param name="activity">Activity to edit</param>
        /// <exception cref="NotImplementedException">Thrown when editing fails</exception>
        public Activities EditActivity(Activities activity)
        {
            throw new NotImplementedException();
        }
       /// <summary>
       /// Method to get all activities
       /// </summary>
       /// <returns>returns list of activities</returns>
        public object GetActivities()
        {
            return _activityContext.Activities.ToList();
        }
        ///<summary>
        ///Method for fetching activity by id
        ///</summary>
        ///<param name="id">id</param>
        ///<returns>returns activity </returns>
        public Activities GetActivity(Guid id)
        {
            var activity = _activityContext.Activities.Find(id);
            return activity;
        }


       
        ///<summary>
        ///Method for fetching all activities
        ///</summary>
        ///<returns>returns all activities </returns>
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
