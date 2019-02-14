using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JobHunter.Domain.Interfaces;
using JobHunter.Domain.Models.VacancyFiltersModels;
using JobHunter.Domain.Models.PaginationModels;
using JobHunter.Domain.Models.VacancyModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JobHunter.Presentation.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class VacancyController : ControllerBase
    {
        private readonly IVacancyService _vacancyService;

        public VacancyController(IVacancyService vacancyService)
        {
            _vacancyService = vacancyService;

        }
        [HttpPost("[action]")]
        public IActionResult GetVacancies([FromBody] FilterModel filters)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest();
            }
            return Ok(_vacancyService.GetVacancies(filters));
        }
        [HttpGet("[action]")]
        public IActionResult GetVacanciesList([FromQuery]PaginationModel paginationModel)
        {
            return Ok(_vacancyService.GetPaginationOutputList(paginationModel));
        }

    }
}