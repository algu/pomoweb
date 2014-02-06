using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using pomoweb.Domain.Repositories;

namespace pomoweb.Domain.Services
{
    public abstract class BaseService<T> where T : class
    {
        protected IRepository<T> GenericRepository;
        private readonly IUnitOfWork _unitOfWork;

        public BaseService(IRepository<T> genericRepository, IUnitOfWork unitOfWork)
        {
            this.GenericRepository = genericRepository;
            this._unitOfWork = unitOfWork;
        }

        public void Add(T entity)
        {
            GenericRepository.Add(entity);
            Save();
        }

        public void Update(T entity)
        {
            GenericRepository.Update(entity);
            Save();
        }
        public void Delete(T entity)
        {
            GenericRepository.Delete(entity);
            Save();
        }

        public void Delete(int id)
        {
            GenericRepository.Delete(GenericRepository.GetById(id));
            Save();
        }

        public T GetById(int id)
        {
            return GenericRepository.GetById(id);
        }

        public T GetById(string id)
        {
            return GenericRepository.GetById(id);
        }

        public IEnumerable<T> GetAll()
        {
            return GenericRepository.GetAll();
        }

        public IQueryable<T> Get(Expression<Func<T, bool>> where)
        {
            return GenericRepository.Get(where);
        }

        public void Save()
        {
            _unitOfWork.Commit();
        }

    }
}
