using System.Threading.Tasks;

namespace WEBapi.Services
{
    public interface IWebApi
    {
        Task<string> GetToken(string email, string password);
    }
}
