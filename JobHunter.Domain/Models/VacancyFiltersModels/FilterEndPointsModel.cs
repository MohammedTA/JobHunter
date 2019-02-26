using System.Collections.Generic;

namespace JobHunter.Domain.Models.VacancyFiltersModels
{
    public class FilterEndPointsModel
    {
        public List <string> LanguageLevels { get; set; }
        public List<string> Categories { get; set; }
        public List<string> Experience { get; set; }
        public int SalaryMinValue { get; set; } = 0;
        public decimal SalaryMaxValue { get; set; }
    }
}
