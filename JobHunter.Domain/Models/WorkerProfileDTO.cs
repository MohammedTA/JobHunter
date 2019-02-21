using System;
using System.Collections.Generic;
using System.Text;

namespace JobHunter.Domain.Models
{
    public class WorkerProfileDTO
    {
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Middlename { get; set; }
        public string Password { get; set; }
        public string Confirm_password { get; set; }
        public virtual ContactsDTO Contacts { get; set; }
    }
}
