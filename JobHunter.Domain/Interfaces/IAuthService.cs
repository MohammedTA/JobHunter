using System.Threading.Tasks;
using JobHunter.Domain.Models;

namespace JobHunter.Domain.Interfaces
{
    public interface IAuthService
    {
         Task<string> Login(UserForLoginDto userForLogin);

         Task<string> LoginWithFacebook(string accessToken);
    }
}