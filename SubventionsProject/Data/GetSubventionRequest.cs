using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubventionsProject
{
    public class GetSubventionRequest
    {
        public int ReceiverId { get; set; }
        public int Sum { get; set; }
        public int Year { get; set; }
    }
}
