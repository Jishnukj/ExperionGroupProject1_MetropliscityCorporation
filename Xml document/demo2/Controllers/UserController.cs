using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using demo2.service;

namespace demo2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IUserdata _userdata;

        public UserController(IUserdata userdata)
        {
            _userdata = userdata;
        }
        [HttpGet]
        [Route("api/[controller]")]
        public IActionResult GetUsers()
        {
            return Ok(_userdata.GetUsers());
        }

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
