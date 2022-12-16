using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubventionsProject.Data
{
    public class DistributeSubventionRequest
    {
        public int Amount;
        public int Year;
        public int ReceiverId;
    }

    public class DistributeSubventionResponse
    {
        public int Id;
    }
}
