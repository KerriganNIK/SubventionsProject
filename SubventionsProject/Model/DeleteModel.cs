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
        private MainForm mainForm;
        private string subventionId;

        public DeleteModel(string subventionId)
        {
            this.subventionId = subventionId;
        }

        /// <summary>
        /// Returns true if deleted succesfully; otherwise false.
        /// </summary>
        public bool Delete()
        {
            var deleteSubventionResponse = DataBase.Client.DeleteAsync(DataBase.Uri + $"/subventions/{subventionId}").Result;
            if (deleteSubventionResponse.IsSuccessStatusCode)
            {
                return true;
            }
            else
            {
                MessageBox.Show(HttpErrorHelper.GetErrorMessage(deleteSubventionResponse));
                return false;
            }
        }
    }
}
