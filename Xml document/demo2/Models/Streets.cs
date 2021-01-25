using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace demo2.Models
{
    /// <summary>
    /// The Streets class
    /// containing all the Streets details.
    /// </summary>
    public class Streets
    {
        /// <value>Gets the Id</value>
        [Key]
        public int Id { get; set; }
        /// <value>Gets the Name</value>
        [Required]
        public string Name { get; set; }
        /// <value>Gets the Location</value>
        [Required]
        public string Location { get; set; }
        /// <value>Gets the Isclosed</value>
        [Required]
        public bool IsClosed { get; set; }
        /// <value>Gets the IsSingleLane</value>
        [Required]
        public bool IsSingleLane { get; set; }
    }
}
