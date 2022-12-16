using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubventionsProject.Data
{
    internal class UpdateSubventionRequest
    {
        public int ReceiverId { get; set; }
        public int Year { get; set; }
        public int Amount { get; set; }
    }
}
