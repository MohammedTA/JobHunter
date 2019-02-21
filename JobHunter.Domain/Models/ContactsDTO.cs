using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JobHunter.Domain.Models
{
    public class ContactsDTO
    {
        public virtual List<PhoneNumberDTO> Phones { get; set; }
        public string Viber { get; set; }
        public string Telegram { get; set; }
        public string Skype { get; set; }
        public string Whats_up { get; set; }
    }
}