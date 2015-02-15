using System;
using System.Linq.Expressions;

namespace ConsoleApplication2.Domain
{
    public class AccountsByIdSpecification : ISpecification<Account>
    {
        private int Id { get; set; }

        public AccountsByIdSpecification(int id)
        {
            Id = id;
        }

        public Expression<Func<Account, bool>> IsSatisfiedBy()
        {
            return account => account.Id == Id;
        }
    }
}