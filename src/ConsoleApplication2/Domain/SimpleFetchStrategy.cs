using System;
using System.Linq;

namespace ConsoleApplication2.Domain
{
    public class SimpleFetchStrategy<T> : IFetchStrategy<T> where T : class
    {
        private Func<IQueryable<T>, IQueryable<T>> Action { get; set; }

        public SimpleFetchStrategy(Func<IQueryable<T>, IQueryable<T>> action)
        {
            Action = action;
        }

        public IQueryable<T> Apply(IQueryable<T> queryable)
        {
            return Action(queryable);
        }
    }
}