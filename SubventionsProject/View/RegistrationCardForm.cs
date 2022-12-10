using MaterialSkin;
using MaterialSkin.Controls;
using Newtonsoft.Json;
using SubventionsProject.Data;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SubventionsProject
{
    public partial class RegistrationCardForm : MaterialForm
    {
        private RegistrationModel registrationModel;

        public RegistrationCardForm(string subventionId)
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
            //if (comboReceiver.Text != "" && SumTextBox.Text != "" && dateTimePicker1.Text != "")
            //{
            //    //registrationModel = new RegistrationModel();
            //    //registrationModel.AddSubvention();
            //    //Close();
            //}
            //else
            //{
            //    MessageBox.Show("Заполните все поля!");
            //}

            MessageBox.Show(comboReceiver.SelectedValue.ToString());
        }

        private void LoadDataComboBox()
        {
            var organization = DataBase.client.GetAsync(DataBase.Url + "/organizations").Result;

            if (organization.IsSuccessStatusCode)
            {
                var subventionResponse = JsonConvert.DeserializeObject<List<OrganizationResponse>>(organization.Content.ReadAsStringAsync().Result);
                
                foreach (var items in subventionResponse)
                {
                    comboReceiver.Items.Add(items.Name);
                    comboReceiver.ValueMember = items.Id.ToString();
                }
            }
        }
    }
}
