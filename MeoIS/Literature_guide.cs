using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeoIS
{
    class Literature_guide : Search_note
    {
        public Boolean addLiterature(string titleLit, string author, int yearRelease, string summary)
        {
            string message = "INSERT INTO `literature`(`title_literature`, `author`, `year_release`, `summary`) " +
                "VALUES ('" + titleLit + "','" + author + "','" + yearRelease + "','" + summary + "')";
            if (DataBase.sending_command(message) == true)
            {
                MessageBox.Show("Получилось!!!!");

                return true;
            }
            else
            {
                MessageBox.Show("Не Получилось");

                return false;
            }
        }

        public Boolean deleteLiterature(string titleLit)
        {
            string message = "DELETE FROM `literature` WHERE `title_literature` = '" + titleLit + "'";
            if (DataBase.sending_command(message) == true)
            {
                MessageBox.Show("Получилось!!!!");

                return true;
            }
            else
            {
                MessageBox.Show("Не Получилось");

                return false;
            }
        }
    }
}
