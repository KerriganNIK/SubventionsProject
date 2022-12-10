using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubventionsProject
{
    public class DeleteDataModel
    {
        private MainForm mainForm;
        private string subventionId;

        public DeleteDataModel(string subventionId)
        {
            this.subventionId = subventionId;
        }

        public void Delete()
        {
            #region DeleteDataBase
            //DataBase.OpenConnection();
            //MySqlCommand command = new MySqlCommand("DELETE FROM subvention WHERE subvention.id_subvention = @subventionId", DataBase.GetConnection());
            //command.Parameters.Add("@subventionId", MySqlDbType.VarChar).Value = subventionId;

            //MySqlDataAdapter adapter = new MySqlDataAdapter();
            //adapter.SelectCommand = command;
            //adapter.Fill(DataBase.dataSet, "Subvention");

            //MySqlCommandBuilder builder = new MySqlCommandBuilder(adapter);

            //builder.GetInsertCommand();
            //adapter.Update(DataBase.dataSet.Tables[0]);
            //DataBase.CloseConnection();
            #endregion

            mainForm = MainForm.Initialize();
            mainForm.UpdateData();
        }
    }
}
