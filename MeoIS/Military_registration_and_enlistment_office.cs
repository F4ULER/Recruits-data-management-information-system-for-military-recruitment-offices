using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeoIS
{
    class Military_registration_and_enlistment_office
    {
        DataBaseConnect DataBase = new DataBaseConnect();

        public Boolean choice_military_registration_and_enlistment_office(string documentNumber, string value)
        {
            MessageBox.Show("Выберите военкомат по месту жительства:");
            string message = "UPDATE `users` SET `city` = '" + value + "' WHERE `document_number`= " + documentNumber;

            if (DataBase.sending_command(message) == true)
            {
                MessageBox.Show("Военкомат выбран: " + value);
                return true;
            }
            else
            {
                return false;
            }
        }

        public Boolean change_military_registration_and_enlistment_office(string documentNumber, string value)
        {
            DialogResult result = MessageBox.Show(
                "Вы хотите встать на учет в военкомате города " + value + "?",
                "Постановка на учет",
                MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                string message = "UPDATE `users` SET `city` = '" + value + "' WHERE `document_number`= " + documentNumber;

                if (DataBase.sending_command(message) == true)
                {
                    MessageBox.Show("Вы встали на учет в военкомат города " + value + ".");
                    Transfer.City = value;
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else { return false; }
            
        }
    }
}
