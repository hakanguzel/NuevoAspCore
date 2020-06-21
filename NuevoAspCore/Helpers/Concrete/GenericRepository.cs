using System;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using NuevoAspCore.Helpers.Abstract;
using NuevoAspCore.Models;

namespace NuevoAspCore.Helpers.Concrete
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {
        private readonly DbSet<T> _dbSet;

        public IQueryable<T> Entities => _dbSet;

        public GenericRepository(NuevoContext dbContext)
        {
            _dbSet = dbContext.Set<T>();
        }

        public void Remove(T entity)
        {
            _dbSet.Remove(entity);
        }

        public void Add(T entity)
        {
            _dbSet.Add(entity);
        }

        public IQueryable<T> Where(Expression<Func<T, bool>> where)
        {
            return _dbSet.Where(where);
        }

        public IQueryable<T> AsQueryable()
        {
            return _dbSet.AsQueryable();
        }
    }
}
