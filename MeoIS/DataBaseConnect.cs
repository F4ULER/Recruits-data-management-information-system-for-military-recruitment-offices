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

        public bool addUser(string documentNumber, string pass, string lastName, string name, string patronymic, string category, bool gender, string city, string phone, string email)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `users` (`document_number`, `password`, `last_name`, `name`, "+
                "`patronymic`, `category`, `gender`, `city`, `phone_number`, `email`, `user_status`) VALUES (@documentNumber, @pass, @lastName, @name, @patronymic, @status, @gender, @city, @phone, @email, @userStatus);", getConnection());
            command.Parameters.Add("@documentNumber", MySqlDbType.VarChar).Value = documentNumber;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = pass;
            command.Parameters.Add("@lastName", MySqlDbType.VarChar).Value = lastName;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = name;
            command.Parameters.Add("@patronymic", MySqlDbType.VarChar).Value = patronymic;
            command.Parameters.Add("@category", MySqlDbType.VarChar).Value = category;
            command.Parameters.Add("@gender", MySqlDbType.VarChar).Value = gender;
            command.Parameters.Add("@city", MySqlDbType.VarChar).Value = city;
            command.Parameters.Add("@phone", MySqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@email", MySqlDbType.VarChar).Value = email;
            command.Parameters.Add("@userStatus", MySqlDbType.VarChar).Value = "user";

            openConnection();

            if (command.ExecuteNonQuery() == 1) { return true; }
            else { return false; }

            closeConnection();
        }



    }
}
