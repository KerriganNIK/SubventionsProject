using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubventionsProject.Model
{
    internal class TransactionModel
    {
        public int Amount { get; set; }
        public DateTime Date { get; set; }

        public TransactionModel(int amount, DateTime date)
        {
            Amount = amount;
            Date = date;
        }

        public void AddTransaction()
        {

        }
    }
}
