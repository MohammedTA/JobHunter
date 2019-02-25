using System;
using System.Collections.Generic;
using System.Text;

namespace JobHunter.Domain.Models.VacancyFiltersModels
{
    public class FilterEndPointsModel
    {
        public string [] Experience { get; set; }
        public int SalaryMinValue { get; set; } = 0;
        public decimal SalaryMaxValue { get; set; }
    }
}
