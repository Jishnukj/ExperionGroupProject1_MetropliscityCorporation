using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using demo2.Models;

namespace demo2.Repo
{
    /// <summary>
    /// Street Interface
    /// </summary>
    public interface IStreetRepository
    {
        /// <summary>
        /// Get a list of Streets
        /// </summary>
        List<Streets> GetAllStreets();
    }
}
