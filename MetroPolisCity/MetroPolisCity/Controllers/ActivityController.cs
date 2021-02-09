﻿using MetroPolisBusinessService;
using MetroPolisDataService.Entities;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetroPolisCity.Controllers
{
    [ApiController]

    public class ActivitesController : ControllerBase
    {
        private IActivityService _activityservice;

        public ActivitesController(IActivityService activityService)
        {
            _activityservice = activityService;
        }
        [HttpGet]
        [Route("api/[[controller]]")]
       
        public IActionResult GetActivities()
        {
            return Ok(_activityservice.GetActivities());
        }

        [HttpGet]
        [Route("api/[[controller]]/[[id]]")]
        public IActionResult GetActivity(int id)
        {
            var activity = _activityservice.GetActivity(id);

            if (activity != null)
            {
                return Ok(activity);
            }
            return NotFound($"Activity with Id: {id} was not found");
        }

        [HttpPost]
        [Route("api/[[controller]]/[[id]]")]
        

        public bool AddActivity(Activity activity)
        {
            var p=_activityservice.Add(activity);
            return p;
           // return Created(HttpContext.Request.Scheme + "://" + HttpContext.Request.Host + HttpContext.Request.Path + "/" +
            //    activity.Id, activity);
        }

        [HttpDelete]
        [Route("api/[[controller]]/[[id]]")]
        public IActionResult DeleteActivity(int id)
        {
            var activity = _activityservice.GetActivity(id);

            if (activity != null)
            {
                _activityservice.Delete(id);
                return Ok();
            }
            return NotFound($"Activity with Id: {id} was not found");
        }

        [HttpPatch]
        [Route("api/[[controller]]/[[id]]")]
        public IActionResult EditActivity(Activity activity,int id)
        {
            var existingactivity = _activityservice.GetActivity(id);

            if (activity != null)
            {
                activity.Id = existingactivity.Id;
                _activityservice.Update(activity,id);
            }
            return Ok(activity);
        }
    }
}
