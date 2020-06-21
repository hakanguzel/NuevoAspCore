using NuevoAspCore.Helpers.Abstract;
using NuevoAspCore.Models;

namespace NuevoAspCore.Helpers.Concrete
{
    public class DbUnitOfWorkFactory : IUnitOfWorkFactory
    {
        private readonly NuevoContext _dbContext;

        public DbUnitOfWorkFactory(NuevoContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IUnitOfWork Create()
        {
            return new DbUnitOfWork(_dbContext);
        }
    }
}
