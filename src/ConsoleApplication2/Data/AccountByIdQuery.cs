namespace ConsoleApplication2.Domain
{
    public class AccountByIdQuery : IQuery<Account>
    {
        public ISpecification<Account> Specification { get; private set; }
        public IFetchStrategy<Account> FetchStrategy { get; private set; }
        public PagingSettings PagingSettings { get; private set; }

        public static AccountByIdQuery Create(int id)
        {
            return new AccountByIdQuery
            {
                PagingSettings = new PagingSettings {Offset = 0, Size = 2},
                Specification = new AccountsByIdSpecification(id),
                FetchStrategy = new SimpleFetchStrategy<Account>(accounts => accounts.Include(a => a.Addres).Include(a => a.Addres))
            };
        }
    }
}