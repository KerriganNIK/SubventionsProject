using Microsoft.Extensions.Logging;
using NLog;
using System.Collections.Generic;
using System.Linq;

namespace SubventionsProject
{
    public class FilterModel
    {
        private string subventionReceiver;
        private string yearsSubvention;
        private string amountMoney;
        private string dateMoney;
        private MainForm mainForm;
        private static Logger Logger = LogManager.GetCurrentClassLogger();


        public FilterModel(string subventionReceiver, string yearsSubvention, string amountMoney, string dateMoney)
        {
            this.subventionReceiver = subventionReceiver;
            this.yearsSubvention = yearsSubvention;
            this.amountMoney = amountMoney;
            this.dateMoney = dateMoney;
        }

        public void FilterDate()
        {
            mainForm = MainForm.Initialize();

            DataFillter();

            if (subventionReceiver == "" && yearsSubvention == "" && amountMoney == "")
            {
                mainForm.UpdateData();
            }
        }

        private void DataFillter()
        {
            mainForm.UpdateData();

            List<string> parameters = new List<string>
            {
                subventionReceiver,
                yearsSubvention,
                amountMoney,
                dateMoney
            };

            FilterLogic(parameters[0], parameters[1], parameters[2], parameters[3]);

            Logger.Debug("Происходит алгоритм фильтрации");
        }

        public void FilterLogic(params string[] filter)
        {   
            int number = 0;
            int numberDataGrid = 1;

            for (int i = 0; i < mainForm.dataGridView1.Rows.Count; i++)
            {
                if (mainForm.dataGridView1.Rows[i].Cells[numberDataGrid].Value.ToString() != filter[number] && filter[number] != "")
                {
                    mainForm.dataGridView1.Rows.RemoveAt(i);
                    i--;
                }

                if (i == mainForm.dataGridView1.Rows.Count - 1)
                {
                    if (number != filter.Count() - 1)
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
