namespace TheThingsStack
{
    using System;
    using System.Net;
    using System.Web;
    using System.Text;
    using System.Net.Http;
    using System.Threading.Tasks;
    using System.Net.Http.Headers;

    using Newtonsoft.Json;
    using Newtonsoft.Json.Serialization;

    using Exceptions;

    public class TheThingsStackIntegrationClient
    {
        #region Fields

        private const string apiVersion = "api/v3/";
        private const string productInfo = "TheThingsStackIntegrationClient";

        private readonly HttpClient httpClient;

        #endregion Fields

        #region Constructor

        public TheThingsStackIntegrationClient(string baseUrl, string token)
        {
            this.httpClient = new HttpClient { BaseAddress = new Uri($"{baseUrl}{apiVersion}") };
            this.httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(scheme: "Bearer", parameter: token);
            this.httpClient.DefaultRequestHeaders.UserAgent.Add(new ProductInfoHeaderValue(productName: productInfo, productVersion: "0.0.1"));
            this.httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        #endregion Constructor

        #region Methods

        public async Task<T> PostAsync<T>(string resourceUrl, object data) where T : class
        {
            if (string.IsNullOrWhiteSpace(resourceUrl))
            {
                throw new ArgumentException("Resource Url Cannot Be Empty");
            }

            if (data == null)
            {
                throw new ArgumentException("Data Cannot Be Null");
            }

            var content = new StringContent(SerializeToJson(data), Encoding.UTF8, "application/json");

            var httpResponseMessage = await this.httpClient.PostAsync(resourceUrl, content);

            if (httpResponseMessage.StatusCode == HttpStatusCode.OK || httpResponseMessage.StatusCode == HttpStatusCode.Created)
            {
                return httpResponseMessage.Deserialize<T>();
            }

            throw new IntegrationException(httpResponseMessage: httpResponseMessage, httpResponseMessage.ReasonPhrase);
        }

        public async Task<T> GetAsync<T>(string resourceUrl, string queryString) where T : class
        {
            if (string.IsNullOrWhiteSpace(resourceUrl))
            {
                throw new ArgumentException("Resource Url Cannot Be Empty");
            }

            var finalResourceUrl = string.IsNullOrWhiteSpace(queryString) ? resourceUrl : $"{resourceUrl}?{HttpUtility.ParseQueryString(query: queryString).ToString()}";

            var httpResponseMessage = await this.httpClient.GetAsync(finalResourceUrl);

            if (httpResponseMessage.StatusCode == HttpStatusCode.OK)
            {
                return httpResponseMessage.Deserialize<T>();
            }

            throw new IntegrationException(httpResponseMessage: httpResponseMessage, httpResponseMessage.ReasonPhrase);
        }

        public async Task<T> PutAsync<T>(string resourceUrl) where T : class
        {
            if (string.IsNullOrWhiteSpace(resourceUrl))
            {
                throw new ArgumentException("Resource Url Cannot Be Emtpty");
            }

            var httpResponseMessage = await this.httpClient.PutAsync(resourceUrl, null);

            if (httpResponseMessage.StatusCode == HttpStatusCode.OK)
            {
                return httpResponseMessage.Deserialize<T>();
            }

            throw new IntegrationException(httpResponseMessage: httpResponseMessage, httpResponseMessage.ReasonPhrase);
        }

        public async Task<T> PutAsync<T>(string resourceUrl, object data) where T : class
        {
            if (string.IsNullOrWhiteSpace(resourceUrl))
            {
                throw new ArgumentException("Resource Url Cannot Be Emtpty");
            }

            if (data == null)
            {
                throw new ArgumentException("Data Cannot Be Null");
            }

            var content = new StringContent(SerializeToJson(data), Encoding.UTF8, "application/json");

            var httpResponseMessage = await this.httpClient.PutAsync(resourceUrl, content);

            if (httpResponseMessage.StatusCode == HttpStatusCode.OK)
            {
                return httpResponseMessage.Deserialize<T>();
            }

            throw new IntegrationException(httpResponseMessage: httpResponseMessage, httpResponseMessage.ReasonPhrase);
        }

        public async Task<bool> DeleteAsync(string resourceUrl)
        {
            if (string.IsNullOrWhiteSpace(resourceUrl))
            {
                throw new ArgumentException("Resource Url Cannot Be Empty");
            }

            var httpResponseMessage = await this.httpClient.DeleteAsync(resourceUrl);

            if (httpResponseMessage.StatusCode == HttpStatusCode.OK)
            {
                return true;
            }

            throw new IntegrationException(httpResponseMessage: httpResponseMessage, httpResponseMessage.ReasonPhrase);
        }

        #endregion Methods

        #region Private Methods

        private static string SerializeToJson<T>(T obj)
        {
            var settings = new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver(), NullValueHandling = NullValueHandling.Ignore };

            return JsonConvert.SerializeObject(obj, settings);
        }

        #endregion Private Methods
    }
}
