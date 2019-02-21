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
        public double VacancyCost { get; set; }
        public Visa Visa { get; set; }
        public int CurrentPage { get; set; }

    }
}
