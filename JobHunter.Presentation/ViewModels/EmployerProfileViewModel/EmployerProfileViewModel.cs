using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobHunter.Presentation.ViewModels.EmployerPfofileViewModel
{
    public class EmployerProfileViewModel
    {
        public int ID { get; set; }
        public string CompanyName { get; set; }
        public Contacts Contact { get; set; }
        public IContactPerson ContactPerson { get; set; }
        public IEmployerType EmployerType { get; set; }
        public string Logo { get; set; }

        public string Site { get; set; }
        public string Country { get; set; }
        public string Town { get; set; }
        public string Adress { get; set; }
        public string Description { get; set; }
        public string Password { get; set; }
        public string INN { get; set; }
        public string EGRPOU { get; set; }

    }
}
