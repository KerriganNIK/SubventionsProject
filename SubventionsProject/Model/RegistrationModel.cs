using Newtonsoft.Json;
using SubventionsProject.Data;
using SubventionsProject.Model;
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

        public RegistrationModel(int receiverId, int amount, int year)
        {
            this.receiverId = receiverId;
            this.amount = amount;
            this.year = year;
        }

        /// <summary>
        /// Returns true if added succesfully; otherwise false.
        /// </summary>
        public bool AddSubvention()
        {
            CreateSubventionRequest CreateSubventionRequest = new CreateSubventionRequest(receiverId, amount, year);
            var json = JsonConvert.SerializeObject(CreateSubventionRequest);
            var createSubvetionResponse = DataBase.Client.PostAsync(DataBase.Uri + "/subventions", new StringContent(json, Encoding.UTF8, "Application/json")).Result;
            if (createSubvetionResponse.IsSuccessStatusCode) return true;
            else
            {
                MessageBox.Show(HttpErrorHelper.GetErrorMessage(createSubvetionResponse));
                return false;
            }
        }

        /// <summary>
        /// Returns true if distributed succesfully; otherwise false.
        /// </summary>
        public bool DistributeSubvention(string parentSubventionId)
        {
            CreateSubventionRequest CreateSubventionRequest = new CreateSubventionRequest(receiverId, amount, year);
            var json = JsonConvert.SerializeObject(CreateSubventionRequest);
            var createSubvetionResponse = DataBase.Client.PostAsync(DataBase.Uri + $"/subventions/{parentSubventionId}/distribute", new StringContent(json, Encoding.UTF8, "Application/json")).Result;
            if (createSubvetionResponse.IsSuccessStatusCode) return true;
            else
            {
                MessageBox.Show(HttpErrorHelper.GetErrorMessage(createSubvetionResponse));
                return false;
            }
        }
    }
}
