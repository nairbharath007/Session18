using AccountTransactionApp.Model;

namespace AccountTransactionApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account(101, "Name1", 10000);
            account.Deposit(7000);
            account.Withdraw(20000);

            Console.WriteLine(account.GetTransactions());
            Console.WriteLine("---------------------------");
            Console.WriteLine($"Account Balance: {account.Balance}");

        }
    }
}