using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetropolisCityCorporation.Controllers
{
    [ApiController]
    [Route("users")]
    public class UserController:ControllerBase
    {
        private readonly IUserService _usersService;

        public UserController(IUserService usersService)
        {
            _userService = usersService;
        }

        [HttpGet]
        public ActionResult GetAllUsers()
        {
            var users = _userService.GetUsers();
            return Ok(users);
        }
    }
}
    
