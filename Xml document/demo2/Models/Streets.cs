using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace demo2.Models
{
    public class Streets
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Location { get; set; }
        [Required]
        public bool IsClosed { get; set; }
        [Required]
        public bool IsSingleLane { get; set; }
    }
}
