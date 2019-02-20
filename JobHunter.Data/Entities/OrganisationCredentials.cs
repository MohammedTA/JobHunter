using System;
using System.Collections.Generic;
using System.Text;

namespace JobHunter.Data.Entities
{
    public class OrganisationCredentials
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public Byte Type { get; set; }
        public int EmployerId { get; set; }

        public virtual Employer Employer { get; set; }
    }
}
