using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubventionsProject
{
    public class Condition
    {
        private MainForm mainForm;
        private static Condition condition = null;

        public Condition(MainForm mainForm)
        {
            this.mainForm = mainForm;
        }

        public static Condition Initialize(MainForm mainForm)
        {
            if(condition == null)
                condition = new Condition(mainForm);

            return condition;
        }

        public void UserOpen()
        {
            mainForm.AddButton.Visible = false;
            mainForm.AddButton.Enabled = false;
            mainForm.DeleteButton.Visible = false;
            mainForm.DeleteButton.Enabled = false;
            mainForm.OpenButton.Visible = false;
            mainForm.OpenButton.Enabled = false;

            mainForm.ShowDialog();
        }

        public void AdminOpen()
        {
            mainForm.AddButton.Visible = true;
            mainForm.AddButton.Enabled = true;
            mainForm.DeleteButton.Visible = true;
            mainForm.DeleteButton.Enabled = true;
            mainForm.OpenButton.Visible = true;
            mainForm.OpenButton.Enabled = true;

            mainForm.ShowDialog();
        }
    }
}
