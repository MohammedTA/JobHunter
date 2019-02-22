using System;
using System.Collections.Generic;
using System.Text;

namespace JobHunter.Data.Entities
{
    public class Status
    {
        public Status()
        {
            VacancyStatuses = new List<VacancyStatus>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<VacancyStatus> VacancyStatuses { get; set; }
    }
}
