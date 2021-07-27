using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EvolnetHealth.Entities
{
    public class Contacts
    {
        
        public int Id { get; set; }
        [Required]
        [StringLength(60, MinimumLength = 3)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(60, MinimumLength = 3)]
        public string LastName { get; set; }
        public String Status { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.PhoneNumber)]
        [Phone]
        public string PhoneNumbers { get; set; }

        

    }
}
