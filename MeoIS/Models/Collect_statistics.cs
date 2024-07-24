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
            statistics_By_Item(city, "Статистика по количеству призывников");
        }

        public void statistics_By_Category(List<User> user)
        {
            List<string> category = new List<string>();

            foreach (User u in user)
            {
                category.Add(u.Category);
            }
            statistics_By_Item(category, "Статистика по категории годности");
        }

        public void statistics_By_Age(List<User> user)
        {
            List<string> age = new List<string>();
            List<int> ageNumber = new List<int>();
            for (int i = 0; i < user.Count; i++)
            {
                ageNumber.Add(DateTime.Today.Year - user[i].DateOfBirth.Year);
            }
            for (int i = 0; i < user.Count; i++)
            {
                age.Add(user[i].DateOfBirth.Year.ToString() + "(" + ageNumber[i] + ")");
            }

            statistics_By_Item(age, "Статистика по возрасту");
        }

        private void statistics_By_Item(List<string> list, string title)
        {
            var listDistinct = list.Distinct().ToList();
            int[] count = new int[listDistinct.Count];

            for (int i = 0; i < list.Count; i++)
            {
                for (int j = 0; j < listDistinct.Count; j++)
                {
                    if (listDistinct[j] == list[i])
                    {
                        count[j]++;
                    }
                }
            }
            string result = "";
            for (int i = 0; i < listDistinct.Count; i++)
            {
                result += listDistinct[i] + " - " + count[i] + "\n\n";
            }

            MessageBox.Show(result, title, MessageBoxButtons.OK);
        }


    }
}
