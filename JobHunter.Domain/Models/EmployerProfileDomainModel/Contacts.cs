using System;
using System.Collections.Generic;
using System.Text;

namespace JobHunter.Domain.Models.EmployerProfileDomainModel
{
   public class Contacts
    {
        public List<string> Telephone { get; set; }
        public string Viber { get; set; }
        public string Telegram { get; set; }
        public string Whatsapp { get; set; }
        public string Email { get; set; }
    }
}
