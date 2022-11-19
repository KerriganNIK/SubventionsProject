using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SubventionsProject
{
    public class AuthorizationModel
    {
        private AuthorizationForm authorization;
        private const Boolean Admin = true;
        private const Boolean User = false;
        private MainForm mainForm;

        public AuthorizationModel(AuthorizationForm authorization)
        {
            this.authorization = authorization;
        }

        public void AuthoriztionUser(string login, string password)
        {
            if (login == "Admin" && password == "123")
            {
                OpenMain(Admin);
            }
            else if (login == "User" && password == "123")
            {
                OpenMain(User);
            }
            else
            {
                MessageBox.Show("Не правильный логин или пароль!");
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
