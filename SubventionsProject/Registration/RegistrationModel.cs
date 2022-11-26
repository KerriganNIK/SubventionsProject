using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
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
        private string amountMoney;
        private string dateMoney;
        private string subventionId;

        public RegistrationModel(string municipality, string getSubvention, string distributorSubvention, string yearsSubvention, string amountMoney, string dateMoney, string subventionId)
        {
            this.municipality = municipality;
            this.getSubvention = getSubvention;
            this.distributorSubvention = distributorSubvention;
            this.yearsSubvention = yearsSubvention;
            this.amountMoney = amountMoney;
            this.dateMoney = dateMoney;
            this.subventionId = subventionId;
        }

        public void RegistrationAdd()
        {
            #region AddDataBase
            //DataBase.OpenConnection();
            //MySqlCommand command = new MySqlCommand("SELECT subvention.* FROM subvention INNER JOIN transaction ON subvention.id_subvention = transaction.fk_subvention WHERE subvention.id_subvention = @subventionId", DataBase.GetConnection());
            //command.Parameters.Add("@subventionId", MySqlDbType.VarChar).Value = subventionId;

            //DataRow rw = DataBase.dataSet.Tables[0].NewRow();
            //DataBase.dataSet.Tables[0].Rows.Add(rw);
            //rw["id_subvention"] = 1;
            //rw["fk_receiver"] = getSubvention;
            //rw["fk_distributor"] = distributorSubvention;
            //rw["year"] = yearsSubvention;
            //rw["amount"] = amountMoney;
            ////rw["date"] = dateMoney;

            //MySqlDataAdapter adapter = new MySqlDataAdapter();
            //adapter.SelectCommand = command;
            //adapter.Fill(DataBase.dataSet, "Subvention");
            //MySqlCommandBuilder builder = new MySqlCommandBuilder(adapter);
            //builder.GetInsertCommand();
            //adapter.Update(DataBase.dataSet.Tables[0]);
            //DataBase.CloseConnection();
            #endregion

            MainForm mainForm = MainForm.Initialize();
            mainForm.UpdateData();
        }
    }
}

