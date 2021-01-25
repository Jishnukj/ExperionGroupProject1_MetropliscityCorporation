using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using demo2.Repo;
using demo2.service;
using demo2.Models;

namespace demo2.Repo
{
    /// <summary>
    /// Activity Class
    /// </summary>
    public class ActivityRepository : IActivityRepository
    {
        /// <summary>
        /// Creating an object
        /// </summary>
        private readonly ActivityContext _dbContext;
        /// <summary>
        /// Constructor for Activity Context Class
        /// </summary>
        /// <param name="dbContext">dbContext</param>
        public ActivityRepository(ActivityContext dbContext)
        {
            _dbContext = dbContext;
        }

        /// <summary>
        /// Method for Adding Activities.
        /// </summary>

        public void Add(Activities activityEntity)
        {
            _dbContext.Activities.Add(activityEntity);
            /// <summary>
            /// Saves all changes made in context file to the database
            /// </summary>
            _dbContext.SaveChanges();
        }

        /// <summary>
        /// Method for Deleting Activities.
        /// </summary>
        public bool Delete(int id)
        {
            /// <summary>
            /// returns and saves the activities that satisfies the condition by id
            /// </summary>
            Activities activity = _dbContext.Activities.Where(e => e.Id == id).FirstOrDefault(); /* Returns either the first element of a collection or the default value if index is out of range.*/
            
            /// <summary>
            /// checks to see if an activity exists
            /// </summary>
            if (activity != null)
            {
                /// <summary>
                /// Removes Activity
                /// </summary>
                _dbContext.Remove(activity);
                /// <summary>
                /// Saves all changes made in context file to the database
                /// </summary>
                /// /// <returns>returns true</returns>
                _dbContext.SaveChanges();
                return true;
            }
            /// <returns>returns false if no activity</returns>
            else
            {
                return false;
            }
        }
        /// <summary>
        /// Method for getting the list of Activities
        /// </summary>
        /// <returns>returns list of Activities</returns>
        public List<Activities> GetActivities()
        {
            return _dbContext.Activities.ToList();
        }
        /// <summary>
        /// Method for updating Activities.
        /// </summary>

        public Activities Update(Activities activityChange, int id)
        {
            /// <summary>
            /// returns and saves the activities that satisfies the condition by id
            /// </summary>
            Activities activity = _dbContext.Activities.Where(x => x.Id == id).FirstOrDefault();
            /// <summary>
            /// checks to see if an activity exists
            /// </summary>
            if (activity != null)
            {
                /// <summary>
                /// Updates to new name, type, Description and date and save the changes.
                /// </summary>
                activity.Name = activityChange.Name;
                activity.Type = activityChange.Type;
                activity.Description = activityChange.Description;
                activity.Date = activityChange.Date;
                _dbContext.SaveChanges();

            }
            /// <returns>returns the activities </returns>
            return activity;
        }
    }
}
