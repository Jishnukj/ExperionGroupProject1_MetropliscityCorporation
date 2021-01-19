using MetropolisCityCorporation.BusinessService;
using MetropolisCityCorporation.BusinessService.Dtos;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetropolisCityCorporation.Controllers
{
    [ApiController]
    [Route("activities")]
    public class ActivityController : ControllerBase
    {
        private readonly IActivityService _activitiesService;
        public ActivityController(IActivityService activitiesService)
        {
            _activitiesService = activitiesService;
        }

        [Route("activities")]
        [HttpGet]
        public IEnumerable<ActivityDto> GetAllItems()
        {

            return _activitiesService.GetAllItems();
        }

        [Route("activities")]
        [HttpPost]
        public void AddActivity(Activity activity)
        {
            _activitiesService.AddActivity(activity);
        }

        [Route("activities/{id}")]
        [HttpDelete]
        public void DeleteActivity(int id)
        {
            _activitiesService.Delete(id);
        }






    }
}