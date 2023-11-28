using Microsoft.AspNetCore.Identity;

namespace Hospital.API.Services
{
    public interface ITokenService
    {
        string CreateJWTToken(IdentityUser user, string role);
    }
}
