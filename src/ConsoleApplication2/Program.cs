using System;
using ConsoleApplication2.Domain;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new Controller(new AccountRepository());
            var account = client.Get(1);
            Console.WriteLine(account.Name);
            Console.Read();
        }
    }
}
