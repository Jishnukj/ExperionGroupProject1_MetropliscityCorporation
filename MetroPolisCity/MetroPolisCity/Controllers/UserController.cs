using MetroPolisBusinessService;
using MetroPolisDataService.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
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
        [HttpPost]
        [Route("api/[[controller]]")]


        public async Task<IActionResult> checkadmin(User user)
        {
            var p = _userservice.checkAdmin(user);
            if (p == true)
            {
                var tokenDescriptor = new SecurityTokenDescriptor
                {
                    Subject = new ClaimsIdentity(new Claim[]
                    {
                        new Claim("Username",user.UserName.ToString())
                    }),
                    Expires = DateTime.UtcNow.AddMinutes(60),
                    SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(
                        Encoding.UTF8.GetBytes("123433231324354343434")), SecurityAlgorithms.HmacSha256Signature)
                };
                var tokenHandler = new JwtSecurityTokenHandler();
                var securityToken = tokenHandler.CreateToken(tokenDescriptor);
                var token = tokenHandler.WriteToken(securityToken);
                return Ok(new { token });
            }
            else
            {
                return BadRequest(new { message = "invalid" });
            }
            
        }
    }
}
