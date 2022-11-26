using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SubventionsProject
{
    public partial class AuthorizationForm : MaterialForm
    {
        private AuthorizationModel authorization;

        public AuthorizationForm()
        {
            InitializeComponent();

            #region Design
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            #endregion

            PasswordText.PasswordChar = '*';

            authorization = new AuthorizationModel(this);
        }

        private void CloseButton_Click(object sender, EventArgs e) => Close();

        private void OkButton_Click(object sender, EventArgs e)
        {
            if (LoginText.Text != "" && PasswordText.Text != "")
            {
                authorization.AuthoriztionUser(LoginText.Text, PasswordText.Text);
            }
            else
            {
                MessageBox.Show("Не все поля заполнены!");
            }
        }
    }
}
