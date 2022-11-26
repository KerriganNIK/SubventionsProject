using MaterialSkin;
using MaterialSkin.Controls;
using MySql.Data.MySqlClient;
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
        private SubventionCardModel subventionCard;
        private RegistrationCardForm registrationCard; //Мб удалить

        public SubventhionCardForm(string municipality, string getSubvention, string distributorSubvention, string yearsSubvention, string amountMoney/*, string dateMoney*/)
        {
            InitializeComponent();

            #region design
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            #endregion

            UpadateDataSubvention();

            UserButton(municipality, getSubvention, distributorSubvention, yearsSubvention, amountMoney/*, string dateMoney*/);
        }

        private void SubventhionCardForm_FormClosed(object sender, FormClosedEventArgs e) => Close();
        private void ButtonCancel_Click(object sender, EventArgs e) => Close();





        private void ButtonOk_Click(object sender, EventArgs e)
        {
            //Изменения данных

            subventionCard = new SubventionCardModel(comboBox1.Text, comboBox2.Text, comboBox3.Text, textBox1.Text, textBox2.Text, dateTimePicker1.Text, this);
            subventionCard.SumbventionEdit();

            Close();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            registrationCard = new RegistrationCardForm(dataGridSubvention.CurrentRow.Cells[0].Value.ToString());
            registrationCard.ShowDialog();
        }



        private void EditButton_Click(object sender, EventArgs e)
        {
            //Дописать
        }


        public void UpadateDataSubvention()
        {
            #region BaseDataLogic
            DataBase.OpenConnection();

            MySqlCommand command = new MySqlCommand("SELECT subvention.* FROM subvention", DataBase.GetConnection());

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = command;
            adapter.Fill(DataBase.dataSet, "СhildSubvention");

            DataBase.CloseConnection();
            #endregion

            dataGridSubvention.DataSource = DataBase.dataSet.Tables["СhildSubvention"];
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
