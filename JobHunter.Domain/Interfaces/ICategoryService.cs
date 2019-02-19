using System.Collections.Generic;
using JobHunter.Domain.Models.CategoryModels;
using JobHunter.Domain.Models.CategoryFiltersModels;

namespace JobHunter.Domain.Interfaces
{
    public interface ICategoryService
    {
        IEnumerable<CategoryListModel> GetCategories(FilterModel filterModel);
    }
}
