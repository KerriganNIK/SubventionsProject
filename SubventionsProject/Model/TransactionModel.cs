using Newtonsoft.Json;
using SubventionsProject.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SubventionsProject.Model
{
    internal class TransactionModel
    {
        public int Amount { get; set; }
        public DateTime Date { get; set; }
        public int SubventionId { get; set; }

        public TransactionModel(int amount, DateTime date, int subventionId)
        {
            Amount = amount;
            Date = date;
            SubventionId = subventionId;
        }

        /// <summary>
        /// Returns true if added succesfully; otherwise false.
        /// </summary>
        public bool AddTransaction()
        {
            var createTransactionRequest = new CreateTransactionRequest(Amount, Date);
            var serializedRequest = JsonConvert.SerializeObject(createTransactionRequest);
            var requestContent = new StringContent(serializedRequest, Encoding.UTF8, "Application/json");
            var createTransactionResponse = DataBase.Client.PostAsync(DataBase.Uri + $"/subventions/{SubventionId}/transactions", requestContent).Result;
            if (createTransactionResponse.IsSuccessStatusCode)
            {
                return true;
            }
            else
            {
                MessageBox.Show(HttpErrorHelper.GetErrorMessage(createTransactionResponse));
                return false;
            }
        }
    }
}
