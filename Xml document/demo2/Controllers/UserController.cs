using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using demo2.service;

namespace demo2.Controllers
{
    /// <summary>
    /// The main User Controller which contains 
    /// all the methods for the API endpoints related to User data
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        private IUserdata _userdata;
        /// <summary>
        /// User Controller Constructor
        /// </summary>
        /// <param name="userdata">userdata object which
        /// inherits from IUserdata interface</param>
        public UserController(IUserdata userdata)
        {
            _userdata = userdata;
        }
        /// <summary>
        /// GetUsers Method for getting all user details
        /// </summary>
        /// <returns>All user details</returns>
        [HttpGet]
        [Route("api/[controller]")]
        public IActionResult GetUsers()
        {
            return Ok(_userdata.GetUsers());
        }
        /// <summary>
        /// GetUser Method for fetching details of a single user based on id.
        /// </summary>
        /// <param name="id">Globally Unique User id defined in User Entity</param>
        /// <returns>User with id specified</returns>
        [HttpGet]
        [Route("api/[[controller]]/[[id]]")]
        public IActionResult GetUser(Guid id)
        {
            var user = _userdata.GetUser(id);

            if (User != null)
            {
                return Ok(user);
            }
            return NotFound($"User with Id: {id} was not found");
        }
    }
}
