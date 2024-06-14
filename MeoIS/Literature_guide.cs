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
        public Boolean addLiterature(string titleLit, string author, string summary, string keywords, string link, string dateAdded)
        {
            string message = "INSERT INTO `literature`(`title_literature`, `author`, `summary`, `keywords`, `link`, `date_added`) " +
                "VALUES ('" + titleLit + "','" + author + "','" + summary + "','" + keywords + "','" + link + "','" + dateAdded + "')";
            if (DataBase.sending_command(message) == true)
            {
                MessageBox.Show("Запись успешно добавлена");

                return true;
            }
            else
            {
                MessageBox.Show("Ошибка!");

                return false;
            }
        }

        public Boolean deleteLiterature(string titleLit)
        {
            string message = "DELETE FROM `literature` WHERE `title_literature` = '" + titleLit + "'";
            if (DataBase.sending_command(message) == true)
            {
                MessageBox.Show("Запись успешно удалена");

                return true;
            }
            else
            {
                MessageBox.Show("Ошибка!");

                return false;
            }
        }
    }
}
