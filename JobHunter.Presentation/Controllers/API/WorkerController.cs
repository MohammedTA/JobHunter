using JobHunter.Domain.Interfaces;
using JobHunter.Domain.Models;
using JobHunter.Domain.Services;
using JobHunter.Presentation.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace JobHunter.Presentation.Controllers.API
{
    
    [Route("api/[controller]")]
 //   [Authorize(Roles ="Worker")]
    public class WorkerController : Controller
    {
        private readonly IWorkerProfileService _workerProfileService;

        public WorkerController(IWorkerProfileService workerProfileService)
        {
            _workerProfileService = workerProfileService;
        }

        [HttpPost("create-worker-profile")]
        public IActionResult CreateWorkerProfile([FromBody]WokerProfileViewModel model)
        {
            List<PhoneNumberDTO> phones = new List<PhoneNumberDTO>();
            for(int i=0; i<model.contacts.phones.Length; i++)
            {
                phones.Add(new PhoneNumberDTO() { Phone = model.contacts.phones[i].Number });
            }
            if(ModelState.IsValid)
            {
                int id = _workerProfileService.CreateInfoProfile(
                    new WorkerProfileDTO()
                    {
                        Surname = model.surname,
                        Name = model.name,
                        Middlename = model.middlename,
                        Password = model.password,
                        Confirm_password = model.confirm_password,
                        Contacts = new ContactsDTO()
                        {
                            Skype = model.contacts.skype,
                            Telegram = model.contacts.telegram,
                            Viber = model.contacts.viber,
                            Whats_up = model.contacts.whats_up,
                            Phones = phones
                        }
                    }
                    );
                if (id == -1)
                    return BadRequest("Error in db");
                return Json(new { data = "Profile is create " });
            }
            else
            {
                return BadRequest(ModelState.Values); //Json(new { data = "Data not valid", valid = ModelState.Values });
            }
        }
    }
}
