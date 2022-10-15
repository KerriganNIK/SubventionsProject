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
        public AuthorizationForm()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            PasswordText.PasswordChar = '*';
        }

        private void CloseButton_Click(object sender, EventArgs e) => Close();

        private void OkButton_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            Condition condition = Condition.Initialize(mainForm);

            if (LoginText.Text == "Admin" && PasswordText.Text == "123")
            {
                Hide();
                condition.AdminOpen();
            }
            else if (LoginText.Text == "User" && PasswordText.Text == "123")
            {
                Hide();
                condition.UserOpen();
            }
            else
            {
                MessageBox.Show("Не правильный логин или пароль!");
            }
        }
    }
}
