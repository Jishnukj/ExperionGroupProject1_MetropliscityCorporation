using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace demo2.Models
{
    public class Users
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        [MaxLength(50, ErrorMessage = "User Name should not be more than 50 characters long")]
        public string Name { get; set; }

        public string Email { get; set; }
    }
}
