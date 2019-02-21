using System;
using System.Collections.Generic;
using System.Text;

namespace JobHunter.Domain.Models.EmployerProfileDomainModel
{
    public class EmployerType
    {
        public bool directEmployer { get; set; }
        public bool intermediary { get; set; }
        public bool agency { get; set; }
    }
}
