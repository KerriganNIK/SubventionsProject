using Microsoft.Extensions.Logging;
using NLog;
using SubventionsProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SubventionsProject
{
    public class DeleteModel
    {
        private string subventionId;
        private static Logger Logger = LogManager.GetCurrentClassLogger();
        private MainForm mainForm;

        public DeleteModel(string subventionId)
        {
            this.subventionId = subventionId;
        }

        public void Delete()
        {
            mainForm = MainForm.Initialize();
            var deleteSubventionResponse = DataBase.Client.DeleteAsync(DataBase.Uri + $"/subventions/{subventionId}").Result;

            if (deleteSubventionResponse.IsSuccessStatusCode)
            {
                Logger.Debug("Производится удаление");
                mainForm.UpdateData();
            }
            else
            {
                MessageBox.Show(HttpErrorHelper.GetErrorMessage(deleteSubventionResponse));
                Logger.Warn($"{HttpErrorHelper.GetErrorMessage(deleteSubventionResponse)}");
            }
        }
    }
}
