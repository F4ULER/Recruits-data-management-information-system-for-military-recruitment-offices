﻿using MySql.Data.MySqlClient;
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
            DataBaseConnect DB = new DataBaseConnect();
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
            if(connect_DB("document_number", documentNumber, message) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Boolean check_email(string email)
        {
            string message = "Данный email уже зарегистрирован!";
            
            if (connect_DB("email", email, message) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Boolean check_phone_number(string phone)
        {
            string message = "Данный номер телефона уже зарегистрирован!";
            
            if (connect_DB("phone_number", phone, message) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Boolean give_superrights(string documentNumber)
        {
            DataBaseConnect DB = new DataBaseConnect();
            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT `document_number`, `name`,`last_name`, `patronymic`, `user_status` FROM `users` WHERE  `document_number` = @documentNumber", DB.getConnection());
            command.Parameters.Add("@documentNumber", MySqlDbType.VarChar).Value = documentNumber;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0) 
            {
                DialogResult result = MessageBox.Show("Вы уверены, что хотите выдать права администратора" + 
                    table.Rows[0][2].ToString() + " " + table.Rows[0][1].ToString() + " " + table.Rows[0][3].ToString() + "?", "Подтверждение", MessageBoxButtons.YesNo);
                if (table.Rows[0][4].ToString() == "user" && result == DialogResult.Yes)
                {

                    MySqlCommand comm = new MySqlCommand("UPDATE `users` SET `user_status`= 'admin' WHERE `document_number` = '" + documentNumber + "';", DB.getConnection());

                    DB.openConnection();

                    if (comm.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Пользователю выданы права администратора.");
                        return true; 
                    }
                    else 
                    {
                        MessageBox.Show("Ошибка!");
                        return false; 
                    }

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