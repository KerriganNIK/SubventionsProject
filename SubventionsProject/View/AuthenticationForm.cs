﻿using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Windows.Forms;

namespace SubventionsProject
{
    public partial class AuthenticationForm : MaterialForm
    {
        private AuthenticationModel authorization;

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
        }

        private void CloseButton_Click(object sender, EventArgs e) => Close();

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

        private void ShowPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            TurnPasswordVisibility();
        }

        private void TurnPasswordVisibility()
        {
            bool isChecked = ShowPasswordCheckBox.Checked;
            PasswordText.UseSystemPasswordChar = !isChecked;
        }
    }
}
