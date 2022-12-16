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
    internal class UpdateModel
    {
        private int amount;
        private int year;
        private int receiverId;
        private int subvetionId;

        public UpdateModel(int amount, int year, int receiverId, int subventionId)
        {
            this.amount = amount;
            this.year = year;
            this.receiverId = receiverId;
            this.subvetionId = subventionId;
        }

        /// <summary>
        /// Returns true if updated succesfully; otherwise false.
        /// </summary>
        public bool UpdateSubvention()
        {
            var updateSubventionRequest = new UpdateSubventionRequest(amount, year, receiverId);
            var serializedRequest = JsonConvert.SerializeObject(updateSubventionRequest);
            var requestContent = new StringContent(serializedRequest, Encoding.UTF8, "Application/json");
            var updateTransactionResponse = DataBase.Client.PutAsync(DataBase.Uri + $"/subventions/{subvetionId}", requestContent).Result;
            if (updateTransactionResponse.IsSuccessStatusCode)
            {
                return true;
            }
            else
            {
                MessageBox.Show(HttpErrorHelper.GetErrorMessage(updateTransactionResponse));
                return false;
            }
        }
    }
}
