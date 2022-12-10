﻿using Newtonsoft.Json;
using SubventionsProject.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
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
            GetSubventionRequest getSubventionRequest = new GetSubventionRequest()
            {
                ReceiverId = reseiverId,
                Amount = amount,
                Year = year,
            };

            var json = JsonConvert.SerializeObject(getSubventionRequest);
            var response = DataBase.client.PostAsync(DataBase.Url + "/subventions", new StringContent(json, Encoding.UTF8, "Application/json")).Result;

            if (response.IsSuccessStatusCode)
            {
                var subventionResponse = JsonConvert.DeserializeObject<Response>(response.Content.ReadAsStringAsync().Result);
                MessageBox.Show(subventionResponse.ToString());
            } else
            {
                MessageBox.Show(response.Content.ReadAsStringAsync().Result);
            }

            MainForm mainForm = MainForm.Initialize();
            mainForm.UpdateData();
        }
    }
}
