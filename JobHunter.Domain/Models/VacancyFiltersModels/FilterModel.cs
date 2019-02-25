using System.Collections.Generic;

namespace JobHunter.Domain.Models.VacancyFiltersModels
{
    public class FilterModel
    {
        public string Query { get; set; }
        public string City { get; set; }
        public Gender Gender { get; set; }
        public Language Language { get; set; }
        public string Experience { get; set; }
        public Accommodation Accommodation { get; set; }
        public decimal VacancyCost { get; set; }
        public Visa Visa { get; set; }
        public int CurrentPage { get; set; }
        public List <CategorySelected> Categories{ get; set; }

    }

    public class CategorySelected
    {
        public string CategoryName { get; set; }
        public bool IsSelected { get; set; }
    }
}
