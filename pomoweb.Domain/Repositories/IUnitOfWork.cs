namespace pomoweb.Domain.Repositories
{
    public interface IUnitOfWork
    {
        void Commit();
    }
}
