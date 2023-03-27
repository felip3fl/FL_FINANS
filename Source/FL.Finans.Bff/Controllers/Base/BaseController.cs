using Microsoft.AspNetCore.Mvc;

namespace FL.Finans.Bff.Controllers.Base
{
    public class BaseController : Controller
    {

        private HttpClient _httpClient;
        private readonly string _urlBase;

        public BaseController()
        {
            _urlBase = "";
            _httpClient = new HttpClient();
        }

        protected async Task<T> Get<T>(String endpoint)
        {
            var response = await Get(endpoint);

            return default;
        }

        private async Task<HttpResponseMessage> Get(string endpoint)
        {
            var output = await _httpClient.GetAsync(_urlBase + endpoint);

            return output;
        }

    }
}
