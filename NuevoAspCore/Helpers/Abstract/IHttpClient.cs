using System.Net.Http;
using System.Threading.Tasks;

namespace NuevoAspCore.Helpers.Abstract
{
    public interface IHttpClient
    {
        Task<HttpResponseMessage> GetAsync(string url);
    }
}
