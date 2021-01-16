using System;
using System.Collections.Generic;
using System.Text;

namespace MetropolisCityCorporation.DataAccess.Entities
{
    public class Street
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public bool IsClosed { get; set; }
        public bool IsSingleLane { get; set; }

    }
}
