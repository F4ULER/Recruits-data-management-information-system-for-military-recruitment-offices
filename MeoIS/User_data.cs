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
        public Boolean change_full_name(string documentNumber, string last_name, string name, string patronymic)
        {
            string message = "UPDATE `users` SET`last_name`= '" + last_name + "',`name`='" + name + "',`patronymic`='" + patronymic + "' WHERE `document_number` = " + documentNumber;

            if (DataBase.change_item(message) == true)
            {
                MessageBox.Show("ФИО успешно изменены!");
                return true;
            }
            else
            {
                return false;
            }
        }

        public Boolean change_document_number(string phone, string value)
        {
            string message = "UPDATE `users` SET `document_number` = '" + value + "' WHERE `phone_number`= " + phone;

            if (DataBase.change_item(message) == true)
            {
                MessageBox.Show("Номер документа успешно изменен!");
                return true;
            }
            else
            {
                return false;
            }
        }

        public Boolean change_category_of_suitability_for_military_service(string documentNumber, string value)
        {
            string message = "UPDATE `users` SET `category` = '" + value + "' WHERE `document_number`= " + documentNumber;

            if (DataBase.change_item(message) == true)
            {
                MessageBox.Show("Категория успешно изменен!");
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
