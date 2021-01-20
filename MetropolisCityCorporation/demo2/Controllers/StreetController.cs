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
    public class StreetController : ControllerBase
    {
        private IStreetdata _streetdata;

        public StreetController(IStreetdata streetdata)
        {
            _streetdata = streetdata;
        }
        [HttpGet]
        [Route("api/[controller]")]
        public IActionResult GetStreets()
        {
            return Ok(_streetdata.GetStreets());
        }

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
