using System;
using System.Collections.Generic;
using System.Text;

namespace JobHunter.Data.Entities
{
    public class Auction
    {
        public int Id { get; set; }
        public int VacancyId { get; set; }
        public int ShowCount { get; set; }
        public int Priority { get; set; }
        public Boolean IsActive { get; set; }

        public virtual Vacancy Vacancy { get; set; }
    }
}
