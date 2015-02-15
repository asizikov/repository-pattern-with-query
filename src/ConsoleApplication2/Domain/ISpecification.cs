using System;
using System.Linq.Expressions;

namespace ConsoleApplication2.Domain
{
    public interface ISpecification<TEntity>
    {
        Expression<Func<TEntity, bool>> IsSatisfiedBy();
    }
}