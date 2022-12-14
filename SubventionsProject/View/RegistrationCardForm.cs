using MaterialSkin;
using MaterialSkin.Controls;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using NLog;
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
        private string parentSubventionId;
        private string parentOrganizationId;
        private static Logger Logger = LogManager.GetCurrentClassLogger();


        public RegistrationCardForm(string parentSubventionId = null, string parentOrganizationId = null)
        {
            InitializeComponent();

            #region Design
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            #endregion

            this.parentSubventionId = parentSubventionId;
            this.parentOrganizationId = parentOrganizationId;

            if (parentSubventionId == null)
            {
                Text = "Создание субвенции верхнего уровня";
            }
            else
            {
                Text = "Распределение субвенции";
            }

            LoadDataComboBox();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Logger.Info("Окно добавления субвенций закрыто");

            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            if (comboReceiver.Text != "" && AmountTextBox.Text != "" && YearTextbox.Text != "")
            {
                registrationModel = new RegistrationModel(Convert.ToInt32(comboReceiver.SelectedValue.ToString()), Convert.ToInt32(AmountTextBox.Text), Convert.ToInt32(YearTextbox.Text.ToString()));

                if (parentSubventionId == null)
                {
                    if (registrationModel.AddSubvention())
                    {
                        DialogResult = DialogResult.OK;
                        Close();

                        Logger.Debug("Добавляет субвеницию верхнего уровня");
                    }
                }
                else
                {
                    if (registrationModel.DistributeSubvention(parentSubventionId))
                    {
                        DialogResult = DialogResult.OK;
                        Close();

                        Logger.Debug("Распределяет субвенцию");
                    }
                }
            }
            else
            {
                MessageBox.Show("Заполните все поля!");

                Logger.Warn("Не все поля заполнены");
            }
        }

        private void LoadDataComboBox()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Id");
            dataTable.Columns.Add("Name");

            var GetOrganizationResponse = DataBase.Client.GetAsync(DataBase.Uri + $"/organizations?parentOrganizationId={parentOrganizationId}").Result;

            if (GetOrganizationResponse.IsSuccessStatusCode)
            {
                var deserializedResponse = JsonConvert.DeserializeObject<List<GetOrganizationResponse>>(GetOrganizationResponse.Content.ReadAsStringAsync().Result);

                foreach (var organization in deserializedResponse)
                {
                    DataRow dataRow = dataTable.NewRow();
                    dataRow["Id"] = organization.Id.ToString();
                    dataRow["Name"] = organization.Name.ToString();
                    dataTable.Rows.Add(dataRow);
                }
            }

            comboReceiver.DataSource = dataTable;
            comboReceiver.DisplayMember = "Name";
            comboReceiver.ValueMember = "Id";

            Logger.Debug($"Заполняет ComboBox данными организаций, всего доступно: {comboReceiver.Items.Count}");
        }

        private void RegistrationCardForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Logger.Info("Окно добавления субвенций закрыто");

            Close();
        }
    }
}
