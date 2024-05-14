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

        public static string search_word
        { get; set; }

        protected Boolean sending_command(string mess)
        {
            MySqlCommand command = new MySqlCommand(mess, DataBase.getConnection());
            DataTable table_literature = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            adapter.SelectCommand = command;
            adapter.Fill(table_literature);


            if (table_literature.Rows.Count > 0)
            {
                //mainTable.DataSource = table_literature;
                //mainTable.Visible = true;
                return true;
            }
            else
            {
                return false;
            }

        }
        public Boolean search_literature()
        {
            string message = "SELECT `title_literature`, `author`, `year_release`, " +
                "`summary` FROM `literature` WHERE `title_literature` = '" + search_word + "' || `author` = '" + search_word + "' || `year_release` = '" + search_word + "'";
            
            if(sending_command(message) == true)
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