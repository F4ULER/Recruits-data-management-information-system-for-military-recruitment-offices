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
            string message = "SELECT `document_number` AS 'Номер документа', `password` AS 'Пароль', `last_name` AS 'Фамилия', `name` AS 'Имя', `patronymic` AS 'Отчество', `date_of_birth` AS 'Дата рождения', `address` AS 'Фактический адрес', `category` AS 'Категория годности'," +
                " `gender` AS 'Пол', `city` AS 'Город', `phone_number` AS 'Номер телефона', `email` AS 'Электронная почта', `user_status` AS 'Статус' FROM `users` WHERE `document_number` = '" + documentNumber + "'";

            return DataBase.sending_command_with_output_to_table(message);
        }

        //поиск по  полному имени (ФИО)
        public DataTable searchFullName(string last_name, string name, string patronymic)
        {
            string message = "SELECT `document_number` AS 'Номер документа', `password` AS 'Пароль', `last_name` AS 'Фамилия', `name` AS 'Имя', `patronymic` AS 'Отчество', `date_of_birth` AS 'Дата рождения', `address` AS 'Фактический адрес', `category` AS 'Категория годности'," +
                " `gender` AS 'Пол', `city` AS 'Город', `phone_number` AS 'Номер телефона', `email` AS 'Электронная почта', `user_status` AS 'Статус' FROM `users` WHERE (`last_name`= '" + last_name + "') || (`document_number`= '" + last_name + "') ||" +
                " (`last_name` = '" + last_name + "' && `name` = '" + name + "') || (`last_name` = '" + last_name + "' && `name`= '" + name + "' && `patronymic`='" + patronymic + "')";
            
            return DataBase.sending_command_with_output_to_table(message);
        }

        //поиск по городу (военкомату)
        public DataTable searchMilitaryRegistrationAndEnlistmentOffice(string city)
        {
            string message = "SELECT `document_number` AS 'Номер документа', `password` AS 'Пароль', `last_name` AS 'Фамилия', `name` AS 'Имя', `patronymic` AS 'Отчество', `date_of_birth` AS 'Дата рождения', `address` AS 'Фактический адрес', `category` AS 'Категория годности'," +
                " `gender` AS 'Пол', `city` AS 'Город', `phone_number` AS 'Номер телефона', `email` AS 'Электронная почта', `user_status` AS 'Статус' FROM `users` WHERE `city` = '" + city + "'";

            return DataBase.sending_command_with_output_to_table(message);
        }

        //поиск по номеру телефона
        public DataTable searchPhoneNumber(string phone)
        {
            string message = "SELECT `document_number` AS 'Номер документа', `password` AS 'Пароль', `last_name` AS 'Фамилия', `name` AS 'Имя', `patronymic` AS 'Отчество', `date_of_birth` AS 'Дата рождения', `address` AS 'Фактический адрес', `category` AS 'Категория годности'," +
                " `gender` AS 'Пол', `city` AS 'Город', `phone_number` AS 'Номер телефона', `email` AS 'Электронная почта', `user_status` AS 'Статус' FROM `users` WHERE `phone_number` = '" + phone + "'";
           
            return DataBase.sending_command_with_output_to_table(message);
        }
    }
}
