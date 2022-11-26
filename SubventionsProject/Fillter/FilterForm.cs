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
    public partial class FilterForm : MaterialForm
    {
        private FilterModel filterModel;

        public FilterForm()
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
            filterModel = new FilterModel(comboBox1.Text, comboBox2.Text, comboBox3.Text, comboBox4.Text, comboBox5.Text, dateTimePicker1.Text.ToString());
            filterModel.FilterDate();
            Close();
        }
    }
}
