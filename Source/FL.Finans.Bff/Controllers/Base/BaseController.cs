using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;
using System.Text.Json.Serialization;

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

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="endpoint"></param>
        /// <returns></returns>
        protected async Task<T> Get<T>(String endpoint)
        {
            var response = await Get(endpoint);

            return default;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="endpoint"></param>
        /// <returns></returns>
        private async Task<HttpResponseMessage> Get(string endpoint)
        {
            var output = await _httpClient.GetAsync(_urlBase + endpoint);

            return output;
        }

        protected async Task<T> PostAsync<T>(string endpoint, object objectSerialized, List<HttpClientParameter> header = null)
        {
            var response = await PostAsync(endpoint, JsonConvert.SerializeObject(objectSerialized), header);

            if (response == null)
            {
                var contentResult = await 
            }
        }

        private async Task<HttpResponseMessage> PostAsync(string endpoint, string objectSerialized, List<HttpClientParameter> header)
        {
            var request = new HttpRequestMessage()
            {
                Method = HttpMethod.Post,
                Content = new StringContent(objectSerialized, Encoding.UTF8, "application/json"),
                RequestUri = new Uri(endpoint),
            };

            var client = new HttpClient();
            client.Timeout = TimeSpan.FromMicroseconds(60000);

            if (header == null)
                header = new List<HttpClientParameter>();

            for(int i = 0; i < header.Count; i++)
                request.Headers.Add(header[i].Name, header[i].Value);
            
            var result = await client.SendAsync(request);

            return result;
        }

    }
}
