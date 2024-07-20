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
        public void export_to_Excel(DataTable table)
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

        public void show_statistics_on_window(string nameColumn, int number, DataTable table)
        {
            




            //var selectOrig = new List<string>();
            //var count = new List<int>();
            //int k = 0;
            //if (int i = 0; i <= table.Rows.Count; i++)
            //{
            //    foreach (string v in selectOrig)
            //    {
            //        if (value != v)
            //        {
            //            selectOrig.Add(value);
            //            k++;
            //            count[k] += 1;
            //            MessageBox.Show(value);
            //        }
            //        else { }
            //    }
            //    MessageBox.Show(count[k].ToString()) ;
            //}
            //name = "Статистика по параметру " + name;
            //MessageBox.Show(value, name, MessageBoxButtons.OK);
        }
    }
}
