using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public void Delete()
        {
            

            mainForm = MainForm.Initialize();
            mainForm.UpdateData();
        }
    }
}
