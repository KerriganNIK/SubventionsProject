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

        public TransactionModel(int amount, DateTime date)
        {
            Amount = amount;
            Date = date;
        }

        public void AddTransaction()
        {
            var createTransactionRequest = new CreateTransactionRequest(Amount, Date);
            var serializedRequest = JsonConvert.SerializeObject(createTransactionRequest);
            var requestContent = new StringContent(serializedRequest, Encoding.UTF8, "Application/json");
            var createTransactionResponse = DataBase.Client.PostAsync(DataBase.Uri + "/subventions/:id/transactions", requestContent).Result;
            if (createTransactionResponse.IsSuccessStatusCode)
            {
                // по идее надо обновить датагрид с транзакциями в карточке субвенции
            }
            else
            {
                MessageBox.Show(createTransactionResponse.Content.ToString());
            }
        }
    }
}
