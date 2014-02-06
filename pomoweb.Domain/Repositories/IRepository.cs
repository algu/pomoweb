using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace pomoweb.Domain.Repositories
{
    public interface IRepository<T> where T : class
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

        T GetById(int id);
        T GetById(string id);
        IEnumerable<T> GetAll();

        IQueryable<T> Get(Expression<Func<T, bool>> where);
    }
}
