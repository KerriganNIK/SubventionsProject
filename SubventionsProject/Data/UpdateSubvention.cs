using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubventionsProject.Data
{
    internal class UpdateSubventionRequest
    {
        public int Amount { get; }
        public int Year { get; }
        public int ReceiverId { get; }

        public UpdateSubventionRequest(int amount, int year, int receiverId)
        {
            Amount = amount;
            Year = year;
            ReceiverId = receiverId;
        }
    }
}
