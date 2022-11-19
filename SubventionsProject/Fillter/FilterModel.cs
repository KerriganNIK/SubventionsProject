using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubventionsProject
{
    public class FilterModel
    {
        private string getSubvention;
        private string distributorSubvention;
        private string yearsSubvention;
        private double amountMoney;
        private string dateMoney;
        private MainForm mainForm;

        public FilterModel(string getSubvention, string distributorSubvention, string yearsSubvention, double amountMoney, string dateMoney)
        {
            this.getSubvention = getSubvention;
            this.distributorSubvention = distributorSubvention;
            this.yearsSubvention = yearsSubvention;
            this.amountMoney = amountMoney;
            this.dateMoney = dateMoney;
        }

        public void FilterDate()
        {
            //Бизнес логика

            mainForm = MainForm.Initialize();
            mainForm.UpdateDate();
        }
    }
}
