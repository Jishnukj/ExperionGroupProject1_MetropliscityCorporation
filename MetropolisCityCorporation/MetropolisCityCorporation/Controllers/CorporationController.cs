using MetropolisCityCorporation.BusinessService;
using MetropolisCityCorporation.BusinessService.Dtos;
using MetropolisCityCorporation.DataAccess.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetropolisCityCorporation.Controllers
{
    [ApiController]
    [Route("api/Corporation")]
    public class CorporationController:ControllerBase
    {
        private readonly IActivityService _activityService;
        private readonly IUserService _userService;
        private readonly IStreetService _streetService;
        public CorporationController(IActivityService activityService, IUserService userService, IStreetService streetService)
        {
            _activityService = activityService;
            _userService = userService;
            _streetService = streetService;
        }

        [HttpGet]
        public IEnumerable<ActivityDto> GetAllItems()
        {

            return _activityService.GetActivities();
        }

        [HttpPost]
        public void Add(Activity item)
        {
            _activityService.Add(item);
        }

        [HttpDelete("{Id}")]
        public void Delete(int Id)
        {
            _activityService.Delete(Id);
        }

        [HttpPut("{Id}")]
        public void Update(Activity item, int Id)
        {
            _activityService.Update(item, Id);
        }




    }
}
