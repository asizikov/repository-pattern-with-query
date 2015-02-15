namespace ConsoleApplication2.Domain
{
    public interface IAccountRepository<TEntity> where TEntity : class
    {
        TEntity Get(IQuery<TEntity> query);
    }
}