using System.Collections.Generic;
using System.Linq;
using JobHunter.Domain.Interfaces;
using JobHunter.Domain.Models.CategoryModels;
using JobHunter.Domain.Models.CategoryFiltersModels;

namespace JobHunter.Domain.Services
{
    public class CategoryService : ICategoryService
    {
        private static readonly CategoryListModel[] categories = new CategoryListModel[]
        {
            new CategoryListModel
            {
                Id=1,
                Name="Agriculture"
            },
            new CategoryListModel
            {
                Id=2,
                Name="Natural Resource"
            }
        };

        public IEnumerable<CategoryListModel> GetCategories(FilterModel filterModel)
        {
            return categories.OrderByDescending(x => x.Name);
        }
    }
}
