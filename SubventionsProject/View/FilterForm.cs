using MaterialSkin;
using MaterialSkin.Controls;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using NLog;
using SubventionsProject.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SubventionsProject
{
    public partial class FilterForm : MaterialForm
    {
        private FilterModel filterModel;
        private static Logger Logger = LogManager.GetCurrentClassLogger();

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

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Logger.Info("Закрывает окно фильтрации");

            Close();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            filterModel = new FilterModel(comboGetSubvention.Text, comboYears.Text, comboSum.Text, comboDate.Text);
            filterModel.FilterDate();
        }

        private void LoadDataComboBox()
        {
            var getSubventionResponse = DataBase.Client.GetAsync(DataBase.Uri + "/subventions").Result;

            Logger.Debug($"Заполняет ComboBox данными субвенций");

            if (getSubventionResponse.IsSuccessStatusCode)
            {
                var deserializedResponse = JsonConvert.DeserializeObject<List<GetSubventionResponse>>(getSubventionResponse.Content.ReadAsStringAsync().Result);

                foreach (var items in deserializedResponse)
                {
                    if (items.Distributor.Id == AuthenticationModel.OrganizationId)
                    {
                        comboGetSubvention.Items.Add(items.Receiver.Name.ToString());
                        comboYears.Items.Add(items.Year.Year.ToString());
                        comboSum.Items.Add(items.Amount.ToString());
                        comboDate.Items.Add(items.Transactions.Count > 0
                            ? items.Transactions.Last().Date.ToShortDateString()
                            : "—");
                    }
                    else
                    {
                        continue;
                    }
                }

                ComboBox[] comboBoxs = { comboGetSubvention, comboYears, comboSum, comboDate };

                Logger.Debug("Убирает повторяющие данные субвенций");
                for (int i = 0; i < comboBoxs.Length; i++)
                {
                    DistinctData(comboBoxs[i]);
                }
            }
        }

        private void DistinctData(ComboBox comboBox)
        {
            var array = comboBox.Items
                .OfType<string>()
                .Distinct()
                .OrderBy(x => x)
                .ToArray();
            comboBox.Items.Clear();
            comboBox.Items.AddRange(array);
        }

        private void FilterForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Logger.Info("Закрывает окно фильтрации");

            Close();
        }
    }
}
