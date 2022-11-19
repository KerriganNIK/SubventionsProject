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
    public partial class SubventhionCardForm : MaterialForm
    {
        public SubventhionCardForm()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void SubventhionCardForm_FormClosed(object sender, FormClosedEventArgs e) => Close();

        private void ButtonOk_Click(object sender, EventArgs e)
        {
            if(comboBox1.Text != "" && comboBox2.Text != "" && comboBox3.Text != "" && materialSingleLineTextField1.Text != "" && materialSingleLineTextField2.Text != "")
            {
                SubventionCardModel subventionCard = new SubventionCardModel(comboBox1.Text, comboBox2.Text, comboBox3.Text, materialSingleLineTextField1.Text, Convert.ToDouble(materialSingleLineTextField2.Text), dateTimePicker1.Text);
            }
            else
            {
                MessageBox.Show("Не все поля заполнены");
            }
        }

        private void ButtonCancel_Click(object sender, EventArgs e) => Close();
    }
}
