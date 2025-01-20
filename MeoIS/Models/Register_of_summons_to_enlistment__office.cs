using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MeoIS
{
    class Register_of_summons_to_enlistment__office
    {

        public bool addSummons(string documentNumber, string series, string number, string date_of_visit, string status)
        {
            DataBaseConnect DataBase = new DataBaseConnect();
            string[] changedate;
            string newDate = "";
            changedate = date_of_visit.Split(new char[] { '.' });
            newDate = changedate[2] + "-" + changedate[1] + "-" + changedate[0];

            string message = "INSERT INTO `register_of_summonses`(`document_number`, `series`, `number`, `date_of_visit`, `visit_status`) " +
                    "VALUES (" + documentNumber + ", " + series + ", " + number + ", '" + newDate + "', '" + status + "')";
            
            if (DataBase.sending_command(message) == true)
            {
                MessageBox.Show("Повестка занесена в реестр!");

                return true;
            }
            else
            {
                MessageBox.Show("Ошибка!");

                return false;
            }
        }

        public bool editStatusSummons(string series, string number, string status)
        {
            DataBaseConnect DataBase = new DataBaseConnect();


            string message = "UPDATE `register_of_summonses` SET `visit_status`= '" + status + "' WHERE `series`= '" + series + "' AND `number`= '" + number + "'";

            if (DataBase.sending_command(message) == true)
            {
                MessageBox.Show("Статус повестки изменен на " + status);

                return true;
            }
            else
            {
                MessageBox.Show("Ошибка!");

                return false;
            }
        }

        public bool updateActiveSummons()
        {
            Advanced_search search = new Advanced_search();
            DataTable table = new DataTable();
            table = search.searchAllSummonsByDocNumberToTable(Transfer.Doc_num);
            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public void editOrDeleteSummons()
        {

        }

    }
}
