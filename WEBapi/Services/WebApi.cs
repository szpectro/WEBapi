using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace WEBapi.Services
{
    public class WebApi : IWebApi
    {
        private readonly HttpClient _httpClient;
        public WebApi(HttpClient httpClient)
        {
            this._httpClient = httpClient;
        }

        public Task<string> GetToken(string username, string password)
        {
            throw new NotImplementedException();
        }
    }
}
