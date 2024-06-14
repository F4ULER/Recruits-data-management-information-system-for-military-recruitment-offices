using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace MeoIS
{
    class Advanced_search : Search_note
    {
        public DataTable searchDocumentNumber(string documentNumber)
        {
            string message = "SELECT `document_number`, `password`, `last_name`, `name`, `patronymic`, `category`, `gender`, " +
                "`city`, `phone_number`, `email`, `user_status` FROM `users` WHERE `document_number` = '" + documentNumber + "'";

            DataTable table = sending_command(message);
            return table;
        }

        public DataTable searchFullName(string last_name, string name, string patronymic)
        {
            string message = "SELECT `document_number`, `password`, `last_name`, `name`, `patronymic`, `category`, `gender`, `city`, " +
                "`phone_number`, `email`, `user_status` FROM `users` WHERE (`last_name`= '" + last_name + "') || (`document_number`= '" + last_name + "') ||" +
                " (`last_name` = '" + last_name + "' && `name` = '" + name + "') || (`last_name` = '" + last_name + "' && `name`= '" + name + "' && `patronymic`='" + patronymic + "')";
            DataTable table = sending_command(message);
            return table;
        }

        public DataTable searchMilitaryRegistrationAndEnlistmentOffice(string city)
        {
            string message = "SELECT `document_number`, `password`, `last_name`, `name`, `patronymic`, `category`, `gender`, " +
                "`city`, `phone_number`, `email`, `user_status` FROM `users` WHERE `city` = '" + city + "'";

            DataTable table = sending_command(message);
            return table;
        }

        public DataTable searchPhoneNumber(string phone)
        {
            string message = "SELECT `document_number`, `password`, `last_name`, `name`, `patronymic`, `category`, `gender`, " +
                "`city`, `phone_number`, `email`, `user_status` FROM `users` WHERE `phone_number` = '" + phone + "'";
           
            DataTable table = sending_command(message);
            return table;
        }

        public DataTable searchMedicalData (string search_word)
        {
            string message = "SELECT `therapist` AS 'Терапевт', `surgeon` AS 'Хирург', `neurologist` AS 'Невропатолог', `psychiatrist` AS 'Психиатр', `ophthalmologist` AS 'Окулист', `dermatovenerologist` AS 'Дерматовенеролог', `otorhinolaryngologist` AS 'Оториноларинголог', `dentist` AS 'Стоматолог' FROM `medical_data` WHERE `document_number` = '" + search_word + "'";

            return (sending_command(message));

        }
    }
}
