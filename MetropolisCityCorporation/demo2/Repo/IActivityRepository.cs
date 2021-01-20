using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using demo2.Models;

namespace demo2.Repo
{
    public interface IActivityRepository
    {
        List<Activities> GetAllActivities();
        void Add(Activities itemEntity);
        Activities Update(Activities itemChange, int id);
        bool Delete(int id);
        List<Activities> GetActivities();

    }
}
