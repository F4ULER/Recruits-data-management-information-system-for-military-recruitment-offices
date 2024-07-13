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
    //класс для изменения некоторых параметров записи пользователем
    class UserAccount
    {
        protected DataBaseConnect DataBase = new DataBaseConnect();

        //изменение электронной почты
        public Boolean change_email(string documentNumber, string value)
        {
            string message = "UPDATE `users` SET `email` = '" + value + "' WHERE `document_number`= " + documentNumber;
            
            // вставить сюда проверку уникальности checkEmail

            if (DataBase.sending_command(message) == true)
            {
                MessageBox.Show("Email успешно изменен!");
                Transfer.Email = value;
                return true;
            }
            else
            {
                return false;
            }
        }

        //изменение пароля
        public Boolean change_password(string documentNumber, string value)
        {
            string message = "UPDATE `users` SET `password` = '" + value + "' WHERE `document_number`= " + documentNumber;

            if (DataBase.sending_command(message) == true)
            {
                MessageBox.Show("Пароль успешно изменен!");
                Transfer.Pass = value;
                return true;
            }
            else
            {
                return false;
            }
        }

        // изменения номера телефона
        public Boolean change_phone_number(string documentNumber, string value)
        {
            string message = "UPDATE `users` SET `phone_number` = '" + value + "' WHERE `document_number`= " + documentNumber;

            if (DataBase.sending_command(message) == true)
            {
                MessageBox.Show("Номер телефона успешно изменен!");
                Transfer.Phone = value;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
