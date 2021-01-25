using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using demo2.Repo;
using demo2.Models;

namespace demo2.service
{   /// <summary>
    /// Interface for street.
    /// </summary>
    public interface IStreetdata
    {
        /// <summary>
        /// fetching list of streets
        /// </summary>
        /// <returns>returns list of streets</returns>
        List<Models.Streets> GetStreets();
        /// <param name="id">id</param>
        /// <returns>return street of id</returns>
        Models.Streets GetStreet(int id);
    }
}
