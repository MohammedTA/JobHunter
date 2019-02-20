using System;
using System.Collections.Generic;
using System.Text;

namespace JobHunter.Data.Entities
{
    public class Vacancy
    {

        public Vacancy()
        {
            Auctions = new List<Auction>();
            Responses = new List<Response>();
            VacancyComplaints = new List<VacancyComplaint>();
            VacancyFeedbacks = new List<VacancyFeedback>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int ViewCount { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public DateTime ExpirationStatusDate { get; set; }
        public decimal Salary { get; set; }
        public string Description { get; set; }
        public Byte Gender { get; set; }
        public string WorkExperience { get; set; }
        public string Accomodation { get; set; }
        public string Cost { get; set; }
        public Boolean Visa { get; set; }
        public string SalaryComment { get; set; }
        public Boolean AgreementSpam { get; set; }

        public int? LanguageId { get; set; }
        public virtual Language Language { get; set; }

        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }

        public int CityId { get; set; }
        public virtual City City { get; set; }

        public int EmployerId { get; set; }
        public virtual Employer Employer { get; set; }
        
        public int StatusId { get; set; }
        public virtual Status Status { get; set; }

        public int JobTypeId { get; set; }
        public virtual JobType JobType { get; set; }

        public int CurrencyId { get; set; }
        public virtual Currency Currency { get; set; }

        public virtual ICollection<Auction> Auctions { get; set; }
        public virtual ICollection<Response> Responses { get; set; }
        public virtual ICollection<VacancyComplaint> VacancyComplaints { get; set; }
        public virtual ICollection<VacancyFeedback> VacancyFeedbacks { get; set; }
        public virtual ICollection<OperationLog> OperationLogs { get; set; }
        
    }
}
