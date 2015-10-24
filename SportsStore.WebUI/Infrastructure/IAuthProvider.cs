
namespace SportsStore.WebUI.Infrastructure
{
    public interface IAuthProvider
    {
        bool Authenticate(string username, string password);
    }
}
