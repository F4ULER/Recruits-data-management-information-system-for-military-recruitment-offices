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
    //класс для взаимодействия программы с базой данных
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

        // отправление команды базе данных
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

        public DataTable sending_command_with_output_to_table(string mess)
        {
            MySqlCommand command = new MySqlCommand(mess, getConnection());
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table;
        }

        public List<MeoIS.User> sending_command_with_output_to_list(string mess)
        {
            openConnection();

            MySqlCommand command = new MySqlCommand(mess, getConnection());
            List<User> user = new List<User>();
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                user.Add(new User(
                           reader.GetString(reader.GetOrdinal("document_number")),
                           reader.GetString(reader.GetOrdinal("password")),
                           reader.GetString(reader.GetOrdinal("last_name")),
                           reader.GetString(reader.GetOrdinal("name")),
                           reader.GetString(reader.GetOrdinal("patronymic")),
                           reader.GetDateTime(reader.GetOrdinal("date_of_birth")),
                           reader.GetString(reader.GetOrdinal("address")),
                           reader.GetString(reader.GetOrdinal("category")),
                           reader.GetString(reader.GetOrdinal("gender")),
                           reader.GetString(reader.GetOrdinal("city")),
                           reader.GetString(reader.GetOrdinal("phone_number")),
                           reader.GetString(reader.GetOrdinal("email")),
                           reader.GetString(reader.GetOrdinal("user_status")),
                           ""
                           ));
            }

            closeConnection();

            return user;
        }

        // проверка оригинальности любого параметра
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

        public List<MeoIS.User> change_date_style(List<User> user)
        {
            user[0].DateOfBirth = DateTime.Parse( user[0].DateOfBirth.ToShortDateString());
            return user;
        }
    }
}
