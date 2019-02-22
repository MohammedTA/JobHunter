using System.Security.Claims;
using System.Threading.Tasks;

namespace JobHunter.Domain.Interfaces
{
    public interface IJwtFactory
    {
        string GenerateEncodedToken(Claim[] claim);
    }
}