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
    class Search_note
    {
        public DataBaseConnect DataBase = new DataBaseConnect();

        protected Boolean sending_command(string mess)
        {
            MySqlCommand command = new MySqlCommand(mess, DataBase.getConnection());
            DataTable table_literature = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            adapter.SelectCommand = command;
            adapter.Fill(table_literature);

            if (table_literature.Rows.Count > 0)
            {
                MessageBox.Show(table_literature.Rows[0][1].ToString());

                MainForm mainForm = new MainForm();
                mainForm.dataGVLitTable.DataSource = table_literature;
                
                MessageBox.Show(mainForm.dataGVLitTable.Rows[0].Cells[1].Value.ToString());
                
                return true;
            }
            else
            {
                return false;
            }

        }

        protected DataTable sending_command(string mess, bool i)
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
            string message = "SELECT `title_literature` AS 'Название', `author` AS 'Автор', `year_release` AS 'Дата выхода', " +
                "`summary` AS 'Краткое содержание', `date_added` AS 'Дата добавления' FROM `literature` WHERE `title_literature` = '" + search_word + "' || `author` = '" + search_word + "' || `year_release` = '" + search_word + "'";

            return (sending_command(message, true));
            
        }

        
    }
}