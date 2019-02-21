using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Web.Http;
using JobHunter.Presentation.ViewModels;
using JobHunter.Presentation.ViewModels.EmployerPfofileViewModel;
using JobHunter.Domain.Interfaces;
using JobHunter.Domain.Models;
using JobHunter.Domain.Models.EmployerProfileDomainModel;

namespace JobHunter.Presentation.Controllers.API
{
    [Route("api/[controller]")]

    [ApiController]
    public class EmployerProfileController : Controller
    {
        private readonly IEmployerProfileService _employerProfileService;

        public EmployerProfileController(IEmployerProfileService employerProfileService) {

            _employerProfileService = employerProfileService;
                }

        [HttpPost("employer-profile")]
        public IActionResult CreateProfile([FromBody] EmployerProfileViewModel model)
        {
            if (ModelState.IsValid)

            {
                _employerProfileService.SetEmployerProfile(
                 new EmployerProfileDomainModel
                 {
                     ID = model.ID,
                     CompanyName = model.CompanyName,
                     Contact = new Domain.Models.EmployerProfileDomainModel.Contacts()
                     {
                         Telephone = model.Contact.Telephone,
                         Email = model.Contact.Email
                     },
                     EmployerType = new EmployerType() { },
                     ContactPerson = new ContactPerson()
                     {
                         PersonName = model.ContactPerson.PersonName,
                         PersonSurname = model.ContactPerson.PersonSurname,
                         PersonMiddleName = model.ContactPerson.PersonMiddleName
                     },
                     Country = model.Country,
                     Town = model.Town,
                     Site = model.Site,
                     Password = model.Password,
                     INN = model.INN,
                     Logo = model.Logo,
                     EGRPOU = model.EGRPOU
                 });
                return Json(new { data = "Employer Profile is create"});

            }                   

            else
            {
                return BadRequest(ModelState.Values); 
            }

        }
    }
}

