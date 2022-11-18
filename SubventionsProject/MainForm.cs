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
    public partial class MainForm : MaterialForm
    {
        public MainForm(Boolean check)
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            AddButton.Visible = check;
            AddButton.Enabled = check;
            DeleteButton.Visible = check;
            DeleteButton.Enabled = check;
            OpenButton.Visible = check;
            OpenButton.Enabled = check;

            ShowDialog();
        }

        private void ExitButton_Click(object sender, EventArgs e) => Application.Restart();

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e) => Application.Exit();

        private void AddButton_Click(object sender, EventArgs e)
        {
            //RegistrationCardForm registration = new RegistrationCardForm();
            //registration.ShowDialog();
        }

        private void FillterButton_Click(object sender, EventArgs e)
        {
            //FilterForm filterForm = new FilterForm();
            //filterForm.ShowDialog();
        }
    }
}
