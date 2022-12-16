using MaterialSkin;
using MaterialSkin.Controls;
using SubventionsProject.Model;
using SubventionsProject.View;
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
        private SubventionCardModel subventionCardModel;
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

        private void ButtonWrite_Click(object sender, EventArgs e)
        {
            //Изменение данных

            subventionCardModel = new SubventionCardModel(comboBox1.Text, comboBox2.Text, comboBox3.Text, textBox1.Text, textBox2.Text, dateTimePicker1.Text, this);
            //subventionCard.SubventionEdit();

            new UpdateModel(Convert.ToInt32(comboBox2.Text), Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox1.Text))
                .UpdateSubvention();

            Close();
        }

        private void SubventhionCardForm_FormClosed(object sender, FormClosedEventArgs e) => Close();

        private void ButtonClose_Click(object sender, EventArgs e) => Close();

        public void UpadateDataSubvention()
        {
            //Заполнить данные в dataGrid
        }

        public void TurnButtonsVisibility(Boolean check)
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
            if (AuthenticationModel.TypeUser == AuthenticationModel.UserCheck)
            {
                AddTransactionButton.Enabled = false;
                AddTransactionButton.Visible = false;
                textBox5.Text = municipality;
                textBox4.Text = getSubvention;
                textBox3.Text = distributorSubvention;
                textBox1.Text = yearsSubvention;
                textBox2.Text = amountMoney;
                //textBox6.Text = dateMoney;
                TurnButtonsVisibility(true);
            }
            else if (AuthenticationModel.TypeUser == AuthenticationModel.AdminCheck)
            {
                comboBox1.Text = municipality;
                comboBox2.Text = getSubvention;
                comboBox3.Text = distributorSubvention;
                textBox1.Text = yearsSubvention;
                textBox2.Text = amountMoney;
                //dateTimePicker1.Text = dateMoney;
                TurnButtonsVisibility(false);
            }
        }

        //private void EditButton_Click(object sender, EventArgs e)
        //{

        //}

        private void AddTransactionButton_Click(object sender, EventArgs e)
        {
            new TransactionForm().ShowDialog();
        }
    }
}
