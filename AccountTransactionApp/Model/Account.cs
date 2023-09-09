using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountTransactionApp.Model
{
    internal class Account
    {
        public int AccountNumber { get; set; }
        public string Name { get; set; }
        public double Balance { get; set; }
        List<Transaction> transactionList = new List<Transaction>();

        public Account(int accountNumber, string name, double balance) 
        {
            AccountNumber = accountNumber;
            Name = name;    
            Balance = balance;
            transactionList.Add(new Transaction ("O", DateTime.Now,balance));
        }

        public void Deposit(double amount)
        {
            Balance += amount;
            transactionList.Add(new Transaction("D", DateTime.Now, amount));

        }
        public void Withdraw(double amount)
        {
            Balance -= amount;
            transactionList.Add(new Transaction("W", DateTime.Now, amount));

        }
        public string GetTransactions()
        {
            string transactions = "";
            foreach (Transaction transaction in transactionList)
            {
                transactions += transaction.ToString()+ "\n";

            }
            return transactions;
        }
    }
}

