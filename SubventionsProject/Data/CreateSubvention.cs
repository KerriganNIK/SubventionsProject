using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubventionsProject
{
    public class CreateSubventionRequest
    {
        public int ReceiverId { get; set; }
        public int Amount { get; set; }
        public int Year { get; set; }
    }

    public class CreateSubventionResponse
    {
        public int Id { get; set; }
    }
}
