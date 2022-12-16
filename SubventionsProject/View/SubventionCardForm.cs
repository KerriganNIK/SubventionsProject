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
        private int subventionId;
        public SubventionCardForm(string municipality, string getSubvention, string distributorSubvention, string yearsSubvention, string amountMoney, string dateMoney, int subventionId)
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
            this.subventionId = subventionId;

            RefillTransactionTable();
            ManageUserButtons(getSubvention, dateMoney);
            LoadDataComboBox(getSubvention);
        }

        private void ButtonWrite_Click(object sender, EventArgs e)
        {
            var receiverId = Convert.ToInt32(ReceiverComboBox.SelectedValue);
            var updateModel = new UpdateModel(Convert.ToInt32(AmountText.Text), Convert.ToInt32(YearText.Text), receiverId, subventionId);
            if (updateModel.UpdateSubvention() == true)
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void SubventhionCardForm_FormClosed(object sender, FormClosedEventArgs e) => Close();

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        public void RefillTransactionTable()
        {
            if (transactionsDataGridView.Rows.Count != 0)
                transactionsDataGridView.Rows.Clear();
            var getSubventionResponse = DataBase.Client.GetAsync(DataBase.Uri + $"/subventions/{subventionId}").Result;
            if (getSubventionResponse.IsSuccessStatusCode)
            {
                var deserializedResponse = JsonConvert.DeserializeObject<GetSubventionResponse>(getSubventionResponse.Content.ReadAsStringAsync().Result);
                var numberOfRows = 0;
                foreach (var transaction in deserializedResponse.Transactions)
                {
                    transactionsDataGridView.Rows.Add();
                    transactionsDataGridView.Rows[numberOfRows].Cells[0].Value = transaction.Amount;
                    transactionsDataGridView.Rows[numberOfRows].Cells[1].Value = transaction.Date;
                    numberOfRows++;
                }
            }
            else
            {
                MessageBox.Show(HttpErrorHelper.GetErrorMessage(getSubventionResponse));
            }
        }

        public void TurnButtonsVisibility(Boolean check)
        {
            YearText.ReadOnly = check;
            AmountText.ReadOnly = check;
            distributorText.Enabled = false;
            receiverText.Visible = check;
            receiverText.Enabled = check;
            receiverText.ReadOnly = check;
            municipalityText.Enabled = false;
            DateText.ReadOnly = check;
            DateText.Enabled = check;
            DateText.Visible = check;
            dateTimePicker1.Enabled = false;
        }

        public void ManageUserButtons(string getSubvention, string dateMoney)
        {
            if (AuthenticationModel.TypeUser == AuthenticationModel.UserCheck)
            {
                ReceiverComboBox.Enabled = false;
                AddTransactionButton.Enabled = false;
                AddTransactionButton.Visible = false;
                receiverText.Text = getSubvention;
                DateText.Text = dateMoney;
                TurnButtonsVisibility(true);
            }
            else if (AuthenticationModel.TypeUser == AuthenticationModel.AdminCheck)
            {
                ReceiverComboBox.Text = getSubvention;
                dateTimePicker1.Text = dateMoney;
                TurnButtonsVisibility(false);
            }
        }

        private void AddTransactionButton_Click(object sender, EventArgs e)
        {
            new TransactionForm(subventionId).ShowDialog();
            RefillTransactionTable();
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

            ReceiverComboBox.DataSource = dataTable;
            ReceiverComboBox.DisplayMember = "Name";
            ReceiverComboBox.ValueMember = "Id";
            ReceiverComboBox.SelectedIndex = numberValue;
        }
    }
}
