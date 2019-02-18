using JobHunter.Domain.Models;
using JobHunter.Domain.Services;
using JobHunter.Presentation.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace JobHunter.Presentation.Controllers.API
{
    [Route("api/[controller]")]
    public class WorkerController : Controller
    {
        [HttpPost("create-worker-profile")]
        public IActionResult CreateWorkerProfile([FromBody]WokerProfileViewModel model)
        {
            return Json(new { data="vse ok" });
        }
    }
}
