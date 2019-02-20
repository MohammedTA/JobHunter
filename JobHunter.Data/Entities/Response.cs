using System;
using System.Collections.Generic;
using System.Text;

namespace JobHunter.Data.Entities
{
    public class Response
    {
        public int Id { get; set; }
        public Boolean IsActive { get; set; }
        public int? VacancyId { get; set; }
        public int? ResumeId { get; set; }
        public DateTime AddDate { get; set; }

        public virtual Vacancy Vacancy { get; set; }
        public virtual Resume Resume { get; set; }

    }
}
