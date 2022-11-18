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

        public AuthorizationModel(AuthorizationForm authorization)
        {
            this.authorization = authorization;
        }

        public void AuthoriztionUser(string login, string password)
        {
            if (login == "Admin" && password == "123")
            {
                OpenMainForm(Admin);
            }
            else if (login == "User" && password == "123")
            {
                OpenMainForm(User);
            }
            else
            {
                MessageBox.Show("Не правильный логин или пароль!");
            }
        }

        public void OpenMainForm(Boolean check)
        {
            authorization.Hide();
            MainForm form = new MainForm(check);
        }
    }
}
