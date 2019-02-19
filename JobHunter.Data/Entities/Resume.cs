using System;
using System.Collections.Generic;
using System.Text;

namespace JobHunter.Data.Entities
{
    public class Resume
    {
        public Resume()
        {
            ResumeCountries = new List<ResumeCountry>();
            Employers = new List<Employer>();
            Responses = new List<Response>();
        }

        public int Id { get; set; }
        public int Name { get; set; }
        public string Description { get; set; }
        public string Photo { get; set; }
        public string ResumeFile { get; set; }
        public string Video { get; set; }
        public Boolean AgreementSpam { get; set; }
        public int ProfileId { get; set; }

        public virtual Profile Profile { get; set; }
        public virtual ICollection<ResumeCountry> ResumeCountries { get; set; }
        public virtual ICollection<Employer> Employers { get; set; }
        public virtual ICollection<Response> Responses { get; set; }

    }
}
