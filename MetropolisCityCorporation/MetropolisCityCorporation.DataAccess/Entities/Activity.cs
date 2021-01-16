using System;
using System.Collections.Generic;
using System.Text;

namespace MetropolisCityCorporation.DataAccess.Entities
{
    public class Activity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public int StreetId { get; set; }
        public string StreetName { get; set; }



    }
}
