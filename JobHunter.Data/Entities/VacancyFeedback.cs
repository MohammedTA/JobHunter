using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace JobHunter.Data.Entities
{
    public class VacancyFeedback
    {
        public VacancyFeedback()
        {
            VacancyCommentRates = new List<VacancyCommentRate>();
            VacancyFeedbacks = new List<VacancyFeedback>();
        }

        public int Id { get; set; }
        public string Descritpion { get; set; }
        public int VacancyId { get; set; }
        public int UserId { get; set; }
        public string Screenshot { get; set; }

       
        public int? ParentVacancyFeedbacksd { get; set; }
        public virtual VacancyFeedback ParentVacancyFeedback { get; set; }
        public virtual ICollection<VacancyFeedback> VacancyFeedbacks { get; set; }



        public virtual User User { get; set; }
        public virtual Vacancy Vacancy { get; set; }
        public virtual ICollection<VacancyCommentRate> VacancyCommentRates { get; set; }
    }
}
