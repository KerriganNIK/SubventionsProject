using MaterialSkin;
using MaterialSkin.Controls;
using SubventionsProject.Model;
using System;
using System.Windows.Forms;

namespace SubventionsProject.View
{
    public partial class TransactionForm : MaterialForm
    {
        private TransactionModel transactionModel;
        private int subventionId;

        public TransactionForm(int subnvetionId)
        {
            InitializeComponent();

            #region Design
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            #endregion

            subventionId = subnvetionId;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void WriteButton_Click(object sender, EventArgs e)
        {
            if (AmountTextBox.Text != "" && dateTimePicker1.Text != "")
            {
                transactionModel = new TransactionModel(Convert.ToInt32(AmountTextBox.Text), dateTimePicker1.Value, subventionId);
                if (transactionModel.AddTransaction()) Close();
            }
            else
            {
                MessageBox.Show("Заполните все поля!");
            }
        }
    }
}
