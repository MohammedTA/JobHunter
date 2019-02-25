﻿namespace JobHunter.Domain.Models.VacancyModels
{
    public class VacancyListModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Date { get; set; }
        public string CompanyLogo { get; set; }
        public  bool IsHot { get; set; }
        public bool IsVip { get; set; }
        public string VacancyCity { get; set; }
        public string CompanyTitle { get; set; }
        public decimal VacancyCost { get; set; }

    }
}
