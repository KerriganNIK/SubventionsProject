using Newtonsoft.Json;
using NLog;
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
        private const Boolean Successfully = true;
        private const Boolean Successless = false;
        private static Logger Logger = LogManager.GetCurrentClassLogger();

        public TransactionModel(int amount, DateTime date, int subventionId)
        {
            Amount = amount;
            Date = date;
            SubventionId = subventionId;
        }

        public bool AddTransaction()
        {
            var createTransactionRequest = new CreateTransactionRequest(Amount, Date);
            var serializedRequest = JsonConvert.SerializeObject(createTransactionRequest);
            var requestContent = new StringContent(serializedRequest, Encoding.UTF8, "Application/json");
            var createTransactionResponse = DataBase.Client.PostAsync(DataBase.Uri + $"/subventions/{SubventionId}/transactions", requestContent).Result;

            if (createTransactionResponse.IsSuccessStatusCode)
            {
                Logger.Debug("Добавляет транзакцию");
                return Successfully;
            }
            else
            {
                MessageBox.Show(HttpErrorHelper.GetErrorMessage(createTransactionResponse));
                Logger.Warn($"{HttpErrorHelper.GetErrorMessage(createTransactionResponse)}");
                return Successless;
            }
        }
    }
}
