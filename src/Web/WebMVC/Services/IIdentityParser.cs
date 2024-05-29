using System.Security.Principal;

namespace BolaRoja.WebMVC.Services
{
    public interface IIdentityParser<T>
    {
        T Parse(IPrincipal principal);
    }
}
