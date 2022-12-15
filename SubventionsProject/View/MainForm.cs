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
        private RegistrationCardForm registration;
        private FilterForm filterForm;
        private SubventionCardForm subventhionCard;
        private ExcelModel excelModel;
        private DeleteDataModel deleteData;

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
            filterForm = new FilterForm();
        }

        public static MainForm Initialize()
        {
            if (mainForm == null)
                mainForm = new MainForm();

            return mainForm;
        }

        private void ExitButton_Click(object sender, EventArgs e) => Application.Restart();

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e) => Application.Exit();

        private void FillterButton_Click(object sender, EventArgs e) => filterForm.ShowDialog();

        private void AddButton_Click(object sender, EventArgs e)
        {
            registration = new RegistrationCardForm();
            registration.ShowDialog();
        }

        private void OpenButton_Click(object sender, EventArgs e)
        {
            subventhionCard = new SubventionCardForm(dataGridView1.CurrentRow.Cells[0].Value.ToString(), dataGridView1.CurrentRow.Cells[1].Value.ToString(), dataGridView1.CurrentRow.Cells[2].Value.ToString(), dataGridView1.CurrentRow.Cells[3].Value.ToString(), dataGridView1.CurrentRow.Cells[4].Value.ToString()/*, dataGridView1.CurrentRow.Cells[5].Value.ToString()*/);
            subventhionCard.ShowDialog();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Удалить выбранную субвенцию?", "Удаление субвенции", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                deleteData = new DeleteDataModel(dataGridView1.CurrentRow.Cells[6].Value.ToString());
                deleteData.Delete();
            }
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
            if (dataGridView1.Rows.Count != 0)
                dataGridView1.Rows.Clear();

            var subvention = DataBase.client.GetAsync(DataBase.Uri + "/subventions").Result;

            if (subvention.IsSuccessStatusCode)
            {
                var subventionResponse = JsonConvert.DeserializeObject<List<SubventionResponse>>(subvention.Content.ReadAsStringAsync().Result);

                for (int i = 0; i < subventionResponse.Count; i++)
                {
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[i].Cells[0].Value = subventionResponse[i].Distributor.Name.ToString();
                    dataGridView1.Rows[i].Cells[1].Value = subventionResponse[i].Receiver.Name.ToString();
                    dataGridView1.Rows[i].Cells[2].Value = subventionResponse[i].Distributor.Name.ToString();
                    dataGridView1.Rows[i].Cells[3].Value = subventionResponse[i].Year.Year.ToString();   
                    dataGridView1.Rows[i].Cells[4].Value = subventionResponse[i].Sum.ToString();
                    dataGridView1.Rows[i].Cells[5].Value = subventionResponse[i].Year.ToString().Substring(0, 5);
                    dataGridView1.Rows[i].Cells[6].Value = subventionResponse[i].Id.ToString();
                }
            }

            dataGridView1.Columns[6].Visible = false;
        }

        private void ExportButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                excelModel = new ExcelModel();
                excelModel.Export();
            }
        }

        private void CreateDataGrid()
        {
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
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
            Column1.HeaderText = "Получатель субвенции";
            Column1.DataPropertyName = "GetSubvention";
            Column2.HeaderText = "Распределитель субвенции";
            Column2.DataPropertyName = "SetSubvention";
            Column3.HeaderText = "Год выдачи субвенции";
            Column3.DataPropertyName = "Years";
            Column4.HeaderText = "Объём субвенции";
            Column4.DataPropertyName = "Sum";
            Column5.HeaderText = "Дата получения";
            Column5.DataPropertyName = "Date";
            Column6.HeaderText = "Id субвенции";
            Column6.DataPropertyName = "Id";
        }
    }
}