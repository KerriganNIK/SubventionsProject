using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubventionsProject.Data
{
    public class GetSubventionResponse
    {
        public int Id { get; set; }
        public int Amount { get; set; }
        public DateTime Year { get; set; }
        public GetOrganizationResponse Receiver { get; set; }
        public GetOrganizationResponse Distributor { get; set; }
        public ICollection<TransactionResponse> Transactions { get; set; }
    }
}
