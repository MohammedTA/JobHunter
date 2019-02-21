using JobHunter.Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JobHunter.Presentation.ViewModels
{
    public class ContactsViewModel
    {
        [Required(ErrorMessage = "Password is required")]
        [MaxLength(5, ErrorMessage ="You can input only 5 phone numbers")]
        [MinLength(1, ErrorMessage ="You must input at least 1 phone number")]
        public PhoneNumber[] phones { get; set; }


        public string viber { get; set; }
        public string telegram { get; set; }
        public string skype { get; set; }
        public string whats_up { get; set; }
    }
}