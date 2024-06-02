using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;

namespace MeoIS
{
    class DataBaseConnect
    {
        //подключение к базе данных
        MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=root;database=db_military_enlistment_office");
        
        // соединение с бд
        public void openConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
        }

        // закрывает соеденение с бд
        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }

        // возвращает соединение
        public MySqlConnection getConnection()
        {
            return connection;
        }

        public Boolean sending_command(string mess)
        {
            MySqlCommand command = new MySqlCommand(mess, getConnection());

            openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                closeConnection();
                return true;
            }
            else
            {
                closeConnection();
                return false;
            }
        }
        public Boolean check(string column, string value, string message)
        {
            DataBaseConnect DB = new DataBaseConnect();
            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `" + column + "` = @Value", DB.getConnection());
            command.Parameters.Add("@Value", MySqlDbType.VarChar).Value = value;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show(message);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
