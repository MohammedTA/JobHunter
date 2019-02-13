using JobHunter.Domain.Interfaces;
using JobHunter.Domain.Models.VacancyFiltersModels;
using JobHunter.Domain.Models.VacancyModels;
using System.Collections.Generic;


namespace JobHunter.Domain.Services
{
    public class VacancyService : IVacancyService
    {
        private static readonly VacancyListModel[] vacancies = new VacancyListModel[]
        {
            new VacancyListModel
            {
                Id=1,
                Title=".NET developer",
                Description="the best vacancy",
                Date="11.02.2019",
                CompanyLogo="",
                VacancyCity="Rivne",
                VacancyType="hot",
                CompanyTitle="SoftServe",
                VacancyCost="1200"
            },
             new VacancyListModel
            {
                Id=2,
                Title="JS developer",
                Description="the best vacancy",
                Date="1.02.2019",
                CompanyLogo="",
                VacancyCity="Rivne",
                VacancyType="ordinary",
                CompanyTitle="SoftServe",
                VacancyCost="800"
            },
              new VacancyListModel
            {
                Id=3,
                Title="Unity3D Game developer",
                Description="the best vacancy",
                Date="10.02.2019",
                CompanyLogo="",
                VacancyCity="Rivne",
                VacancyType="ordinary",
                CompanyTitle="AB Games"
            },
               new VacancyListModel
            {
                Id=4,
                Title="New business manager",
                Description="the best vacancy",
                Date="10.02.2019",
                CompanyLogo="",
                VacancyCity="Kyiv",
                VacancyType="ordinary",
                CompanyTitle="Bodo",
                VacancyCost="600"
            },
                     new VacancyListModel
            {
                Id=5,
                Title="New business manager",
                Description="the best vacancy",
                Date="10.01.2019",
                CompanyLogo="",
                VacancyCity="Kyiv",
                VacancyType="ordinary",
                CompanyTitle="Bodo",
                VacancyCost="500"
            },
                       new VacancyListModel
            {
                Id=6,
                Title="New business manager",
                Description="the best vacancy",
                Date="11.01.2019",
                CompanyLogo="",
                VacancyCity="Kyiv",
                VacancyType="ordinary",
                CompanyTitle="Sabo"
            },
                    new VacancyListModel
            {
                Id=7,
                Title="New business manager",
                Description="the best vacancy",
                Date="17.01.2019",
                CompanyLogo="",
                VacancyCity="Kyiv",
                VacancyType="ordinary",
                CompanyTitle="Sabo"
            }, 
        };

        public IEnumerable<VacancyListModel> GetVacancies(FilterModel filterModel)
        {
            return vacancies;
        }
    }
}
