using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace demo2.Models
{
    public class ActivityContext: DbContext
    {
        public ActivityContext(DbContextOptions<ActivityContext> options) : base(options)
        {
        }

        public DbSet<Activities> Activities { get; set; }
        public DbSet<Streets> Streets { get; set; }
        public DbSet<Users> Users { get; set; }
    }
}
