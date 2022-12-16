using System.Collections.Generic;
using System.Linq;

namespace SubventionsProject
{
    public class FilterModel
    {
        private string getSubvention;
        private string yearsSubvention;
        private string amountMoney;
        private string dateMoney;
        private MainForm mainForm;

        public FilterModel(string getSubvention, string yearsSubvention, string amountMoney, string dateMoney)
        {
            this.getSubvention = getSubvention;
            this.yearsSubvention = yearsSubvention;
            this.amountMoney = amountMoney;
            this.dateMoney = dateMoney;
        }

        public void FilterDate()
        {
            mainForm = MainForm.Initialize();

            DataFillter();

            if (getSubvention == "" && yearsSubvention == "" && amountMoney == "")
            {
                mainForm.UpdateData();
            }
        }

        private void DataFillter()
        {
            mainForm.UpdateData();

            List<string> parrametrs = new List<string>();
            parrametrs.Add(getSubvention);
            parrametrs.Add(yearsSubvention);
            parrametrs.Add(amountMoney);
            parrametrs.Add(dateMoney);

            FilterLogic(parrametrs[0], parrametrs[1], parrametrs[2], parrametrs[3]);
        }

        public void FilterLogic(params string[] fillter)
        {   
            int number = 0;
            int numberDataGrid = 1;

            for (int i = 0; i < mainForm.dataGridView1.Rows.Count; i++)
            {
                if (mainForm.dataGridView1.Rows[i].Cells[numberDataGrid].Value.ToString() != fillter[number] && fillter[number] != "")
                {
                    mainForm.dataGridView1.Rows.RemoveAt(i);
                    i--;
                }

                if (i == mainForm.dataGridView1.Rows.Count - 1)
                {
                    if (number != fillter.Count() - 1)
                    {
                        number++;
                        numberDataGrid++;
                        if (numberDataGrid == 2)
                            numberDataGrid++;

                        i = -1;
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }
    }
}
