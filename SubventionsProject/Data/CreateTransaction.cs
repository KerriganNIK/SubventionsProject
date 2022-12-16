using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubventionsProject.Data
{
    public class CreateTransactionRequest
    {
        public int Amount { get; set; }
        public DateTime Date { get; set; }
    }

    public class TransactionResponse
    {
        public int Amount { get; set; }
        public DateTime Date { get; set; }
    }
}
