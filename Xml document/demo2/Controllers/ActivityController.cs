using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using demo2.service;

namespace demo2.Controllers
{
 /// <summary>
 /// The main activities Controller Class
 /// which contains all the methods for the API endpoints 
 /// related to Activity Data.
 /// </summary>
    [ApiController]
    public class ActivitesController : ControllerBase
    {
        private IActivitydata _activitydata;

     /// <summary>
     /// Activities Controller constructor.
     /// </summary>
     /// <param name="activitydata">activitydata object which 
     /// inherits from IActivitydata interface</param>
        public ActivitesController(IActivitydata activitydata)
        {
            _activitydata = activitydata;
        }
    /// <summary>
    /// GetActivities Method for getting all activity details
    /// </summary>
    /// <returns>All activity details</returns>
        [HttpGet]
        [Route("api/[[controller]]")]
        public IActionResult GetActivities()
        {
            return Ok(_activitydata.GetActivities());
        }
    /// <summary>
    /// GetActivity Method for fetching details of a single activity based on ID
    /// </summary>
    /// <param name="id">Globally Unique ID defined in Activity Entity </param>
    /// <returns>Activity with ID specified by user</returns>
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
    /// <summary>
    /// AddActivity Method for adding activity details.
    /// </summary>
    /// <param name="activity">The activity object derived from Models.activities</param>
    /// <returns>The newly created object</returns>

        [HttpPost]
        [Route("api/[[controller]]/[[id]]")]
        public IActionResult AddActivity(Models.Activities activity)
        {
            _activitydata.AddActivity(activity);

            return Created(HttpContext.Request.Scheme + "://" + HttpContext.Request.Host + HttpContext.Request.Path + "/" +
                activity.Id, activity);
        }
    /// <summary>
    /// DeleteActivity Method for deleting activity details.
    /// </summary>
    /// <param name="id">Globally unique ID defined in Activity Entity</param>
    /// <returns>An empty object if object is found or
    /// else a string containing the error message</returns>
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
    /// <summary>
    /// Edit Activity Method for editing activity details.
    /// </summary>
    /// <param name="id">Globally Unique ID defined in Activity Entity</param>
    /// <param name="activity">The activity object derived 
    /// from Models.activities</param>
    /// <returns>The activity details which are edited</returns>
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
