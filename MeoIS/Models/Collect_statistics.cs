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

        public void statistics_By_Gender(List<User> user)
        {
            int M = 0, F = 0;
            foreach (User f in user)
            {
                if(f.Gender == "M" || f.Gender == "М") { M++; } else { F++; }
            }
            MessageBox.Show("Мужчин - " + M + "\n Женщин - " + F, "Статистика по половому признаку", MessageBoxButtons.OK);
        }

        public void statistics_By_City(List<User> user)
        {
            List<string> city = new List<string>();
            
            foreach (User u in user)
            {
                city.Add(u.City);
            }

            var cityDistinct = city.Distinct().ToList();
            int[] count = new int[cityDistinct.Count];

            for (int i = 0; i<city.Count; i++)
            {
                for(int j = 0; j < cityDistinct.Count; j++)
                {
                    if(cityDistinct[j] == city[i])
                    {
                        count[j]++;
                    }
                }
            }
            string result = "";
            for (int i = 0; i < cityDistinct.Count; i++)
            {
                result += cityDistinct[i] + " - " + count[i] + "\n";
            }

            MessageBox.Show(result, "Статистика по количеству призывников", MessageBoxButtons.OK);
        }
    }
}
