using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubventionsProject
{
    public class ExcelModel
    {
        MainForm mainForm;
        public void Export()
        {
            //Выводит данные в Excel
            mainForm = MainForm.Initialize();
            mainForm.StatusExcel();
        }
    }
}
