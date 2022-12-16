using MaterialSkin;
using MaterialSkin.Controls;
using Newtonsoft.Json;
using SubventionsProject.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace SubventionsProject
{
    public partial class RegistrationCardForm : MaterialForm
    {
        private RegistrationModel registrationModel;

        public RegistrationCardForm()
        {
            InitializeComponent();

            #region Design
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            #endregion

            LoadDataComboBox();
        }

        private void CloseButton_Click(object sender, EventArgs e) => Close();

        private void OkButton_Click(object sender, EventArgs e)
        {
            if (comboReceiver.Text != "" && SumTextBox.Text != "" && dateTimePicker1.Text != "")
            {
                registrationModel = new RegistrationModel(Convert.ToInt32(comboReceiver.SelectedValue.ToString()), Convert.ToInt32(SumTextBox.Text), Convert.ToInt32(dateTimePicker1.Value.Year.ToString()));
                registrationModel.AddSubvention();
                Close();
            }
            else
            {
                MessageBox.Show("Заполните все поля!");
            }
        }

        private void LoadDataComboBox()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Id");
            dataTable.Columns.Add("Name");

            var organization = DataBase.client.GetAsync(DataBase.Uri + "/organizations").Result;

            if (organization.IsSuccessStatusCode)
            {
                var subventionResponse = JsonConvert.DeserializeObject<List<GetOrganizationResponse>>(organization.Content.ReadAsStringAsync().Result);

                foreach (var items in subventionResponse)
                {
                    DataRow dataRow = dataTable.NewRow();
                    dataRow["Id"] = items.Id.ToString();
                    dataRow["Name"] = items.Name.ToString();
                    dataTable.Rows.Add(dataRow);
                }
            }

            comboReceiver.DataSource = dataTable;
            comboReceiver.DisplayMember = "Name";
            comboReceiver.ValueMember = "Id";
        }
    }
}
