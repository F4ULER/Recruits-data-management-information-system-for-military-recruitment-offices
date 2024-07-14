using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeoIS
{
    //класс пользовательского поиска
    class Search_note
    {
        public DataBaseConnect DataBase = new DataBaseConnect();

        // поиск литературы
        public DataTable search_literature(string search_word)
        {
            string message = "SELECT `title_literature` AS 'Название', `author` AS 'Автор', " +
                "`summary` AS 'Краткое содержание', `keywords` AS 'Ключевые слова', `link` AS 'Ссылка', `date_added` AS 'Дата добавления' FROM `literature` WHERE `title_literature` = '" + search_word + "' || `author` = '" + search_word + "' || `keywords` = '" + search_word + "'";

            return (DataBase.sending_command_with_output_to_table(message));
        }

        // поиск своих мед данных (для иконки медицинского планшета)
        public DataTable searchMedicalData(string search_word)
        {
            string message = "SELECT  `date` AS 'Дата осмотра', `therapist` AS 'Терапевт', `surgeon` AS 'Хирург', `neurologist` AS 'Невропатолог', `psychiatrist` AS 'Психиатр', `ophthalmologist` AS 'Окулист', `dermatovenerologist` AS 'Дерматовенеролог', `otorhinolaryngologist` AS 'Оториноларинголог', `dentist` AS 'Стоматолог' FROM `medical_data` WHERE `document_number` = '" + search_word + "'";

            return (DataBase.sending_command_with_output_to_table(message));

        }
    }
}