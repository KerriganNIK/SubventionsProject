using MaterialSkin;
using MaterialSkin.Controls;
using Newtonsoft.Json;
using SubventionsProject.Model;
using SubventionsProject.View;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using SubventionsProject.Data;


namespace SubventionsProject
{
    public partial class SubventionCardForm : MaterialForm
    {
        private SubventionCardModel subventionCardModel;
        private int idSubvention;
        public SubventionCardForm(string municipality, string getSubvention, string distributorSubvention, string yearsSubvention, string amountMoney, string dateMoney, int idSubvention)
        {
            InitializeComponent();

            #region Design
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            #endregion

            municipalityText.Text = municipality;
            distributorText.Text = distributorSubvention;
            YearText.Text = yearsSubvention;
            AmountText.Text = amountMoney;
            this.idSubvention = idSubvention;

            UpadateDataSubvention();
            UserButton(getSubvention, dateMoney);
            LoadDataComboBox(getSubvention);
        }

        private void ButtonWrite_Click(object sender, EventArgs e)
        {
            //Изменение данных

            subventionCardModel = new SubventionCardModel(municipalityText.Text, getSubventionComboBox.Text, distributorText.Text, YearText.Text, AmountText.Text, dateTimePicker1.Text, this);
            //subventionCard.SubventionEdit();

            new UpdateModel(Convert.ToInt32(getSubventionComboBox.Text), Convert.ToInt32(AmountText.Text), Convert.ToInt32(YearText.Text))
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
            YearText.ReadOnly = check;
            AmountText.ReadOnly = check;
            distributorText.Enabled = false;
            getSubventionText.Visible = check;
            getSubventionText.Enabled = check;
            getSubventionText.ReadOnly = check;
            municipalityText.Enabled = false;
            DateText.ReadOnly = check;
            DateText.Enabled = check;
            DateText.Visible = check;
            dateTimePicker1.Enabled = false;
        }

        public void UserButton(string getSubvention, string dateMoney)
        {
            if (AuthenticationModel.TypeUser == AuthenticationModel.UserCheck)
            {
                getSubventionComboBox.Enabled = false;
                AddTransactionButton.Enabled = false;
                AddTransactionButton.Visible = false;
                getSubventionText.Text = getSubvention;
                DateText.Text = dateMoney;
                TurnButtonsVisibility(true);
            }
            else if (AuthenticationModel.TypeUser == AuthenticationModel.AdminCheck)
            {
                getSubventionComboBox.Text = getSubvention;
                dateTimePicker1.Text = dateMoney;
                TurnButtonsVisibility(false);
            }
        }

        private void AddTransactionButton_Click(object sender, EventArgs e)
        {
            new TransactionForm().ShowDialog();
        }

        private void LoadDataComboBox(string getSubvention)
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Id");
            dataTable.Columns.Add("Name");
            int numberValue = 0;

            var GetOrganizationResponse = DataBase.Client.GetAsync(DataBase.Uri + "/organizations").Result;

            if (GetOrganizationResponse.IsSuccessStatusCode)
            {
                var deserializedResponse = JsonConvert.DeserializeObject<List<GetOrganizationResponse>>(GetOrganizationResponse.Content.ReadAsStringAsync().Result);

                foreach (var items in deserializedResponse)
                {
                    DataRow dataRow = dataTable.NewRow();
                    dataRow["Id"] = items.Id.ToString();
                    dataRow["Name"] = items.Name.ToString();
                    dataTable.Rows.Add(dataRow);
                }

                foreach (var items in deserializedResponse)
                {
                    if (items.Name.ToString() == getSubvention)
                        break;

                    numberValue++;
                }
            }

            getSubventionComboBox.DataSource = dataTable;
            getSubventionComboBox.DisplayMember = "Name";
            getSubventionComboBox.ValueMember = "Id";
            getSubventionComboBox.SelectedIndex = numberValue;
        }
    }
}
