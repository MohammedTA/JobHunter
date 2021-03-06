﻿using JobHunter.Domain.Models.PaginationModels;
using JobHunter.Domain.Models.VacancyFiltersModels;
using JobHunter.Domain.Models.VacancyModels;
using System.Collections.Generic;

namespace JobHunter.Domain.Interfaces
{
    public interface IVacancyService
    {
        PaginationOutPutModel<VacancyListModel> GetVacancies(FilterModel filterModel);
        PaginationOutPutModel<VacancyListModel> GetPaginationOutputList(PaginationParamsModel paginationModel);
    }
}
