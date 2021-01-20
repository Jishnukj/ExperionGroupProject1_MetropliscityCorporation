using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using demo2.Repo;
using demo2.Models;

namespace demo2.service
{
    public class SqlUsers : IUserdata
    {
        private ActivityContext _activityContext;
        public SqlUsers(ActivityContext activityContext)
        {
            _activityContext = activityContext;
        }
        public Users GetUser(Guid id)
        {
            var user = _activityContext.Users.Find(id);
            return user;
        }

        public List<Users> GetUsers()
        {
            return _activityContext.Users.ToList(); ;
        }
    }
}
