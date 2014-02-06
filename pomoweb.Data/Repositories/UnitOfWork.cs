using pomoweb.Data.Infrastructure;
using pomoweb.Domain.Repositories;

namespace pomoweb.Data.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IDatabaseFactory _databaseFactory;
        private PomodoroModelContext _pomoContext;

        public UnitOfWork(IDatabaseFactory databaseFactory)
        {
            this._databaseFactory = databaseFactory;
        }

        protected PomodoroModelContext DataContext
        {
            get { return _pomoContext ?? (_pomoContext = _databaseFactory.Get()); }
        }

        public void Commit()
        {
            DataContext.SaveChanges();
        }
    }
}
