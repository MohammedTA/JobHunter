using System;
using System.Collections.Generic;
using System.Text;

namespace JobHunter.Data.Entities
{
    public class VacancyCommentRate
    {
        public int Id { get; set; }
        public int Rate { get; set; }
        public int? VacancyFeedbackId { get; set; }
        public int UserId { get; set; }
        public Boolean? Like { get; set; }

        public virtual User User { get; set; }
        public virtual VacancyFeedback VacancyFeedback { get; set; }

    }
}
