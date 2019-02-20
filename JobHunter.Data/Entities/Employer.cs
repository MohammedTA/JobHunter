using System;
using System.Collections.Generic;
using System.Text;

namespace JobHunter.Data.Entities
{
    public class Employer
    {
        public Employer()
        {
            FavoriteResumes = new List<FavoriteResume>();
            Payments = new List<Payment>();
        }

        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string Site { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        public string LogoURL { get; set; }
        public int? CityId { get; set; }
        public int? OrganisationCredentialId { get; set; }

        public virtual OrganisationCredentials OrganisationCredentials { get; set; }
        public virtual City City {get;set;}
        public virtual ICollection<FavoriteResume> FavoriteResumes { get; set; }
        public virtual ICollection<Payment> Payments { get; set; }
    }
}
