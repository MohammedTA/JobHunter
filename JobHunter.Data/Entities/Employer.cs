using System;
using System.Collections.Generic;
using System.Text;

namespace JobHunter.Data.Entities
{
    public class Employer
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string Site { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        public string LogoURL { get; set; }
        public int? CityId { get; set; }

        public virtual City City {get;set;}

    }
}
