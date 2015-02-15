namespace ConsoleApplication2.Domain
{
    public class Controller
    {
        private AccountRepository AccountRepository { get; set; }

        public Controller(AccountRepository accountRepository)
        {
            AccountRepository = accountRepository;
        }

        public Account Get(int id)
        {
            return AccountRepository.Get(AccountByIdQuery.Create(id));
        }
    }
}