using Domain;

namespace Application.Interface
{
    public interface IJwtGenerator
    {
        string CreateToken(AppUser user);
    }
}