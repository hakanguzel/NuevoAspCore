using System;
using System.Threading.Tasks;

namespace NuevoAspCore.Helpers.Abstract
{
    public interface IConfigurationService
    {
        Task<TimeSpan> GetDelayAsync();
    }
}
