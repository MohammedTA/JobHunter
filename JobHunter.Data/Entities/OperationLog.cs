using System;
using System.Collections.Generic;
using System.Text;

namespace JobHunter.Data.Entities
{
    public class OperationLog
    {
        public int Id { get; set; }
        public int Type { get; set; }
        public string Comment { get; set; }
        public DateTime LogDate { get; set; }
        public int VacancyId { get; set; }
        //adminId

        public virtual Vacancy Vacancy { get; set; }
    }
}
