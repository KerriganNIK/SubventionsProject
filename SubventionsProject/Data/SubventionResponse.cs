using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubventionsProject.Data
{
    public class SubventionResponse
    {
        public int Id { get; set; }
        public int Amount { get; set; }
        public DateTime Year { get; set; }
        public OrganizationResponse Receiver { get; set; }
        public OrganizationResponse Distributor { get; set; }
    }
}
