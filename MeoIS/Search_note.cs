﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeoIS
{
    class Search_note
    {
        public DataBaseConnect DataBase = new DataBaseConnect();

        public DataTable sending_command(string mess)
        {
            MySqlCommand command = new MySqlCommand(mess, DataBase.getConnection());
            DataTable table_literature = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            adapter.SelectCommand = command;
            adapter.Fill(table_literature);

            return table_literature;
        }

        public DataTable search_literature(string search_word)
        {
            string message = "SELECT `title_literature` AS 'Название', `author` AS 'Автор', " +
                "`summary` AS 'Краткое содержание', `keywords` AS 'Ключевые слова', `link` AS 'Ссылка', `date_added` AS 'Дата добавления' FROM `literature` WHERE `title_literature` = '" + search_word + "' || `author` = '" + search_word + "' || `keywords` = '" + search_word + "'";

            return (sending_command(message));
            
        }

        public DataTable searchMedicalData(string search_word)
        {
            string message = "SELECT `therapist` AS 'Терапевт', `surgeon` AS 'Хирург', `neurologist` AS 'Невропатолог', `psychiatrist` AS 'Психиатр', `ophthalmologist` AS 'Окулист', `dermatovenerologist` AS 'Дерматовенеролог', `otorhinolaryngologist` AS 'Оториноларинголог', `dentist` AS 'Стоматолог' FROM `medical_data` WHERE `document_number` = '" + search_word + "'";

            return (sending_command(message));

        }
    }
}