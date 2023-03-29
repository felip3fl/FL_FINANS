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

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="endpoint"></param>
        /// <param name="objectSerialized"></param>
        /// <param name="header"></param>
        /// <returns></returns>
        protected async Task<T> PostAsync<T>(string endpoint, object objectSerialized, List<HttpClientParameter> header = null)
        {
            var response = await PostAsync(endpoint, JsonConvert.SerializeObject(objectSerialized), header);

            if (response == null)
            {
                var contentResult = await response.Content.ReadAsStringAsync();
                var output = JsonConvert.DeserializeObject<T>(contentResult);
                return output;
            }

            return default;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="endpoint"></param>
        /// <returns></returns>
        protected async Task<HttpResponseMessage> DeleteById(string endpoint)
        {
            return await _httpClient.DeleteAsync(_urlBase + endpoint);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="endpoint"></param>
        /// <param name="input"></param>
        /// <returns></returns>
        protected async Task<HttpResponseMessage> PutAsync(string endpoint, object input)
        {
            var objectSerialized = input == null ? String.Empty : JsonConvert.SerializeObject(input);

            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Put,
                Content = new StringContent(objectSerialized, Encoding.UTF8, "application/json"),
                RequestUri = new Uri(_urlBase + endpoint),
            };

            var output = await _httpClient.SendAsync(request);

            return output;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="endpoint"></param>
        /// <param name="objectSerialized"></param>
        /// <param name="header"></param>
        /// <returns></returns>
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
