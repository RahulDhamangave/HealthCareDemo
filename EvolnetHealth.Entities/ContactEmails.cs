using System;
using System.Collections.Generic;
using System.Text;

namespace EvolnetHealth.Entities
{
    public class ContactEmails
    {
        public int Id { get; set; }
        public int? ContactId { get; set; }
        public string Email { get; set; }
        public bool IsPrimary { get; set; }
    }
}
