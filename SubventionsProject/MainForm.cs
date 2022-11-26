using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SubventionsProject
{
    public partial class MainForm : MaterialForm
    {
        private static MainForm mainForm = null;
        private RegistrationCardForm registration;
        private FilterForm filterForm;
        private SubventhionCardForm subventhionCard;
        private ExcelModel excelModel;
        private DeleteDataModel deleteData;

        public MainForm()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

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
            //Мб по другому ID получать 

            registration = new RegistrationCardForm(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            registration.ShowDialog();
        }

        private void OpenButton_Click(object sender, EventArgs e)
        {
            subventhionCard = new SubventhionCardForm(dataGridView1.CurrentRow.Cells[0].Value.ToString(), dataGridView1.CurrentRow.Cells[1].Value.ToString(), dataGridView1.CurrentRow.Cells[2].Value.ToString(), dataGridView1.CurrentRow.Cells[3].Value.ToString(), dataGridView1.CurrentRow.Cells[4].Value.ToString()/*, dataGridView1.CurrentRow.Cells[5].Value.ToString()*/);
            subventhionCard.ShowDialog();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            deleteData = new DeleteDataModel(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            deleteData.Delete();
        }

        public void OpenMainForm(Boolean check)
        {
            UpdateData();

            AddButton.Visible = check;
            AddButton.Enabled = check;
            DeleteButton.Visible = check;
            DeleteButton.Enabled = check;

            //dataGridView1.Columns[0].HeaderText = "Id субвенции";
            //dataGridView1.Columns[0].Visible = false;

            dataGridView1.Columns[0].HeaderText = "Муниципальное образование";
            dataGridView1.Columns[1].HeaderText = "Получатель";
            dataGridView1.Columns[2].HeaderText = "Распределитель";
            dataGridView1.Columns[3].HeaderText = "Сумма субвенции";
            dataGridView1.Columns[4].HeaderText = "Год выдачи";
            dataGridView1.Columns[5].HeaderText = "Дата получения денежных средств";

            ShowDialog();
        }

        public void UpdateData()
        {
            if (DataBase.dataSet != null)
                DataBase.dataSet.Clear();

            //Данные из БД

            dataGridView1.DataSource = DataBase.dataSet.Tables["Subvention"];
        }

        private void ExportButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                excelModel = new ExcelModel();
                excelModel.Export();
            }
        }

        //public void StatusExcel() => MessageBox.Show("Успешно!");
    }
}
