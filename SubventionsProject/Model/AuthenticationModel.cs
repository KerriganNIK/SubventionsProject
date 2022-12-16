using Newtonsoft.Json;
using SubventionsProject.Data;
using SubventionsProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SubventionsProject
{
    public class AuthenticationModel
    {
        private AuthenticationForm authorization;
        private const Boolean Admin = true;
        private const Boolean User = false;
        public const string UserCheck = "User";
        public const string AdminCheck = "Distributor";
        private MainForm mainForm;
        public static string TypeUser { get; set; }
        public static int Organization { get; set; }

        public AuthenticationModel(AuthenticationForm authorization)
        {
            this.authorization = authorization;
        }

        public void AuthorizeUser(string login, string password)
        {
            LoginRequest loginRequest = new LoginRequest(login, password);
            string json = JsonConvert.SerializeObject(loginRequest);

            var loginResponse = DataBase.Client.PostAsync(DataBase.Uri + "/auth/login", new StringContent(json, Encoding.UTF8, "application/json")).Result;

            if (loginResponse.IsSuccessStatusCode)
            {
                LoginResponse deserializedResponse = JsonConvert.DeserializeObject<LoginResponse>(loginResponse.Content.ReadAsStringAsync().Result);

                DataBase.Client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", deserializedResponse.Token);

                if (deserializedResponse.User.RoleName == AdminCheck)
                {
                    OpenMain(Admin, AdminCheck, deserializedResponse.User.OrganizationId);
                }
                else
                {
                    OpenMain(User, UserCheck, deserializedResponse.User.OrganizationId);
                }
            } 
            else
            {
                MessageBox.Show(HttpErrorHelper.GetErrorMessage(loginResponse));
            }
        }

        public void OpenMain(Boolean check, string type, int organizationId)
        {
            TypeUser = type;
            Organization = organizationId;

            mainForm = MainForm.Initialize();
            authorization.Hide();
            mainForm.OpenMainForm(check);
        }
    }
}