using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubventionsProject
{
    public class RegistrationModel
    {
        private string municipality;
        private string getSubvention;
        private string distributorSubvention;
        private string yearsSubvention;
        private double amountMoney;
        private string dateMoney;
        private MainForm mainForm;

        public RegistrationModel(string municipality, string getSubvention, string distributorSubvention, string yearsSubvention, double amountMoney, string dateMoney)
        {
            this.municipality = municipality;
            this.getSubvention = getSubvention;
            this.distributorSubvention = distributorSubvention;
            this.yearsSubvention = yearsSubvention;
            this.amountMoney = amountMoney;
            this.dateMoney = dateMoney;
        }

        public void RegistrationAdd()
        {
            //Отправить данные на сервер
            mainForm = MainForm.Initialize();
            mainForm.UpdateDate();
        }
    }
}
