using System.Threading.Tasks;
using NuevoAspCore.Models.DbModels;
using NuevoAspCore.Models.Dtos;

namespace NuevoAspCore.Helpers.Abstract
{
    public interface IApplicationChecker
    {
        Task<CheckResult> CheckApplicationAsync(WebSites application);
    }
}
