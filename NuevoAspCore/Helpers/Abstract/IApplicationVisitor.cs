using System.Threading.Tasks;

namespace NuevoAspCore.Helpers.Abstract
{
    /// <summary>
    /// Responsible for the periodic applications check
    /// </summary>
    public interface IApplicationVisitor
    {
        Task StartAsync();
    }
}
