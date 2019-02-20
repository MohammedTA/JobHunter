using System;
using System.Collections.Generic;
using System.Text;

namespace JobHunter.Data.Entities
{
    public class ResumeCountry
    {

        public int ResumeId { get; set; }
        public virtual Resume Resume { get; set; }

        public int CountryId { get; set; }
        public virtual Country Country { get; set; }
    }
}
