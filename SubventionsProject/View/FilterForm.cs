using MaterialSkin;
using MaterialSkin.Controls;
using Newtonsoft.Json;
using SubventionsProject.Data;
using System;
using System.Collections.Generic;

namespace SubventionsProject
{
    public partial class FilterForm : MaterialForm
    {
        private FilterModel filterModel;

        public FilterForm()
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
            filterModel = new FilterModel(comboMunicipal.Text, comboGetSubvention.Text, comboSetSubvention.Text, comboYears.Text, comboSum.Text, comboDate.Text);
            filterModel.FilterDate();
            Close();
        }

        private void LoadDataComboBox()
        {
            var subvention = DataBase.client.GetAsync(DataBase.Url + "/subventions").Result;

            if (subvention.IsSuccessStatusCode)
            {
                var subventionResponse = JsonConvert.DeserializeObject<List<SubventionResponse>>(subvention.Content.ReadAsStringAsync().Result);

                foreach (var imtems in subventionResponse)
                {
                    comboSum.Items.Add(imtems.Sum.ToString());
                    comboDate.Items.Add(imtems.Year.ToString());
                }
            }
        }
    }
}
