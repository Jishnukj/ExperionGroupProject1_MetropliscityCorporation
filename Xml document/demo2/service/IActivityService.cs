using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using demo2.Repo;
using demo2.Models;
using demo2.service.Dto;

namespace demo2.service
{   
    /// <summary>
    /// Interface for Activity
    /// </summary>
    public interface IActivitydata
    {   
        ///<summary>
        ///fetching list of activities
        ///</summary>
        List<Models.Activities> Activity { get; }

        /// <summary>
        /// calling GetActivity method
        /// </summary>
        /// <param name="id">id</param>
        /// <returns>returns id</returns>
        Models.Activities GetActivity(Guid id);
        /// <summary>
        /// calling AddActivity method
        /// </summary>
        /// <param name="activity">activity name</param>
        /// <returns>returns activity name</returns>
        Models.Activities AddActivity(Models.Activities activity);
        /// <summary>
        /// calling DeleteActivity method
        /// </summary>
        /// <param name="activity">activity name</param>
        void DeleteActivity(Models.Activities activity);
        /// <summary>
        /// calling EditActivity method
        /// </summary>
        /// <param name="activity">activity name</param>
        /// <returns>returns activity</returns>
        Models.Activities EditActivity(Models.Activities activity);
        /// <summary>
        /// calling GetActivities method 
        /// </summary>
        /// <returns>returns list of activities</returns>
        object GetActivities();
    }

}
