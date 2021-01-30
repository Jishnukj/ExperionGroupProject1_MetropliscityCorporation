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
    public class StreetController : ControllerBase
    {
        private IStreetService _streetService;

        public StreetController(IStreetService streetService)
        {
            _streetService = streetService;
        }
        [HttpGet]
        [Route("api/[controller]")]
        public IActionResult GetStreets()
        {
            return Ok(_streetService.GetStreets());
        }

        [HttpGet]
        [Route("api/[[controller]]/[[id]]")]
        public IActionResult GetStreet(int id)
        {
            var street = _streetService.GetStreet(id);

            if (street != null)
            {
                return Ok(street);
            }
            return NotFound($"Street with Id: {id} was not found");
        }
    }
}
