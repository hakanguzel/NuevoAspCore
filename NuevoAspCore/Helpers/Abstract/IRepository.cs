using System;
using System.Linq;
using System.Linq.Expressions;

namespace NuevoAspCore.Helpers.Abstract
{
    public interface IRepository<T> where T : class
    {
        IQueryable<T> Entities { get; }

        IQueryable<T> Where(Expression<Func<T, bool>> where);

        IQueryable<T> AsQueryable();

        void Remove(T entity);

        void Add(T entity);
    }
}
