using MaterialSkin;
using MaterialSkin.Controls;
using Newtonsoft.Json;
using SubventionsProject.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

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

                foreach (var items in subventionResponse)
                {
                    comboMunicipal.Items.Add(items.Distributor.Name.ToString());
                    comboGetSubvention.Items.Add(items.Receiver.Name.ToString());
                    comboSetSubvention.Items.Add(items.Distributor.Name.ToString());
                    comboYears.Items.Add(items.Year.Year.ToString());
                    comboSum.Items.Add(items.Sum.ToString());
                    comboDate.Items.Add(items.Year.ToString().Substring(0, 5));
                }

                ComboBox[] comboBoxs = { comboMunicipal, comboGetSubvention, comboSetSubvention, comboYears, comboSum, comboDate };

                for (int i = 0; i < comboBoxs.Length; i++)
                {
                    DistinctData(comboBoxs[i]);
                }
            }
        }

        private void DistinctData(ComboBox comboBox)
        {
            object[] array = comboBox.Items.OfType<string>().Distinct().ToArray();
            comboBox.Items.Clear();
            comboBox.Items.AddRange(array);
        }
    }
}
