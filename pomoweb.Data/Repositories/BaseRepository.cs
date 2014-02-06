using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using pomoweb.Data.Infrastructure;

namespace pomoweb.Data.Repositories
{
    public abstract class BaseRepository<T> where T : class
    {
        private PomodoroModelContext _pomoContext;
        private IDbSet<T> _dbset;

        protected BaseRepository(IDatabaseFactory databaseFactory)
        {
            DatabaseFactory = databaseFactory;
            _dbset = DataContext.Set<T>();
        }

        protected IDatabaseFactory DatabaseFactory
        {
            get; private set;
        }

        protected PomodoroModelContext DataContext
        {
            get { return _pomoContext ?? (_pomoContext = DatabaseFactory.Get()); }
        }

        public virtual void Add(T entity)
        {
            _dbset.Add(entity);
        }

        public virtual void Update(T entity)
        {
            _dbset.Attach(entity);
            _pomoContext.Entry(entity).State = EntityState.Modified;
        }

        public virtual void Delete(T entity)
        {
            _dbset.Remove(entity);
        }

        public virtual T GetById(int id)
        {
            return _dbset.Find(id);
        }

        public virtual T GetById(string id)
        {
            return _dbset.Find(id);
        }

        public virtual IEnumerable<T> GetAll()
        {
            return _dbset.ToList();
        }

        //public virtual IEnumerable<T> GetMany(Expression<Func<T, bool>> where)
        //{
        //    return _dbset.Where(where).ToList();
        //}

        public IQueryable<T> Get(Expression<Func<T, bool>> where)
        {
            return _dbset.Where(where);
        } 

    }
}
