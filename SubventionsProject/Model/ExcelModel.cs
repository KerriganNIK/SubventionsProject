using Microsoft.Extensions.Logging;
using NLog;
using System;
using Excel = Microsoft.Office.Interop.Excel;

namespace SubventionsProject
{
    public class ExcelModel
    {
        private MainForm mainForm;
        private static Logger Logger = LogManager.GetCurrentClassLogger();

        public void Export()
        {
            mainForm = MainForm.Initialize();

            Excel.Application excel = new Excel.Application();

            excel.Application.Workbooks.Add(Type.Missing);
            Excel.Worksheet worksheet = (Excel.Worksheet)excel.ActiveSheet;

            for (int i = 0; i < mainForm.dataGridView1.ColumnCount; i++)
            {
                for (int j = 0; j < mainForm.dataGridView1.RowCount; j++)
                {
                    excel.Cells[j + 1, i + 1] = (mainForm.dataGridView1[i, j].Value).ToString();
                }

                if (i == 5)
                    break;
            }

            excel.Visible = true;

            Logger.Debug("Выполняется экспорт в Excel");
        }
    }
}
