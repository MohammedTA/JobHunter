using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobHunter.Data.Entities
{
    public class User : IdentityUser<int>
    {
        public User()
        {
            VacancyComplaints = new List<VacancyComplaint>();
            VacancyCommentRates = new List<VacancyCommentRate>();
            CompanyRates = new List<CompanyRate>();
            VacancyFeedbacks = new List<VacancyFeedback>();
        }

        public int? ProfileId { get; set; }

        public virtual Profile Profile {get;set;}
        public virtual ICollection<VacancyComplaint> VacancyComplaints { get; set; }
        public virtual ICollection<VacancyCommentRate> VacancyCommentRates { get; set; }
        public virtual ICollection<CompanyRate> CompanyRates { get; set; }
        public virtual ICollection<VacancyFeedback> VacancyFeedbacks { get; set; }
    }
}
