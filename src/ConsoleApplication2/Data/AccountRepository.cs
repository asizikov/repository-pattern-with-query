using System.Collections.Generic;
using System.Linq;

namespace ConsoleApplication2.Domain
{
    public class AccountRepository : IAccountRepository<Account>
    {
        private IQueryable<Account> Accounts { get; set; }

        public AccountRepository()
        {
            var accounts = new List<Account>
            {
                new Account {Id = 1, Name = "1"},
                new Account {Id = 2, Name = "2"},
                new Account {Id = 3, Name = "3"},
                new Account {Id = 4, Name = "4"}
            };
            Accounts = new EnumerableQuery<Account>(accounts);
        }


        public Account Get(IQuery<Account> query)
        {
            return Accounts.Where(query.Specification.IsSatisfiedBy())
                .Fetch(query.FetchStrategy)
                .WithPaging(query.PagingSettings)
                .FirstOrDefault();
        }
    }
}