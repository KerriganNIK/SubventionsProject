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
        private RegistrationCardForm registration;
        private FilterForm filterForm;
        private SubventhionCardForm subventhionCard;
        private ExcelModel excelModel;
        private static MainForm mainForm = null;

        public MainForm()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        public static MainForm Initialize()
        {
            if (mainForm == null)
                mainForm = new MainForm();

            return mainForm;
        }

        private void ExitButton_Click(object sender, EventArgs e) => Application.Restart();

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e) => Application.Exit();

        private void AddButton_Click(object sender, EventArgs e)
        {
            registration = new RegistrationCardForm();
            registration.ShowDialog();
        }

        private void FillterButton_Click(object sender, EventArgs e)
        {
            filterForm = new FilterForm();
            filterForm.ShowDialog();
        }

        private void OpenButton_Click(object sender, EventArgs e)
        {
            subventhionCard = new SubventhionCardForm();
            subventhionCard.ShowDialog();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentRow.Index;
            dataGridView1.Rows.Remove(dataGridView1.Rows[index]);
        }

        public void OpenMainForm(Boolean check)
        {
            AddButton.Visible = check;
            AddButton.Enabled = check;
            DeleteButton.Visible = check;
            DeleteButton.Enabled = check;

            ShowDialog();
        }

        public void UpdateDate()
        {
            //Обновление datagrid
        }

        public void StatusExcel() => MessageBox.Show("Успешно!");

        private void ExportButton_Click(object sender, EventArgs e)
        {
            if(dataGridView1.Rows.Count > 0)
            {
                excelModel = new ExcelModel();
                excelModel.Export();
            }
        }
    }
}
