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
        public const string UserCheck = "0";
        public const string AdminCheck = "1";
        private MainForm mainForm;
        public static string TypeUser { get; set; }
        public static string Oranization { get; set; }

        public AuthorizationModel(AuthorizationForm authorization)
        {
            this.authorization = authorization;
        }

        public void AuthoriztionUser(string login, string password)
        {
            #region BaseDataLogic
            //DataBase.OpenConnection();

            //MySqlCommand command = new MySqlCommand("SELECT user.id_user, type.is_admin, user.fk_organization FROM user INNER JOIN organization ON user.fk_organization = organization.id_organization INNER JOIN type ON organization.fk_type = type.id_type WHERE user.name = @loginUser AND user.password = @passwordUser", DataBase.GetConnection());
            //command.Parameters.Add("@loginUser", MySqlDbType.VarChar).Value = login;
            //command.Parameters.Add("@passwordUser", MySqlDbType.VarChar).Value = password;

            //MySqlDataReader reader = command.ExecuteReader();

            //DataBase.CloseConnection();
            #endregion

            List<string> list = new List<string>();

            while (reader.Read())
            {
                list.Add(reader[0].ToString());
                list.Add(reader[1].ToString());
                list.Add(reader[2].ToString());
            }

            TypeUser = list[1];
            Oranization = list[2];

            if (list[0] != null && list[1] == AdminCheck)
            {
                OpenMain(Admin);
            }
            else if (list[0] != null && list[1] == UserCheck)
            {
                OpenMain(User);
            }
            else
            {
                MessageBox.Show("Не верный логин или пароль!");
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
