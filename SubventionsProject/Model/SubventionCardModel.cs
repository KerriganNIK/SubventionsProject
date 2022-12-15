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
        private string moneyAmount;
        private string dateMoney;
        private MainForm mainForm;
        private SubventionCardForm subventhionCard;

        public SubventionCardModel(string municipality, string getSubvention, string distributorSubvention, string yearsSubvention, string moneyAmount, string dateMoney, SubventionCardForm subventionCard)
        {
            this.municipality = municipality;
            this.getSubvention = getSubvention;
            this.distributorSubvention = distributorSubvention;
            this.yearsSubvention = yearsSubvention;
            this.moneyAmount = moneyAmount;
            this.dateMoney = dateMoney;
            this.subventhionCard = subventionCard;
        }

        public void SubventionEdit()
        {
            // NOTE: Не тот метод(?)

            //Бизнес логика

            mainForm = MainForm.Initialize();
            //mainForm.UpdateDate();
        }
    }
}
