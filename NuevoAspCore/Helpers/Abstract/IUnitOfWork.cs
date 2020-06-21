using System;
using System.Threading.Tasks;

namespace NuevoAspCore.Helpers.Abstract
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<T> Get<T>() where T : class;

        void SaveChanges();

        Task SaveChangesAsync();
    }
}
