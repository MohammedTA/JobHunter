using JobHunter.Domain.Interfaces;
using JobHunter.Domain.Models.PaginationModels;
using JobHunter.Domain.Models.VacancyFiltersModels;
using JobHunter.Domain.Models.VacancyModels;
using System.Collections.Generic;
using System.Linq;
using System;
using JobHunter.Data;
using JobHunter.Data.Intefaces;
using JobHunter.Data.Entities;
using JobHunter.Domain.Enums;

namespace JobHunter.Domain.Services
{
    public class VacancyService : IVacancyService
    {
        enum VacancyStatus {HOT, VIP}
        int[] test = { 0, 1, 2 };
        private readonly IRepository<Vacancy> _context;
        private readonly IRepository<Category> _contextcategory;
        // private readonly ApplicationContext _context;
        public VacancyService(IRepository<Vacancy> context, IRepository<Category> categorycontext)
        {
            _context = context;
            _contextcategory = categorycontext;
        }
        private const string BASELOGOURL = "https://localhost:44365/Images/CompanyLogos/logo.png";
        private const string ABGAMESLOGOURL = "https://localhost:44365/Images/CompanyLogos/ABGameslogo.png";
        public PaginationOutPutModel<VacancyListModel> GetVacancies(FilterModel filterModel)
        {
            var query = _context.GetQueryable().Where(x => x.AgreementSpam && x.CreationDate < DateTime.Now && x.ExpirationDate > DateTime.Now);
            if (!string.IsNullOrEmpty(filterModel.Query))
            {
                query = query.Where(x => x.Name.ToUpper().Contains(filterModel.Query.ToUpper()) ||
                x.Description.ToUpper().Contains(filterModel.Query.ToUpper()));
            }
            if (!string.IsNullOrEmpty(filterModel.City))
            {
                query = query.Where(x => x.Employer.City.Name.ToUpper().Contains(filterModel.City.ToUpper()));
            }
            if (filterModel.VacancyCost != 0M)
            {
                query = query.Where(x => x.Salary >= filterModel.VacancyCost);
            }
            if (filterModel.Visa.On)
            {
                query = query.Where(x => x.Visa);
            }
            else if (filterModel.Visa.Off)
            {
                query = query.Where(x => x.Visa==false);
            }
            if(filterModel.Categories.Where(c=>c.IsSelected).Count()>0)
            {
                query=query.Where(x=>filterModel.Categories.Select(c=>c.CategoryName).Contains(x.Category.Name));
            }
            if (filterModel.Gender.Male)
            {
                query = query.Where(x=>test.Contains(x.Gender));
            }
            if (filterModel.Gender.Female)
            {
                query = query.Where(x => test.Contains(x.Gender));
            }
            if (filterModel.Gender.Other)
            {
                query = query.Where(x => test.Contains(x.Gender));
            }
            var amount = query.Count();
            var pageinfo = new Helpers.PageInfo
            {
                CurrentPage = filterModel.CurrentPage,
                TotalItems = amount
            };
            query = query.OrderBy(p => p.Id).Skip((filterModel.CurrentPage - 1) * pageinfo.ItemsPerPage)
                .Take(pageinfo.ItemsPerPage);
            var result = query.Select(x => new VacancyListModel
            {
                Id = x.Id,
                Title = x.Name,
                Description = x.Description,
                CompanyLogo = x.Employer.LogoURL == null ? BASELOGOURL : x.Employer.LogoURL,
                CompanyTitle = x.Employer.CompanyName,
                Date = x.CreationDate.ToShortDateString(),
                IsHot = x.VacancyStatuses.Select(s => s.Status.Name).Contains(VacancyStatus.HOT.ToString()),
                IsVip = x.VacancyStatuses.Select(s => s.Status.Name).Contains(VacancyStatus.VIP.ToString()),
                VacancyCity = x.Employer.City.Name,
                VacancyCost = x.Salary
            });
            var paginatedmodel = new PaginationOutPutModel<VacancyListModel>()
            {
                PageInfo = pageinfo,
                PaginatedList = result.ToList()
            };
            return paginatedmodel;
        }

        public FilterEndPointsModel GetFilterEndPointsModel()
        {
            FilterEndPointsModel result = new FilterEndPointsModel
            {
                LanguageLevels=Enum.GetNames(typeof(FilterEnums.LanguageLevel)).ToList(),
                Categories=_contextcategory.Get().Select(x=>x.Name).ToList(),
                Experience = Enum.GetNames(typeof(FilterEnums.Experiance)).ToList(),
                SalaryMaxValue = _context.Get().Max(x=>x.Salary)
            };
            return result;
        }
    }
}
