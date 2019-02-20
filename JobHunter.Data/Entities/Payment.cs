using System;
using System.Collections.Generic;
using System.Text;

namespace JobHunter.Data.Entities
{
    public class Payment
    {
        public int Id { get; set; }
        public string Amount { get; set; }
        public string Destination { get; set; }
        public int EmployerId { get; set; }

        public virtual Employer Employer { get; set; }
    }
}
