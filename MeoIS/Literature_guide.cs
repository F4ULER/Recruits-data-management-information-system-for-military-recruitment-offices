using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeoIS
{
    // класс для работы со справочником литературы
    class Literature_guide : Search_note
    {
        //добаленеи литературы в бд
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

        //удаление литературы из бд
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
