using System;
using System.Collections.Generic;
using System.Text;

namespace JobHunter.Data.Entities
{
    public class City
    {
        public City()
        {
            Vacancies = new List<Vacancy>();
            Employers = new List<Employer>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int CountryId { get; set; }

        public virtual Country Country { get; set; }
        public virtual ICollection<Vacancy> Vacancies { get; set; }
        public virtual ICollection<Employer> Employers { get; set; }
    }
}
