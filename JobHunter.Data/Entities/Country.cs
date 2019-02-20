using System;
using System.Collections.Generic;
using System.Text;

namespace JobHunter.Data.Entities
{
    public class Country
    {
        public Country()
        {
            Cities = new List<City>();
            ResumeCountries = new List<ResumeCountry>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        
        public virtual ICollection<City> Cities { get; set; }
        public virtual ICollection<ResumeCountry> ResumeCountries { get; set; }


    }
}
