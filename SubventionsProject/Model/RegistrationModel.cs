using Newtonsoft.Json;
using SubventionsProject.Data;
using SubventionsProject.Model;
using System;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;

namespace SubventionsProject
{
    public class RegistrationModel
    {
        private int receiverId;
        private int amount;
        private int year;
        private const Boolean Successfully = true;
        private const Boolean Successless = false;
        private MainForm mainForm;
        public RegistrationModel(int receiverId, int amount, int year)
        {
            this.receiverId = receiverId;
            this.amount = amount;
            this.year = year;
        }

        public bool AddSubvention()
        {
            CreateSubventionRequest CreateSubventionRequest = new CreateSubventionRequest(receiverId, amount, year);
            var json = JsonConvert.SerializeObject(CreateSubventionRequest);
            var createSubvetionResponse = DataBase.Client.PostAsync(DataBase.Uri + "/subventions", new StringContent(json, Encoding.UTF8, "Application/json")).Result;

            if (createSubvetionResponse.IsSuccessStatusCode)
            {
                mainForm = MainForm.Initialize();
                mainForm.UpdateData();
                return Successfully;
            }
            else
            {
                MessageBox.Show(HttpErrorHelper.GetErrorMessage(createSubvetionResponse));
                return Successless;
            }
        }

        public bool DistributeSubvention(string parentSubventionId)
        {
            CreateSubventionRequest CreateSubventionRequest = new CreateSubventionRequest(receiverId, amount, year);
            var json = JsonConvert.SerializeObject(CreateSubventionRequest);
            var createSubvetionResponse = DataBase.Client.PostAsync(DataBase.Uri + $"/subventions/{parentSubventionId}/distribute", new StringContent(json, Encoding.UTF8, "Application/json")).Result;

            if (createSubvetionResponse.IsSuccessStatusCode)
            {
                mainForm = MainForm.Initialize();
                mainForm.UpdateData();
                return Successfully;
            }
            else
            {
                MessageBox.Show(HttpErrorHelper.GetErrorMessage(createSubvetionResponse));
                return Successless;
            }
        }
    }
}
