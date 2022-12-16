using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubventionsProject
{
    public class CreateSubventionRequest
    {
        public int ReceiverId { get; }
        public int Amount { get; }
        public int Year { get; }

        public CreateSubventionRequest(int receiverId, int amount, int year)
        {
            ReceiverId = receiverId;
            Amount = amount;
            Year = year;
        }
    }

    public class CreateSubventionResponse
    {
        public int Id { get; set; }
    }
}
