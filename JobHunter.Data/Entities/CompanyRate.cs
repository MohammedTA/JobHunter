using System;
using System.Collections.Generic;
using System.Text;

namespace JobHunter.Data.Entities
{
    public class CompanyRate
    {
        public int Id { get; set; }
        public int Rate { get; set; }
        public int UserId { get; set; }
        public int EmployerId { get; set; }

        public virtual Employer Employer { get; set; }
        public virtual User User { get; set; }
    }
}
