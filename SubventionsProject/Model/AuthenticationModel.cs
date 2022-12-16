using Newtonsoft.Json;
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
        public const string UserCheck = "0";
        public const string AdminCheck = "Distributor";
        private MainForm mainForm;
        public static string TypeUser { get; set; }
        public static string Oranization { get; set; }

        public AuthenticationModel(AuthenticationForm authorization)
        {
            this.authorization = authorization;
        }

        public void AuthorizeUser(string login, string password)
        {
            LoginRequest loginRequest = new LoginRequest(login, password);
            string json = JsonConvert.SerializeObject(loginRequest);

            var result = DataBase.Client.PostAsync(DataBase.Uri + "/auth/login", new StringContent(json, Encoding.UTF8, "application/json")).Result; 

            if (result.IsSuccessStatusCode)
            {
                LoginResponse resp = JsonConvert.DeserializeObject<LoginResponse>(result.Content.ReadAsStringAsync().Result);

                DataBase.Client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", resp.Token);

                if (resp.User.RoleName == AdminCheck)
                {
                    TypeUser = AdminCheck;
                    OpenMain(Admin);
                }
                //else if (list[0] != null && list[1] == UserCheck)
                //{
                //    TypeUser = UserCheck;
                //    OpenMain(User);
                //}
            } 
            else
            {
                MessageBox.Show("Неверный логин или пароль!");
            }
        }

        public void OpenMain(Boolean check)
        {
            mainForm = MainForm.Initialize();
            authorization.Hide();
            mainForm.OpenMainForm(check);
        }
    }
}