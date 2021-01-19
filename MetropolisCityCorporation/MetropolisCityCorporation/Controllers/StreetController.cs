using MetropolisCityCorporation.BusinessService;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetropolisCityCorporation.Controllers
{
    public class StreetController:ControllerBase
    {
        [ApiController]
        [Route("streets")]
        public class StreetController : ControllerBase
        {
            private readonly IStreetService _streetsService;
            public StreetController(IStreetService streetsService)
            {
                _streetsService =streetsService;
            }

            [Route("streets")]
            [HttpGet]
            public IEnumerable<StreetDto> GetAllStreet()
            {

                return _streetsService.GetAllStreet();
            }

            [Route("streets")]
            [HttpPost]
            public void AddStreet(Street street)
            {
                _streetsService.AddStreet(street);
            }
        }
}
