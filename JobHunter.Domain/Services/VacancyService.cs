using JobHunter.Domain.Interfaces;
using JobHunter.Domain.Models.PaginationModels;
using JobHunter.Domain.Models.VacancyFiltersModels;
using JobHunter.Domain.Models.VacancyModels;
using System.Collections.Generic;
using System.Linq;
using System;
using JobHunter.Data;

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
                Title="FrontEnd developer",
                Description="work with HTML5, Sass, angular7",
                Date="13.02.2019",
                CompanyLogo=BASELOGOURL,
                IsHot=true,
                IsVip=false,
                VacancyCity="Rivne",
                CompanyTitle="SoftServe",
                VacancyCost="1000"
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
                Description="create modern apps with Unity 3D game engine",
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
                Description="work with clients, gave them full info about products and support",
                Date="10.02.2019",
                CompanyLogo=BASELOGOURL,
                IsHot=true,
                IsVip=false,
                VacancyCity="Lviv",
                CompanyTitle="Bodo",
                VacancyCost="600"
            },
                     new VacancyListModel
            {
                Id=5,
                Title="New business manager",
                Description="work with clients, gave them full info about products and support",
                Date="11.02.2019",
                CompanyLogo=BASELOGOURL,
                IsHot=true,
                IsVip=false,
                VacancyCity="Lviv",
                CompanyTitle="Bodo",
                VacancyCost="800"
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
                Title="FrontEnd developer",
                Description="work with HTML5, Sass, ReactJs",
                Date="17.02.2019",
                CompanyLogo=BASELOGOURL,
                IsHot=true,
                IsVip=false,
                VacancyCity="Kyiv",
                CompanyTitle="SoftServe",
                VacancyCost="1700"
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
                Description="create modern apps with Unity 3D game engine",
                Date="10.02.2019",
                CompanyLogo=ABGAMESLOGOURL,
                VacancyCity="Kyiv",
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
                     new VacancyListModel
            {
                Id=15,
                Title="FrontEnd developer",
                Description="work with HTML5, Sass, angular7",
                Date="13.02.2019",
                CompanyLogo=BASELOGOURL,
                IsHot=true,
                IsVip=false,
                VacancyCity="Lviv",
                CompanyTitle="SoftServe",
                VacancyCost="1000"
            },
             new VacancyListModel
            {
                Id=16,
                Title="JS developer",
                Description="create modern apps with rich interface and animation",
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
                Id=17,
                Title="Unity3D Game developer",
                Description="the best vacancy",
                Date="15.02.2019",
                CompanyLogo=ABGAMESLOGOURL,
                VacancyCity="Kyiv",
                IsHot=false,
                IsVip=false,
                CompanyTitle="AB Games"
            },
               new VacancyListModel
            {
                Id=18,
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
                Id=19,
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
                Id=20,
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
                Id=21,
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
                Id=22,
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
                Id=23,
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
                Id=24,
                Title="Unity3D Game developer",
                Description="the best vacancy",
                Date="10.02.2019",
                CompanyLogo=ABGAMESLOGOURL,
                VacancyCity="Lviv",
                IsHot=false,
                IsVip=false,
                CompanyTitle="AB Games"
            },
               new VacancyListModel
            {
                Id=25,
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
                Id=26,
                Title="New business manager",
                Description="the best vacancy",
                Date="10.01.2019",
                CompanyLogo=BASELOGOURL,
                VacancyCity="Lviv",
                 IsHot=false,
                IsVip=false,
                CompanyTitle="Bodo",
                VacancyCost="500"
            },
                       new VacancyListModel
            {
                Id=27,
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
                Id=28,
                Title="New business manager",
                Description="the best vacancy",
                Date="17.01.2019",
                CompanyLogo=BASELOGOURL,
                VacancyCity="Lviv",
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
                .Take(paginationModel.PageSize).OrderByDescending(x=>x.IsHot);
            var paginatedmodel = new PaginationOutPutModel<VacancyListModel>()
            {
                PageInfo = pageinfo,
                PaginatedList = result.ToList()
            };
            return paginatedmodel;
        }

        public PaginationOutPutModel<VacancyListModel> GetVacancies(FilterModel filterModel)
        {
            var query = vacancies.AsQueryable();
            if(!string.IsNullOrEmpty(filterModel.Query))
            {
                query = vacancies.Where(x => x.Title.ToUpper().Contains(filterModel.Query.ToUpper()) || 
                x.Description.ToUpper().Contains(filterModel.Query.ToUpper()))
                    .OrderBy(x=>x.IsHot).AsQueryable();
            }
            if (!string.IsNullOrEmpty(filterModel.City))
            {
                query = query.Where(x => x.VacancyCity.ToUpper().Contains(filterModel.City.ToUpper())).OrderBy(x => x.IsHot).AsQueryable();
            }
            var amount = query.Count();
            var pageinfo = new Helpers.PageInfo
            {
                CurrentPage = filterModel.CurrentPage,
                TotalItems = amount
            };
            query = query.OrderBy(p => p.Id).Skip((filterModel.CurrentPage - 1) * pageinfo.ItemsPerPage)
                .Take(pageinfo.ItemsPerPage).OrderByDescending(x => x.IsHot);
            var paginatedmodel = new PaginationOutPutModel<VacancyListModel>()
            {
                PageInfo = pageinfo,
                PaginatedList =query.ToList()
            };
            return paginatedmodel;
        }  
    }
}
