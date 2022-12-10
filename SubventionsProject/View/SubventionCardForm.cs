using MaterialSkin;
using MaterialSkin.Controls;
using SubventionsProject.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SubventionsProject
{
    public partial class SubventionCardForm : MaterialForm
    {
        private SubventionCardModel subventionCard;
        public SubventionCardForm(string municipality, string getSubvention, string distributorSubvention, string yearsSubvention, string amountMoney/*, string dateMoney*/)
        {
            InitializeComponent();

            #region Design
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            #endregion

            UpadateDataSubvention();

            UserButton(municipality, getSubvention, distributorSubvention, yearsSubvention, amountMoney/*, string dateMoney*/);
        }

        private void ButtonOk_Click(object sender, EventArgs e)
        {
            //Изменение данных

            subventionCard = new SubventionCardModel(comboBox1.Text, comboBox2.Text, comboBox3.Text, textBox1.Text, textBox2.Text, dateTimePicker1.Text, this);
            subventionCard.SumbventionEdit();

            Close();
        }

        private void SubventhionCardForm_FormClosed(object sender, FormClosedEventArgs e) => Close();

        private void ButtonCancel_Click(object sender, EventArgs e) => Close();

        public void UpadateDataSubvention()
        {
            //Заполнить данные в dataGrid
        }

        public void ButtonVisible(Boolean check)
        {
            textBox1.ReadOnly = check;
            textBox2.ReadOnly = check;
            textBox3.Visible = check;
            textBox3.Enabled = check;
            textBox3.ReadOnly = check;
            textBox4.Visible = check;
            textBox4.Enabled = check;
            textBox4.ReadOnly = check;
            textBox5.Visible = check;
            textBox5.Enabled = check;
            textBox5.ReadOnly = check;
            textBox6.ReadOnly = check;
            textBox6.Enabled = check;
            textBox6.Visible = check;
        }

        public void UserButton(string municipality, string getSubvention, string distributorSubvention, string yearsSubvention, string amountMoney/*, string dateMoney*/)
        {
            if (AuthorizationModel.TypeUser == AuthorizationModel.UserCheck)
            {
                AddButton.Enabled = false;
                AddButton.Visible = false;
                EditButton.Visible = false;
                EditButton.Enabled = false;
                textBox5.Text = municipality;
                textBox4.Text = getSubvention;
                textBox3.Text = distributorSubvention;
                textBox1.Text = yearsSubvention;
                textBox2.Text = amountMoney;
                //textBox6.Text = dateMoney;
                ButtonVisible(true);
            }
            else if (AuthorizationModel.TypeUser == AuthorizationModel.AdminCheck)
            {
                comboBox1.Text = municipality;
                comboBox2.Text = getSubvention;
                comboBox3.Text = distributorSubvention;
                textBox1.Text = yearsSubvention;
                textBox2.Text = amountMoney;
                //dateTimePicker1.Text = dateMoney;
                ButtonVisible(false);
            }
        }
    }
}
