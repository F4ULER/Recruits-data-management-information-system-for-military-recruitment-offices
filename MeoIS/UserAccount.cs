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
    class UserAccount
    {
        protected Boolean change_item(string mess)
        {
            DataBaseConnect DB = new DataBaseConnect();
            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand(mess, DB.getConnection());

            DB.openConnection();

            if (command.ExecuteNonQuery() == 1) { return true; }
            else { return false; }

            DB.closeConnection();
        }

        public Boolean change_email(string documentNumber, string value)
        {
            string message = "UPDATE `users` SET `email` = " + value + " WHERE `document_number`= " + documentNumber;
            
            if (change_item(message) == true)
            {
                MessageBox.Show("Email успешно изменен!");
                return true;
            }
            else
            {
                return false;
            }
        }

        public Boolean change_password(string documentNumber, string value)
        {
            string message = "UPDATE `users` SET `password` = " + value + " WHERE `document_number`= " + documentNumber;

            if (change_item(message) == true)
            {
                MessageBox.Show("Пароль успешно изменен!");
                return true;
            }
            else
            {
                return false;
            }
        }

        public Boolean change_phone_number(string documentNumber, string value)
        {
            string message = "UPDATE `users` SET `phone_number` = " + value + " WHERE `document_number`= " + documentNumber;

            if (change_item(message) == true)
            {
                MessageBox.Show("Номер телефона успешно изменен!");
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
