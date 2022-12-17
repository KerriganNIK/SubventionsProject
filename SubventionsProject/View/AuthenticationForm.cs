using MaterialSkin;
using MaterialSkin.Controls;
using Microsoft.Extensions.Logging;
using NLog;
using System;
using System.Windows.Forms;

namespace SubventionsProject
{
    public partial class AuthenticationForm : MaterialForm
    {
        private AuthenticationModel authorization;
        private static Logger Logger = LogManager.GetCurrentClassLogger();

        public AuthenticationForm()
        {
            InitializeComponent();

            #region Design
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            #endregion

            TurnPasswordVisibility();

            authorization = new AuthenticationModel(this);

            Logger.Info("Приложение запущено");
        }

        private void CloseButton_Click(object sender, EventArgs e) => Close();
        private void ShowPasswordCheckBox_CheckedChanged(object sender, EventArgs e) => TurnPasswordVisibility();

        private void OkButton_Click(object sender, EventArgs e)
        {
            if (LoginText.Text != "" && PasswordText.Text != "")
            {
                authorization.AuthorizeUser(LoginText.Text, PasswordText.Text);
            }
            else
            {
                MessageBox.Show("Не все поля заполнены!");
            }
        }

        private void TurnPasswordVisibility()
        {
            bool isChecked = ShowPasswordCheckBox.Checked;
            PasswordText.UseSystemPasswordChar = !isChecked;
        }

        private void Button_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (PasswordText.Text.Length > 0)
                {
                    OkButton_Click(sender, e);
                }
                else
                {
                    PasswordText.Focus();
                    PasswordText.SelectAll();
                }
            }
        }
    }
}
