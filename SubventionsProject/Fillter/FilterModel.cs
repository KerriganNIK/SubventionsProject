using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubventionsProject
{
    public class FilterModel
    {
        private string municipality;
        private string getSubvention;
        private string distributorSubvention;
        private string yearsSubvention;
        private string amountMoney;
        private string dateMoney;
        private MainForm mainForm;

        public FilterModel(string municipality, string getSubvention, string distributorSubvention, string yearsSubvention, string amountMoney, string dateMoney)
        {
            this.municipality = municipality;
            this.getSubvention = getSubvention;
            this.distributorSubvention = distributorSubvention;
            this.yearsSubvention = yearsSubvention;
            this.amountMoney = amountMoney;
            this.dateMoney = dateMoney;
        }

        public void FilterDate()
        {
            mainForm = MainForm.Initialize();

            DataFillter();

            if (municipality == "" && getSubvention == "" && distributorSubvention == "" && yearsSubvention == "" && amountMoney == "")
            {
                mainForm.UpdateData();
            }
        }

        private void DataFillter()
        {
            mainForm.UpdateData();

            List<string> parrametrs = new List<string>();
            parrametrs.Add(municipality);
            parrametrs.Add(getSubvention);
            parrametrs.Add(distributorSubvention);
            parrametrs.Add(yearsSubvention);
            parrametrs.Add(amountMoney);
            parrametrs.Add(dateMoney);

            FilterLogic(parrametrs[0], parrametrs[1], parrametrs[2], parrametrs[3], parrametrs[4], parrametrs[5], parrametrs[6]);
        }

        public void FilterLogic(params string[] fillter)
        {
            int number = 0;

            for (int i = 0; i < mainForm.dataGridView1.Rows.Count; i++)
            {
                if (mainForm.dataGridView1.Rows[i].Cells[number].Value.ToString() != fillter[number] && fillter[number] != "")
                {
                    mainForm.dataGridView1.Rows.RemoveAt(i);
                    i--;
                }

                if (i == mainForm.dataGridView1.Rows.Count - 1)
                {
                    if (number != fillter.Count() - 1)
                    {
                        number++;
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
