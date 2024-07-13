using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace MeoIS
{
    //расширенный поиск. В каждом методы находится SQL команда для поиска того или иного параметра о пользователе
    class Advanced_search : Search_note
    {
        //поиск по номеры документа
        public DataTable searchDocumentNumber(string documentNumber)
        {
            string message = "SELECT `document_number`, `password`, `last_name`, `name`, `patronymic`, `category`, `gender`, " +
                "`city`, `phone_number`, `email`, `user_status` FROM `users` WHERE `document_number` = '" + documentNumber + "'";

            DataTable table = sending_command(message);
            return table;
        }

        //поиск по  полному имени (ФИО)
        public DataTable searchFullName(string last_name, string name, string patronymic)
        {
            string message = "SELECT `document_number`, `password`, `last_name`, `name`, `patronymic`, `category`, `gender`, `city`, " +
                "`phone_number`, `email`, `user_status` FROM `users` WHERE (`last_name`= '" + last_name + "') || (`document_number`= '" + last_name + "') ||" +
                " (`last_name` = '" + last_name + "' && `name` = '" + name + "') || (`last_name` = '" + last_name + "' && `name`= '" + name + "' && `patronymic`='" + patronymic + "')";
            DataTable table = sending_command(message);
            return table;
        }

        //поиск по городу (военкомату)
        public DataTable searchMilitaryRegistrationAndEnlistmentOffice(string city)
        {
            string message = "SELECT `document_number`, `password`, `last_name`, `name`, `patronymic`, `category`, `gender`, " +
                "`city`, `phone_number`, `email`, `user_status` FROM `users` WHERE `city` = '" + city + "'";

            DataTable table = sending_command(message);
            return table;
        }

        //поиск по номеру телефона
        public DataTable searchPhoneNumber(string phone)
        {
            string message = "SELECT `document_number`, `password`, `last_name`, `name`, `patronymic`, `category`, `gender`, " +
                "`city`, `phone_number`, `email`, `user_status` FROM `users` WHERE `phone_number` = '" + phone + "'";
           
            DataTable table = sending_command(message);
            return table;
        }
    }
}
