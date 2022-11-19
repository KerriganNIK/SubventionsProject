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
    public partial class RegistrationCardForm : MaterialForm
    {
        private RegistrationModel registrationModel;

        public RegistrationCardForm()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void CloseButton_Click(object sender, EventArgs e) => Close();

        private void OkButton_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != "" && comboBox2.Text != "" && comboBox3.Text != "" && dateTimePicker1.Text != "" && materialSingleLineTextField1.Text != "" && materialSingleLineTextField2.Text != "")
            {
                registrationModel = new RegistrationModel(comboBox1.Text, comboBox2.Text, comboBox3.Text, materialSingleLineTextField1.Text, Convert.ToDouble(materialSingleLineTextField2.Text), dateTimePicker1.Text);
            }
            else
            {
                MessageBox.Show("Заполните все поля!");
            }
            Close();
        }
    }
}
