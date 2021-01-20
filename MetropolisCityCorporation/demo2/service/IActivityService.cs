using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using demo2.Repo;
using demo2.Models;
using demo2.service.Dto;

namespace demo2.service
{
    public interface IActivitydata
    {
        List<Models.Activities> Activity { get; }

        Models.Activities GetActivity(Guid id);

        Models.Activities AddActivity(Models.Activities activity);

        void DeleteActivity(Models.Activities activity);

        Models.Activities EditActivity(Models.Activities activity);
        object GetActivities();
    }

}
