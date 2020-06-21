using System.Threading.Tasks;
using NuevoAspCore.Helpers.Abstract;
using NuevoAspCore.Models;

namespace NuevoAspCore.Helpers.Concrete
{
    public class DbUnitOfWork : IUnitOfWork
    {
        private readonly NuevoContext _dbContext;

        public DbUnitOfWork(NuevoContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IRepository<T> Get<T>() where T : class
        {
            return new GenericRepository<T>(_dbContext);
        }

        public void Dispose()
        {
            _dbContext.Dispose();
        }

        public void SaveChanges()
        {
            _dbContext.SaveChanges();
        }

        public Task SaveChangesAsync()
        {
            return _dbContext.SaveChangesAsync();
        }
    }
}
