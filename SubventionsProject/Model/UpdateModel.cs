using Newtonsoft.Json;
using SubventionsProject.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace SubventionsProject.Model
{
    internal class UpdateModel
    {
        private int reseiverId;
        private int year;
        private int amount;

        public UpdateModel(int reseiverId, int amount, int year)
        {
            this.reseiverId = reseiverId;
            this.amount = amount;
            this.year = year;
        }

        public void UpdateSubvention()
        {
            UpdateSubventionRequest updateSubventionRequest = new UpdateSubventionRequest()
            {
                ReceiverId = reseiverId,
                Year = year,
                Amount = amount
            };
            var serializedRequest = JsonConvert.SerializeObject(updateSubventionRequest);
            var request = new HttpRequestMessage(new HttpMethod("PATCH"), DataBase.Uri + "/subventions/:id")
            {
                Content = new StringContent(serializedRequest, Encoding.UTF8, "Application/json")
            };
            var response = DataBase.Client.SendAsync(request);
        }
    }
}
