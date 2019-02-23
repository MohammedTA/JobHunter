using System.Threading.Tasks;
using AutoMapper;
using JobHunter.Domain.Interfaces;
using JobHunter.Domain.Models.AuthModels;
using JobHunter.Presentation.Helpers;
using JobHunter.Presentation.ViewModels.LoginViewModels;
using Microsoft.AspNetCore.Mvc;

namespace JobHunter.Presentation.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _service;

        public AuthController(IAuthService service)
        {
            _service = service;
        }        

        [HttpPost("login")]
        public async Task<IActionResult> Login(UserForLoginViewModel userForLogin)
        {
            var userToLogin = Mapper.Map<UserForLoginDto>(userForLogin);

            var user = await _service.Login(userToLogin);

            if (user == null)
                return BadRequest(Errors.AddErrorToModelState("login_failure", "Invalid username or password.", ModelState));

            return Ok(new {
                token = user
            });
        }

        [HttpPost("fblogin")]
        public async Task<IActionResult> LoginWithFB(FacebookLoginViewModel facebookLogin)
        {
            var user = await _service.LoginWithFacebook(facebookLogin.authToken);

            if (user == null)
                return BadRequest(Errors.AddErrorToModelState("login_failure", "Invalid username or password.", ModelState));
            
            return Ok(new {
                token = user
            });
        }
    }
}