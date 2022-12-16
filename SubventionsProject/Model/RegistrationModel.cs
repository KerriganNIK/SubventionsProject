﻿using Newtonsoft.Json;
using SubventionsProject.Data;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;

namespace SubventionsProject
{
    public class RegistrationModel
    {
        private int reseiverId;
        private int amount;
        private int year;

        public RegistrationModel(int reseiverId, int amount, int year)
        {
            this.reseiverId = reseiverId;
            this.amount = amount;
            this.year = year;
        }

        public void AddSubvention()
        {
            CreateSubventionRequest CreateSubventionRequest = new CreateSubventionRequest(reseiverId, amount, year);

            var json = JsonConvert.SerializeObject(CreateSubventionRequest);
            var createSubvetionResponse = DataBase.Client.PostAsync(DataBase.Uri + "/subventions", new StringContent(json, Encoding.UTF8, "Application/json")).Result;

            if (createSubvetionResponse.IsSuccessStatusCode)
            {
                var deserializedResponse = JsonConvert.DeserializeObject<CreateSubventionResponse>(createSubvetionResponse.Content.ReadAsStringAsync().Result);
            }
            else
            {
                MessageBox.Show(createSubvetionResponse.Content.ReadAsStringAsync().Result);
            }

            MainForm mainForm = MainForm.Initialize();
            mainForm.UpdateData();
        }
    }
}
