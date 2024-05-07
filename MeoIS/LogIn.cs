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
    class LogIn
    {
        public Boolean connect_DB(string column, string value, string message)
        {
            DataBase DB = new DataBase();
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

        public Boolean check_document_number(string documentNumber)
        {
            string message = "Данный номер документа уже зарегистрирован!";
            connect_DB("document_number", documentNumber, message);

            return true;
        }

        public Boolean check_email(string email)
        {
            string message = "Данный email уже зарегистрирован!";
            connect_DB("document_number", email, message);

            return true;
        }

        public Boolean check_phone_number(string phone)
        {
            string message = "Данный номер телефона уже зарегистрирован!";
            connect_DB("document_number", phone, message);

            return true;
        }

        public Boolean give_superrights(string documentNumber)
        {
            DataBase DB = new DataBase();
            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT `document_number`, `name`,`last_name`, `patronymic`, `user_status` FROM `users` WHERE  `document_number` = @documentNumber", DB.getConnection());
            command.Parameters.Add("@documentNumber", MySqlDbType.VarChar).Value = documentNumber;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0) 
            {
                if (table.Rows[0][4].ToString() == "user")
                {

                    MySqlCommand comm = new MySqlCommand("UPDATE `users` SET `user_status`= '@userStatus' WHERE `document_number` = '@DocNum';", DB.getConnection());
                    comm.Parameters.Add("@DocNum", MySqlDbType.VarChar).Value = documentNumber;
                    comm.Parameters.Add("@userStatus", MySqlDbType.VarChar).Value = "admin";

                    DB.openConnection();

                    if (comm.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Пользователю выданы права администратора.");
                        return true; 
                    }
                    else { return false; }

                    DB.closeConnection();
                }
                else
                {
                    MessageBox.Show("У данного пользователя уже есть права администратора.");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Данного пользователя не существует!");
                return false;
            }
        }

    }
}
