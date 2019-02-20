using System;
using System.Collections.Generic;
using System.Text;

namespace JobHunter.Data.Entities
{
    public class VacancyComplaint
    {
        public int Id { get; set; }
        public int? VacancyId { get; set; }
        public int UserId { get; set; }

        public virtual User User { get; set; }
        public virtual Vacancy Vacancy { get; set; }

    }
}
