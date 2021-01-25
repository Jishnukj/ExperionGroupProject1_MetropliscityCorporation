using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using demo2.Models;

namespace demo2.Repo
{
    /// <summary>
    /// Creating an Interface
    /// </summary>
    public interface IActivityRepository
    {
        /// <summary>
        /// Get a list of Activities
        /// </summary>
        List<Activities> GetAllActivities();
        /// <summary>
        /// Add a list of Activities
        /// </summary>
        void Add(Activities itemEntity);
        /// <summary>
        /// Update a list of Activities
        /// </summary>
        Activities Update(Activities itemChange, int id);
        /// <summary>
        /// Delete a list of Activities by Id
        /// </summary>
        bool Delete(int id);
        /// <summary>
        /// Get the list of Activities after edits
        /// </summary>
        List<Activities> GetActivities();

    }
}
