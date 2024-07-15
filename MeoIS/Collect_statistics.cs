using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace MeoIS
{
    class Collect_statistics
    {
        public void export_to_file(DataTable table)
        {
            Excel.Application expApp = new Excel.Application();
            expApp.Workbooks.Add();

            Excel.Worksheet worksheet = (Excel.Worksheet)expApp.ActiveSheet;

            for (int i = 0; i<=table.Rows.Count-1; i++)
            {
                for (int j = 0; j<= table.Columns.Count-1; j++)
                {
                    worksheet.Cells[1, j + 1] = table.Columns[j].ToString();
                    worksheet.Cells[i + 2, j + 1] = table.Rows[i][j].ToString();
                }
            }
            expApp.Visible = true;
        }
    }
}
