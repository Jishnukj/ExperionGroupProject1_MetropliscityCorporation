using MetropolisCityCorporation.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetropolisCityCorporation.DataAccess
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Activity> Activities { get; set; }
        public DbSet<Street> Streets { get; set; }
        public DbSet<User> Users { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "Host=localhost;Database=MetropolisDb;Username=postgres;Password=Parvathy@123";
            optionsBuilder.UseNpgsql(connectionString);

        }
    }
}

