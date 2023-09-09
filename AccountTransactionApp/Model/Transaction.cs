using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountTransactionApp.Model
{
    internal class Transaction
    {
        public string Type { get; set; }
        public DateTime? Date { get; set; }
        public double Amount { get; set; } 
        public Transaction(string type, DateTime? date, double amount)
        {
            Type = type;
            Date = date;
            Amount = amount;
        }
        public override string ToString()
        {
            return $"Transaction Type: {Type} \tDate: {Date} \tAmount: {Amount}";
        }
    }
}
