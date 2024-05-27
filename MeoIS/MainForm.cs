using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MeoIS
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            if(Transfer.Doc_num != "")
            {
                
                //labelExit.Visible = true;
                //labelEnterReg.Visible = false;
                

                labelWelcome.Text = "Добрый день, " + Transfer.Name;
                labelCategory.Text = "Категория: " + Transfer.Category;
                labelRectal.Text = "Военкомат: " + Transfer.City;
            }
            else
            {
                labelWelcome.Visible = false;
                
                
                //labelExit.Visible = false;
                //labelEnterReg.Visible = true;
               
            }
        }

        private void labelEnterReg_Click(object sender, EventArgs e)
        {
            AuthenticationForm form = new AuthenticationForm();
            form.Show();
        }

        private void labelExit_Click(object sender, EventArgs e)
        {
            labelEnterReg.Visible = true;
            labelExit.Visible = false;
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Закрытие всего приложения
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }

        private void picSearch_Click(object sender, EventArgs e)
        {
            Search_note search = new Search_note();
            DataTable table = new DataTable();
            table = search.search_literature(tBSearch.Text);
            if(table.Rows.Count > 0)
            {

                dataGVLitTable.DataSource = table;
                dataGVLitTable.Visible = true;
            }
            else
            {
                MessageBox.Show("Не найдено ни одной записи");
            }
        }

        private void labelChangeMilitaryRegistrationOffice_Click(object sender, EventArgs e)
        {
            tBChangeMilitaryRegistrationOffice.Visible = true;
            buttonChangeMilitaryRegistrationOffice.Visible = true;
        }

        private void buttonChangeMilitaryRegistrationOffice_Click(object sender, EventArgs e)
        {
            if (tBChangeMilitaryRegistrationOffice.Text == Transfer.City)
            {
                Military_registration_and_enlistment_office military_Registration = new Military_registration_and_enlistment_office();
                military_Registration.change_military_registration_and_enlistment_office(Transfer.Doc_num, tBChangeMilitaryRegistrationOffice.Text);
                
                labelRectal.Text = "Военкомат: " + Transfer.City;
                tBChangeMilitaryRegistrationOffice.Text = "";
            }
            tBChangeMilitaryRegistrationOffice.Visible = false;
            buttonChangeMilitaryRegistrationOffice.Visible = false;
        }

        private void pictureOptions_Click(object sender, EventArgs e)
        {
            tBChangePass.Text = Transfer.Pass;
            tBChangeEmail.Text = Transfer.Email;
            tBCangePhone.Text = Transfer.Phone;

            if(buttonChangeUserAccont.Visible == false)
            {
                labelChageEmail.Visible = true;
                labelChangePhone.Visible = true;
                labelChangePass.Visible = true;
                tBCangePhone.Visible = true;
                tBChangeEmail.Visible = true;
                tBChangePass.Visible = true;
                buttonChangeUserAccont.Visible = true;
            } else
            {
                labelChageEmail.Visible = false;
                labelChangePhone.Visible = false;
                labelChangePass.Visible = false;
                tBCangePhone.Visible = false;
                tBChangeEmail.Visible = false;
                tBChangePass.Visible = false;
                buttonChangeUserAccont.Visible = false;
            }
        }

        private void buttonChangeUserAccont_Click(object sender, EventArgs e)
        {
            if(tBCangePhone.Text != Transfer.Phone)
            {
                UserAccount account = new UserAccount();
                account.change_phone_number(Transfer.Doc_num, tBCangePhone.Text);
                tBCangePhone.Text = Transfer.Phone;
            }

            if (tBChangeEmail.Text != Transfer.Email)
            {
                UserAccount account = new UserAccount();
                account.change_phone_number(Transfer.Doc_num, tBChangeEmail.Text);
                tBChangeEmail.Text = Transfer.Email;
            }

            if (tBChangePass.Text != Transfer.Pass)
            {
                UserAccount account = new UserAccount();
                account.change_phone_number(Transfer.Doc_num, tBChangePass.Text);
                tBChangePass.Text = Transfer.Pass;
            }

        }
    }
}
