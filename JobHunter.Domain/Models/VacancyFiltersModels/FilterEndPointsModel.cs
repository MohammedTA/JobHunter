using JobHunter.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobHunter.Domain.Models.VacancyFiltersModels
{
    public class FilterEndPointsModel
    {
        public List<string> Categories { get; set; }
        public List<string> Experience { get; set; }
        public int SalaryMinValue { get; set; } = 0;
        public decimal SalaryMaxValue { get; set; }
    }
}
