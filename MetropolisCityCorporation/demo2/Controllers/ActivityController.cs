using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using demo2.service;

namespace demo2.Controllers
{
    [ApiController]
    public class ActivitesController : ControllerBase
    {
        private IActivitydata _activitydata;

        public ActivitesController(IActivitydata activitydata)
        {
            _activitydata = activitydata;
        }
        [HttpGet]
        [Route("api/[[controller]]")]
        public IActionResult GetActivities()
        {
            return Ok(_activitydata.GetActivities());
        }

        [HttpGet]
        [Route("api/[[controller]]/[[id]]")]
        public IActionResult GetActivity(Guid id)
        {
            var activity = _activitydata.GetActivity(id);

            if (activity != null)
            {
                return Ok(activity);
            }
            return NotFound($"Activity with Id: {id} was not found");
        }

        [HttpPost]
        [Route("api/[[controller]]/[[id]]")]
        public IActionResult GetActivity(Models.Activities activity)
        {
            _activitydata.AddActivity(activity);

            return Created(HttpContext.Request.Scheme + "://" + HttpContext.Request.Host + HttpContext.Request.Path + "/" +
                activity.Id, activity);
        }

        [HttpDelete]
        [Route("api/[[controller]]/[[id]]")]
        public IActionResult DeleteActivity(Guid id)
        {
            var activity = _activitydata.GetActivity(id);

            if (activity != null)
            {
                _activitydata.DeleteActivity(activity);
                return Ok();
            }
            return NotFound($"Activity with Id: {id} was not found");
        }

        [HttpPatch]
        [Route("api/[[controller]]/[[id]]")]
        public IActionResult EditActivity(Guid id, Models.Activities activity)
        {
            var existingactivity = _activitydata.GetActivity(id);

            if (activity != null)
            {
                activity.Id = existingactivity.Id;
                _activitydata.EditActivity(activity);
            }
            return Ok(activity);
        }
    }
}
