using System;
using System.Collections.Generic;
using System.Text;

namespace MetropolisCityCorporation.BusinessService.Dtos
{
     public class ActivityDto
    {
        public int Id { get; set; }
        public int StreetId { get; set; }

        public string Name { get; set; }
        public string StreetName { get; set; }

        public bool IsStreetClosed { get; set; }
        public string Type { get; set; }

        public string Description { get; set; }

        public DateTime Date { get; set; }

    }
}
