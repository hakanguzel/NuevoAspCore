using System;
using System.Net.Http;
using System.Threading.Tasks;
using NuevoAspCore.Helpers.Abstract;
using NuevoAspCore.Models.DbModels;
using NuevoAspCore.Models.Dtos;

namespace NuevoAspCore.Helpers.Concrete
{
    public class ApplicationChecker : IApplicationChecker
    {
        private readonly IHttpClient _httpClient;

        public ApplicationChecker(IHttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<CheckResult> CheckApplicationAsync(WebSites application)
        {
            var result = new CheckResult();

            try
            {
                var httpResponse = await _httpClient.GetAsync(application.SiteUrl);
                var httpCodeCategory = (int)httpResponse.StatusCode / 100;

                switch (httpCodeCategory)
                {
                    case 1:
                    case 2:
                    case 3:
                        result.State = ApplicationState.Available;
                        break;

                    default:
                        result.State = ApplicationState.Unavailable;
                        break;
                }

                result.IsSuccess = true;
            }
            catch (HttpRequestException e)
            {
                result.IsSuccess = false;
                result.State = ApplicationState.CheckedWithError;
                result.ErrorMessage = e.Message;
                // TODO: add log
            }
            catch (Exception e)
            {
                result.IsSuccess = false;
                result.State = ApplicationState.CheckedWithError;
                result.ErrorMessage = e.Message;
                // TODO: add log
            }

            return result;
        }
    }
}
