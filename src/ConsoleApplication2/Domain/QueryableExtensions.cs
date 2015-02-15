using System;
using System.Linq;
using System.Linq.Expressions;

namespace ConsoleApplication2.Domain
{
    public static class QueryableExtensions
    {
        public static IQueryable<T> Include<T, TProperty>(this IQueryable<T> queryable, Expression<Func<T, TProperty>> expression)
        {
            return queryable;
        }

        public static IQueryable<T> Fetch<T>(this IQueryable<T> queryable, IFetchStrategy<T> fetchStrategy ) where T : class
        {
            return fetchStrategy.Apply(queryable);
        }

        public static IQueryable<T> WithPaging<T>(this IQueryable<T> queryable, PagingSettings paging)
        {
            return queryable.Skip(paging.Offset).Take(paging.Size);
        }
    }
}