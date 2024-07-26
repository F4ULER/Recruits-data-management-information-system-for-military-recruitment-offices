using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;

namespace MeoIS
{
    class Collect_statistics
    {
        public void export_to_Excel(DataTable table, string title)
        {
            if(table.Rows.Count != 0)
            {
                Excel.Application expApp = new Excel.Application();
                expApp.Workbooks.Add().SaveAs(title + " (" + DateTime.Today.ToShortDateString() + ")");

                Excel.Worksheet worksheet = (Excel.Worksheet)expApp.ActiveSheet;

                for (int i = 0; i <= table.Rows.Count - 1; i++)
                {
                    for (int j = 0; j <= table.Columns.Count - 1; j++)
                    {
                        worksheet.Cells[1, j + 1] = table.Columns[j].ToString();
                        worksheet.Cells[i + 2, j + 1] = table.Rows[i][j].ToString();
                    }
                }
                expApp.Visible = true;
            } else { MessageBox.Show("Нет данных"); }
        }

        public void export_to_TXT(string result, string title)
        {
            string path = @"C:\Users\User\Desktop\" + title + "." + DateTime.Today.ToShortDateString() +".txt";
            MessageBox.Show(result);
            if(!File.Exists(path))
            {
                File.Create(path).Close();
            }
            StreamWriter streamWriter = new StreamWriter(path);
            streamWriter.WriteLine(result);
            streamWriter.Close();
        }

        public void statistics_By_Gender(List<User> user, bool expOrStat)
        {
            int M = 0, F = 0;
            foreach (User f in user)
            {
                if(f.Gender == "M" || f.Gender == "М") { M++; } else { F++; }
            }
            string result = "Мужчин - " + M + "\n Женщин -" + F, title = "Статистика по половому признаку";
            if (expOrStat == true)
            {
                MessageBox.Show(result, title, MessageBoxButtons.OK);
            }
            else
            {
                result = title + "\n\n" + result;
                export_to_TXT(result, title);
            }
        }

        public void statistics_By_City(List<User> user, bool expOrStat)
        {
            List<string> city = new List<string>();
            
            foreach (User u in user)
            {
                city.Add(u.City);
            }
            statistics_By_Item(city, "Статистика по количеству призывников", expOrStat);
        }

        public void statistics_By_Category(List<User> user, bool expOrStat)
        {
            List<string> category = new List<string>();

            foreach (User u in user)
            {
                category.Add(u.Category);
            }
            statistics_By_Item(category, "Статистика по категории годности", expOrStat);
        }

        public void statistics_By_Age(List<User> user, bool expOrStat)
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

            statistics_By_Item(age, "Статистика по возрасту",expOrStat);
        }

        private void statistics_By_Item(List<string> list, string title, bool expOrStat)
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

            if(expOrStat == true && listDistinct.Count != 0)
            {
                MessageBox.Show(result, title, MessageBoxButtons.OK);
            } else if (expOrStat == false && listDistinct.Count != 0)
            {
                result = title + "\n\n" + result;
                export_to_TXT(result,title);
            } else { MessageBox.Show("Нет данных"); }
        }
    }
}
