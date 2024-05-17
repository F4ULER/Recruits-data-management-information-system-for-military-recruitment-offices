//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;

//namespace MeoIS
//{
//    class Advanced_search : Search_note
//    {
//        public Boolean searchDocumentNumber(string documentNumber)
//        {
//            string message = "SELECT `document_number`, `password`, `last_name`, `name`, `patronymic`, `category`, `gender`, " +
//                "`city`, `phone_number`, `email`, `user_status` FROM `users` WHERE `document_number` = '" + documentNumber + "'";

//            if (sending_command(message) == true)
//            {
//                MessageBox.Show("Получилось!!!!");
//                return true;
//            }
//            else
//            {
//                MessageBox.Show("Не Получилось");
//                return false;
//            }
//        }

//        public Boolean searchFullName(string last_name, string name, string patronymic)
//        {
//            string message = "SELECT `document_number`, `password`, `last_name`, `name`, `patronymic`, `category`, `gender`, `city`, " +
//                "`phone_number`, `email`, `user_status` FROM `users` WHERE (`last_name`= '" + last_name + "') ||" +
//                " (`last_name` = '" + last_name + "' && `name` = '" + name + "') || (`last_name` = '" + last_name + "' && `name`= '" + name + "' && `patronymic`='" + patronymic + "')";

//            if (sending_command(message) == true)
//            {
//                MessageBox.Show("Получилось!!!!");
//                return true;
//            }
//            else
//            {
//                MessageBox.Show("Не Получилось");
//                return false;
//            }
//        }

//        public Boolean searchMilitaryRegistrationAndEnlistmentOffice(string city)
//        {
//            string message = "SELECT `document_number`, `password`, `last_name`, `name`, `patronymic`, `category`, `gender`, " +
//                "`city`, `phone_number`, `email`, `user_status` FROM `users` WHERE `city` = '" + city + "'";

//            if (sending_command(message) == true)
//            {
//                MessageBox.Show("Получилось!!!!");
//                return true;
//            }
//            else
//            {
//                MessageBox.Show("Не Получилось");
//                return false;
//            }
//        }

//        public Boolean searchPhoneNumber(string phone)
//        {
//            string message = "SELECT `document_number`, `password`, `last_name`, `name`, `patronymic`, `category`, `gender`, " +
//                "`city`, `phone_number`, `email`, `user_status` FROM `users` WHERE `phone_number` = '" + phone + "'";

//            if (sending_command(message) == true)
//            {
//                MessageBox.Show("Получилось!!!!");
//                return true;
//            }
//            else
//            {
//                MessageBox.Show("Не Получилось");
//                return false;
//            }
//        }
//    }
//}
