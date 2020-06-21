using System;
using System.Net.Http;
using System.Threading.Tasks;
using NuevoAspCore.Helpers.Abstract;
using OriginHttpClient = System.Net.Http.HttpClient;


namespace NuevoAspCore.Helpers.Concrete
{
    public class HttpClient : IHttpClient
    {
        private static readonly OriginHttpClient Client = new OriginHttpClient();

        public Task<HttpResponseMessage> GetAsync(string url)
        {
            var requestUri = new Uri(url);

            return Client.GetAsync(requestUri);
        }
    }
}
