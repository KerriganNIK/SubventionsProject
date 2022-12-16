using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubventionsProject.Data
{
    public class DistributeSubventionRequest
    {
        public int Amount { get; }
        public int Year { get; }
        public int ReceiverId { get; }

        public DistributeSubventionRequest(int amount, int year, int receiverId)
        {
            Amount = amount;
            Year = year;
            ReceiverId = receiverId;
        }
    }

    public class DistributeSubventionResponse
    {
        public int Id;
    }
}
