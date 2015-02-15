namespace ConsoleApplication2.Domain
{
    public interface IQuery<TEntity> where TEntity : class
    {
        ISpecification<TEntity> Specification { get; }
        IFetchStrategy<TEntity> FetchStrategy { get; }
        PagingSettings PagingSettings { get; }
    }
}