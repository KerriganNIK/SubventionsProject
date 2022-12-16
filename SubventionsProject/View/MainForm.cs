using MaterialSkin;
using MaterialSkin.Controls;
using Newtonsoft.Json;
using SubventionsProject.Data;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SubventionsProject
{
    public partial class MainForm : MaterialForm
    {
        private static MainForm mainForm = null;
        private RegistrationCardForm registrationCardForm;
        private FilterForm filterForm;
        private SubventionCardForm subventhionCard;
        private ExcelModel excelModel;
        private DeleteModel deleteData;

        public MainForm()
        {
            InitializeComponent();

            #region Design
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            #endregion

            CreateDataGrid();
        }

        public static MainForm Initialize()
        {
            if (mainForm == null)
                mainForm = new MainForm();

            return mainForm;
        }

        private void ExitButton_Click(object sender, EventArgs e) => Application.Restart();

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e) => Application.Exit();

        private void FilterButton_Click(object sender, EventArgs e)
        {
            filterForm = new FilterForm();
            filterForm.ShowDialog();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            registrationCardForm = new RegistrationCardForm();
            if (registrationCardForm.ShowDialog() == DialogResult.OK) UpdateData();
        }

        private void OpenButton_Click(object sender, EventArgs e)
        {
            subventhionCard = new SubventionCardForm(dataGridView1.CurrentRow.Cells[0].Value.ToString(), dataGridView1.CurrentRow.Cells[1].Value.ToString(), dataGridView1.CurrentRow.Cells[2].Value.ToString(), dataGridView1.CurrentRow.Cells[3].Value.ToString(), dataGridView1.CurrentRow.Cells[4].Value.ToString(), dataGridView1.CurrentRow.Cells[5].Value.ToString(), Convert.ToInt32(dataGridView1.CurrentRow.Cells[6].Value.ToString()));
            if (subventhionCard.ShowDialog() == DialogResult.OK) UpdateData();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (RegistryIsNotEmpty())
            {
                if (MessageBox.Show("Удалить выбранную субвенцию?", "Удаление субвенции", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    deleteData = new DeleteModel(dataGridView1.CurrentRow.Cells[6].Value.ToString());
                    if (deleteData.Delete())
                        dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
                }
            }
            else MessageBox.Show("В таблице нет записей!", "Ошибка удаления", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void OpenMainForm(Boolean check)
        {
            UpdateData();

            AddButton.Visible = check;
            AddButton.Enabled = check;
            DeleteButton.Visible = check;
            DeleteButton.Enabled = check;

            ShowDialog();
        }

        public void UpdateData()
        {
            if (RegistryIsNotEmpty())
                dataGridView1.Rows.Clear();

            var getSubventionsResponse = DataBase.Client.GetAsync(DataBase.Uri + "/subventions").Result;

            if (getSubventionsResponse.IsSuccessStatusCode)
            {
                var deserializedResponse = JsonConvert.DeserializeObject<List<GetSubventionResponse>>(getSubventionsResponse.Content.ReadAsStringAsync().Result);
                var numberOfRows = 0;

                foreach (var subvention in deserializedResponse)
                {
                    if (subvention.Distributor.Id == AuthenticationModel.OrganizationId)
                    {
                        dataGridView1.Rows.Add();
                        dataGridView1.Rows[numberOfRows].Cells[0].Value = subvention.Distributor.Name.ToString();
                        dataGridView1.Rows[numberOfRows].Cells[1].Value = subvention.Receiver.Name.ToString();
                        dataGridView1.Rows[numberOfRows].Cells[2].Value = subvention.Distributor.Name.ToString();
                        dataGridView1.Rows[numberOfRows].Cells[3].Value = subvention.Year.Year.ToString();
                        dataGridView1.Rows[numberOfRows].Cells[4].Value = subvention.Amount.ToString();
                        dataGridView1.Rows[numberOfRows].Cells[5].Value = subvention.Year;
                        dataGridView1.Rows[numberOfRows].Cells[6].Value = subvention.Id.ToString();
                        numberOfRows++;
                    }
                    else
                    {
                        continue;
                    }
                }
            }

            dataGridView1.Columns[6].Visible = false;
        }

        private void ExportButton_Click(object sender, EventArgs e)
        {
            if (RegistryIsNotEmpty())
            {
                excelModel = new ExcelModel();
                excelModel.Export();
            }
            else MessageBox.Show("Нечего экспоритровать", "Ошибка экспорта", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void CreateDataGrid()
        {
            DataGridViewTextBoxColumn Column0 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn Column1 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn Column2 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn Column3 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn Column4 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn Column5 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn Column6 = new DataGridViewTextBoxColumn();
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column0, Column1, Column2, Column3, Column4, Column5, Column6 });
            Column0.HeaderText = "Муниципальное образование";
            Column0.DataPropertyName = "Municipality";
            Column0.Width = 145;
            Column1.HeaderText = "Получатель субвенции";
            Column1.DataPropertyName = "GetSubvention";
            Column1.Width = 145;
            Column2.HeaderText = "Распределитель субвенции";
            Column2.DataPropertyName = "SetSubvention";
            Column2.Width = 145;
            Column3.HeaderText = "Год выдачи субвенции";
            Column3.DataPropertyName = "Years";
            Column3.Width = 70;
            Column4.HeaderText = "Объём субвенции";
            Column4.DataPropertyName = "Amount";
            Column5.HeaderText = "Дата получения";
            Column5.DataPropertyName = "Date";
            Column5.Width = 135;
            Column6.HeaderText = "Id субвенции";
            Column6.DataPropertyName = "Id";
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            OpenButton_Click(sender, e);
        }

        private void DistributeButton_Click(object sender, EventArgs e)
        {
            if (RegistryIsNotEmpty())
            {
                registrationCardForm = new RegistrationCardForm(dataGridView1.CurrentRow.Cells[6].Value.ToString());
                if (registrationCardForm.ShowDialog() == DialogResult.OK) UpdateData();
            }
            else MessageBox.Show("Нечего распределять", "Ошибка распределения", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private bool RegistryIsNotEmpty()
        {
            return dataGridView1.Rows.Count > 0;
        }
    }
}