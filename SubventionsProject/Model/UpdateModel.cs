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
    internal class UpdateModel
    {
        private int amount;
        private int year;
        private int receiverId;
        private int subvetionId;
        private static Logger Logger = LogManager.GetCurrentClassLogger();
        private MainForm mainForm;

        public UpdateModel(int amount, int year, int receiverId, int subventionId)
        {
            this.amount = amount;
            this.year = year;
            this.receiverId = receiverId;
            this.subvetionId = subventionId;
        }

        public void UpdateSubvention()
        {
            mainForm = MainForm.Initialize();
            var updateSubventionRequest = new UpdateSubventionRequest(amount, year, receiverId);
            var serializedRequest = JsonConvert.SerializeObject(updateSubventionRequest);
            var requestContent = new StringContent(serializedRequest, Encoding.UTF8, "Application/json");
            var updateTransactionResponse = DataBase.Client.PutAsync(DataBase.Uri + $"/subventions/{subvetionId}", requestContent).Result;

            if (updateTransactionResponse.IsSuccessStatusCode)
            {
                Logger.Debug("Изменяет данные о субвенции");
                mainForm = MainForm.Initialize();
                mainForm.UpdateData();
            }
            else
            {
                MessageBox.Show(HttpErrorHelper.GetErrorMessage(updateTransactionResponse));
                Logger.Warn($"{HttpErrorHelper.GetErrorMessage(updateTransactionResponse)}");
            }
        }
    }
}
