using JobHunter.Domain.Interfaces;
using JobHunter.Domain.Models.PaginationModels;
using JobHunter.Domain.Models.VacancyFiltersModels;
using JobHunter.Domain.Models.VacancyModels;
using System.Collections.Generic;
using System.Linq;


namespace JobHunter.Domain.Services
{
    public class VacancyService : IVacancyService
    {
        private const string BASELOGOURL = "https://localhost:44365/Images/CompanyLogos/logo.png";
        private const string ABGAMESLOGOURL = "https://localhost:44365/Images/CompanyLogos/ABGameslogo.png";
        private static readonly VacancyListModel[] vacancies = new VacancyListModel[]
        {
            new VacancyListModel
            {
                Id=1,
                Title=".NET developer",
                Description="the best vacancy",
                Date="11.02.2019",
                CompanyLogo=BASELOGOURL,
                IsHot=true,
                IsVip=false,
                VacancyCity="Rivne",
                CompanyTitle="SoftServe",
                VacancyCost="1200"
            },
             new VacancyListModel
            {
                Id=2,
                Title="JS developer",
                Description="the best vacancy",
                Date="1.02.2019",
                CompanyLogo=BASELOGOURL,
                VacancyCity="Rivne",
                IsHot=true,
                IsVip=false,
                CompanyTitle="SoftServe",
                VacancyCost="800"
            },
              new VacancyListModel
            {
                Id=3,
                Title="Unity3D Game developer",
                Description="the best vacancy",
                Date="10.02.2019",
                CompanyLogo=ABGAMESLOGOURL,
                VacancyCity="Rivne",
                IsHot=false,
                IsVip=false,
                CompanyTitle="AB Games"
            },
               new VacancyListModel
            {
                Id=4,
                Title="New business manager",
                Description="the best vacancy",
                Date="10.02.2019",
                CompanyLogo=BASELOGOURL,
                IsHot=true,
                IsVip=false,
                VacancyCity="Kyiv",
                CompanyTitle="Bodo",
                VacancyCost="600"
            },
                     new VacancyListModel
            {
                Id=5,
                Title="New business manager",
                Description="the best vacancy",
                Date="10.01.2019",
                CompanyLogo=BASELOGOURL,
                VacancyCity="Kyiv",
                 IsHot=false,
                IsVip=false,
                CompanyTitle="Bodo",
                VacancyCost="500"
            },
                       new VacancyListModel
            {
                Id=6,
                Title="New business manager",
                Description="the best vacancy",
                Date="11.01.2019",
                CompanyLogo=BASELOGOURL,
                VacancyCity="Kyiv",
                IsHot=false,
                IsVip=false,
                CompanyTitle="Sabo"
            },
                    new VacancyListModel
            {
                Id=7,
                Title="New business manager",
                Description="the best vacancy",
                Date="17.01.2019",
                CompanyLogo=BASELOGOURL,
                VacancyCity="Kyiv",
                IsHot=false,
                IsVip=false,
                CompanyTitle="Sabo"
            },
                     new VacancyListModel
            {
                Id=8,
                Title=".NET developer",
                Description="the best vacancy",
                Date="11.02.2019",
                CompanyLogo=BASELOGOURL,
                IsHot=true,
                IsVip=false,
                VacancyCity="Rivne",
                CompanyTitle="SoftServe",
                VacancyCost="1200"
            },
             new VacancyListModel
            {
                Id=9,
                Title="JS developer",
                Description="the best vacancy",
                Date="1.02.2019",
                CompanyLogo=BASELOGOURL,
                VacancyCity="Rivne",
                IsHot=true,
                IsVip=false,
                CompanyTitle="SoftServe",
                VacancyCost="800"
            },
              new VacancyListModel
            {
                Id=10,
                Title="Unity3D Game developer",
                Description="the best vacancy",
                Date="10.02.2019",
                CompanyLogo=ABGAMESLOGOURL,
                VacancyCity="Rivne",
                IsHot=false,
                IsVip=false,
                CompanyTitle="AB Games"
            },
               new VacancyListModel
            {
                Id=11,
                Title="New business manager",
                Description="the best vacancy",
                Date="10.02.2019",
                CompanyLogo=BASELOGOURL,
                IsHot=true,
                IsVip=false,
                VacancyCity="Kyiv",
                CompanyTitle="Bodo",
                VacancyCost="600"
            },
                     new VacancyListModel
            {
                Id=12,
                Title="New business manager",
                Description="the best vacancy",
                Date="10.01.2019",
                CompanyLogo=BASELOGOURL,
                VacancyCity="Kyiv",
                 IsHot=false,
                IsVip=false,
                CompanyTitle="Bodo",
                VacancyCost="500"
            },
                       new VacancyListModel
            {
                Id=13,
                Title="New business manager",
                Description="the best vacancy",
                Date="11.01.2019",
                CompanyLogo=BASELOGOURL,
                VacancyCity="Kyiv",
                IsHot=false,
                IsVip=false,
                CompanyTitle="Sabo"
            },
                    new VacancyListModel
            {
                Id=14,
                Title="New business manager",
                Description="the best vacancy",
                Date="17.01.2019",
                CompanyLogo=BASELOGOURL,
                VacancyCity="Kyiv",
                IsHot=false,
                IsVip=false,
                CompanyTitle="Sabo"
            },
        };

        public PaginationOutPutModel<VacancyListModel> GetPaginationOutputList(PaginationParamsModel paginationModel)
        {
            var amount = vacancies.Count();
            var pageinfo = new Helpers.PageInfo
            {
                CurrentPage = paginationModel.CurrentPage,
                ItemsPerPage = paginationModel.PageSize,
                TotalItems = amount
            };
            var result=vacancies.OrderBy(p => p.Id).Skip((paginationModel.CurrentPage - 1) * paginationModel.PageSize)
                .Take(paginationModel.PageSize);
            var paginatedmodel = new PaginationOutPutModel<VacancyListModel>()
            {
                PageInfo = pageinfo,
                PaginatedList = result.ToList()
            };
            return paginatedmodel;
        }

        public IEnumerable<VacancyListModel> GetVacancies(FilterModel filterModel)
        {
            return vacancies.OrderByDescending(x=>x.IsHot);
        }  
    }
}
