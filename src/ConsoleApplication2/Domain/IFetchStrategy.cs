using System.Linq;

namespace ConsoleApplication2.Domain
{
    public interface IFetchStrategy<TEntity> where TEntity : class
    {
        IQueryable<TEntity> Apply(IQueryable<TEntity> queryable);
    }
}