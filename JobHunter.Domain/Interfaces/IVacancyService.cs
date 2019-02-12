﻿using JobHunter.Domain.Models.VacancyFiltersModels;
using JobHunter.Domain.Models.VacancyModels;
using System.Collections.Generic;

namespace JobHunter.Domain.Interfaces
{
    public interface IVacancyService
    {
        IEnumerable<VacancyListModel> GetVacancies(FilterModel filterModel);

    }
}
