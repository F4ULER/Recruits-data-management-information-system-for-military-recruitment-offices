using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeoIS
{
    class User_data : UserAccount
    {
        public Boolean change_full_name(string documentNumber, string name)
        {
            string[] fullName = name.Split(new char[] { ' ' });

            string message = "UPDATE `users` SET`last_name`= '" + fullName[0] + "',`name`='" + fullName[1] + "',`patronymic`='" + fullName[2] + "' WHERE `document_number` = " + documentNumber;

            if (DataBase.sending_command(message) == true)
            {
                MessageBox.Show("ФИО успешно изменены!");
                return true;
            }
            else
            {
                MessageBox.Show("Ошибка!");
                return false;
            }
        }

        public Boolean change_document_number(string phone, string value)
        {
            string message = "UPDATE `users` SET `document_number` = '" + value + "' WHERE `phone_number`= " + phone;

            if (DataBase.sending_command(message) == true)
            {
                MessageBox.Show("Номер документа успешно изменен!");
                return true;
            }
            else
            {
                MessageBox.Show("Ошибка!");
                return false;
            }
        }

        public Boolean change_category_of_suitability_for_military_service(string documentNumber, string value)
        {
            string message = "UPDATE `users` SET `category` = '" + value + "' WHERE `document_number`= " + documentNumber;

            if (DataBase.sending_command(message) == true)
            {
                MessageBox.Show("Категория успешно изменен!");
                return true;
            }
            else
            {
                MessageBox.Show("Ошибка!");
                return false;
            }
        }

        public bool addUser(string documentNumber, string pass, string lastName, string name, string patronymic, string age, string category, string gender, string city, string phone, string email)
        {
            string message = "INSERT INTO `users` (`document_number`, `password`, `last_name`, `name`, " +
                "`patronymic`, `age`, `category`, `gender`, `city`, `phone_number`, `email`, `user_status`,`address`) VALUES " +
                "('" + documentNumber + "', '" + pass + "', '" + lastName + "', '" + name + "', '" + patronymic + "', '" + age + "', '" + category + "','" + gender + "','" + city + "', '" + phone + "', '" + email + "', 'user', '');";
            
            if (DataBase.sending_command(message) == true)
            {
                MessageBox.Show("Польователь успешно добавлен!");

                return true;
            }
            else
            {
                MessageBox.Show("Ошибка!");

                return false;
            }

        }
        public bool deleteUser(string documentNumber)
        {
            string message = "DELETE FROM `users` WHERE `document_number` = '"+documentNumber+"'";

            if (DataBase.sending_command(message) == true)
            {
                MessageBox.Show("Польователь успешно удален!");

                return true;
            }
            else
            {
                MessageBox.Show("Ошибка!");

                return false;
            }

        }
    }
}
