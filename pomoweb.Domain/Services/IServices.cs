using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace pomoweb.Domain.Services
{
    public interface IService<T> where T : class 
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        void Delete(int id);

        T GetById(int id);
        T GetById(string id);
        IEnumerable<T> GetAll();

        IQueryable<T> Get(Expression<Func<T, bool>> where);

    }
}
