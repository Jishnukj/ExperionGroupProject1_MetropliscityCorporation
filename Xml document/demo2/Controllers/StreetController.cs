using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using demo2.service;

namespace demo2.Controllers
{
/// <summary>
/// The main Street Controller which contains
/// all the methods for the API endpoints 
/// related to Street data.
/// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class StreetController : ControllerBase
    {
        
        private IStreetdata _streetdata;
        /// <summary>
        /// Street Controller Constructor
        /// </summary>
        /// <param name="streetdata">streetdata object which
        /// inherits from IStreetdata interface</param>
        public StreetController(IStreetdata streetdata)
        {
            _streetdata = streetdata;
        }
        /// <summary>
        /// GetStreets Method for getting all Street details.
        /// </summary>
        /// <returns>All Street Details</returns>
        [HttpGet]
        [Route("api/[controller]")]
        public IActionResult GetStreets()
        {
            return Ok(_streetdata.GetStreets());
        }
        /// <summary>
        /// GetStreet Method for fetching details of a single activity based on id.
        /// </summary>
        /// <param name="id">Street id defined in street and activity entity</param>
        /// <returns>Street with id specified by user</returns>
        [HttpGet]
        [Route("api/[[controller]]/[[id]]")]
        public IActionResult GetStreet(int id)
        {
            var street = _streetdata.GetStreet(id);

            if (street != null)
            {
                return Ok(street);
            }
            return NotFound($"Street with Id: {id} was not found");
        }
    }
}
