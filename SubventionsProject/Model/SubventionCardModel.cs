using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubventionsProject.Model
{
    public class SubventionCardModel
    {
        private string municipality;
        private string getSubvention;
        private string distributorSubvention;
        private string yearsSubvention;
        private string amountMoney;
        private string dateMoney;
        private MainForm mainForm;
        private SubventionCardForm subventhionCard;

        public SubventionCardModel(string municipality, string getSubvention, string distributorSubvention, string yearsSubvention, string amountMoney, string dateMoney, SubventionCardForm subventhionCard)
        {
            this.municipality = municipality;
            this.getSubvention = getSubvention;
            this.distributorSubvention = distributorSubvention;
            this.yearsSubvention = yearsSubvention;
            this.amountMoney = amountMoney;
            this.dateMoney = dateMoney;
            this.subventhionCard = subventhionCard;
        }

        public void SumbventionEdit()
        {
            //Бизнес логика



            mainForm = MainForm.Initialize();
            //mainForm.UpdateDate();
        }
    }
}
