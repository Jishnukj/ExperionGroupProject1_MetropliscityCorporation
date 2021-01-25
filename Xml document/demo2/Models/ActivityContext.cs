using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace demo2.Models
{
    /// <summary>
    /// The ActivityContext class
    /// For database connectivity.
    /// </summary>
    public class ActivityContext: DbContext
    {
        /// <summary>
        /// Constructor for ActivityContext class
        /// </summary>
        /// <param name="options">options</param>
        public ActivityContext(DbContextOptions<ActivityContext> options) : base(options)
        {
        }
        /// <summary>
        /// Table for Activities
        /// </summary>
        public DbSet<Activities> Activities { get; set; }
        /// <summary>
        /// Table for Streets
        /// </summary>
        public DbSet<Streets> Streets { get; set; }
        /// <summary>
        /// Table for Users
        /// </summary>
        public DbSet<Users> Users { get; set; }
    }
}
