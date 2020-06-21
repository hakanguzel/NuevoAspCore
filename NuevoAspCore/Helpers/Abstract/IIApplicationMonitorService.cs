using System.Threading.Tasks;

namespace NuevoAspCore.Helpers.Abstract
{
    public interface IApplicationMonitorService
    {
        Task CheckApplicationsAsync();
    }
}
