using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace demo2.Models
{
    /// <summary>
    /// The Users class
    /// containing all the Users details.
    /// </summary>
    public class Users
    {
        /// <value>Gets the Id</value>
        [Key]
        public Guid Id { get; set; }
        /// <value>Gets the Name</value>
        [Required]
        [MaxLength(50, ErrorMessage = "User Name should not be more than 50 characters long")]
        public string Name { get; set; }
        /// <value>Gets the Email</value>

        public string Email { get; set; }
    }
}
