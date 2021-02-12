using MetroPolisBusinessService;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetroPolisCity.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IUserService _userservice;

        public UserController(IUserService userService)
        {
            _userservice = userService;
        }
        [HttpGet]
        [Route("api/[controller]")]
        public IActionResult GetUsers()
        {
            return Ok(_userservice.GetUsers());
        }

        [HttpGet]
        [Route("api/[[controller]]/[[id]]")]
        public IActionResult GetUser(int id)
        {
            var user = _userservice.GetUser(id);

            if (User != null)
            {
                return Ok(user);
            }
            return NotFound($"User with Id: {id} was not found");
        }
    }
}
