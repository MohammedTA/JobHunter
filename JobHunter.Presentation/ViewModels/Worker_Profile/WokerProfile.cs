using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobHunter.Presentation.ViewModels
{
    public class WokerProfileViewModel
    {
        public string surname { get; set; }
        public string name { get; set; }
        public string middlename { get; set; }
        public string password { get; set; }
        public string confirm_password { get; set; }
        public ContactsViewModel contacts { get; set; }
    }
}
