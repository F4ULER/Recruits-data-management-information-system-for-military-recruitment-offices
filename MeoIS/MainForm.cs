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

            tabControlMenuServices.Visible = false;
            if (Transfer.Doc_num != "")
            {
                
                //labelExit.Visible = true;
                //labelEnterReg.Visible = false;
                

                labelWelcome.Text = "Добрый день, " + Transfer.Name;
                labelCategory.Text = "Категория: " + Transfer.Category;
                labelRectal.Text = "Военкомат города: " + Transfer.City;

            }
            else
            {
                labelWelcome.Visible = false;
                labelCategory.Visible = false;
                labelChangeMilitaryRegistrationOffice.Visible = false;
                labelRectal.Visible = false;
                pictureOptions.Visible = false;
                
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
            tabControlMenuServices.Visible = true;
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

        private void buttonOldEnlistmentOffice_Click(object sender, EventArgs e)
        {
            string[] city = tBNewAddress.Text.Split(new char[] { ',' });

            Military_registration_and_enlistment_office Enlistment_Office = new Military_registration_and_enlistment_office();
            if(Enlistment_Office.change_military_registration_and_enlistment_office(Transfer.Doc_num, city[0]) == true)
            {
                labelRectal.Text = "Военкомат города: " + Transfer.City;
                tabControlMenuServices.Visible = false;
            }

        }

        private void monday_MouseMove(object sender, MouseEventArgs e)
        {
            monday.BackColor = Color.LightBlue;
        }

        private void monday_MouseLeave(object sender, EventArgs e)
        {
            monday.BackColor = Color.White;
        }

        private void Wednesday_MouseMove(object sender, MouseEventArgs e)
        {
            Wednesday.BackColor = Color.LightBlue;
        }

        private void Wednesday_MouseLeave(object sender, EventArgs e)
        {
            Wednesday.BackColor = Color.White;
        }

        private void Friday_MouseMove(object sender, MouseEventArgs e)
        {
            Friday.BackColor = Color.LightBlue;
        }

        private void Friday_MouseLeave(object sender, EventArgs e)
        {
            Friday.BackColor = Color.White;
        }

        private void cBMonday_MouseMove(object sender, MouseEventArgs e)
        {
            monday.BackColor = Color.LightBlue;
        }

        private void cBMonday_MouseLeave(object sender, EventArgs e)
        {
            monday.BackColor = Color.White;
        }

        private void cBWednesday_MouseMove(object sender, MouseEventArgs e)
        {
            Wednesday.BackColor = Color.LightBlue;
        }

        private void cBWednesday_MouseLeave(object sender, EventArgs e)
        {
            Wednesday.BackColor = Color.White;
        }

        private void cBFriday_MouseMove(object sender, MouseEventArgs e)
        {
            Friday.BackColor = Color.LightBlue;
        }

        private void cBFriday_MouseLeave(object sender, EventArgs e)
        {
            Friday.BackColor = Color.White;
        }

        private void labelRecordingCompleteMonday_MouseMove(object sender, MouseEventArgs e)
        {
            monday.BackColor = Color.LightBlue;
        }

        private void labelRecordingCompleteMonday_MouseLeave(object sender, EventArgs e)
        {
            monday.BackColor = Color.White;
        }

        private void labelRecordingCompleteWensday_MouseMove(object sender, MouseEventArgs e)
        {
            Wednesday.BackColor = Color.LightBlue;
        }

        private void labelRecordingCompleteWensday_MouseLeave(object sender, EventArgs e)
        {
            Wednesday.BackColor = Color.White;
        }

        private void labelRecordingCompleteFriday_MouseMove(object sender, MouseEventArgs e)
        {
            Friday.BackColor = Color.LightBlue;
        }

        private void labelRecordingCompleteFriday_MouseLeave(object sender, EventArgs e)
        {
            Friday.BackColor = Color.White;
        }

        int k = 0;
        protected void change_date(bool key)
        {

            labelMonday.Text = "Понедельник \n";
            labelWensday.Text = "Среда \n";
            labelFriday.Text = "Пятница \n";

            //поиск даты понедельника
            var date = DateTime.Now.AddDays(k); ;
            var difference = date.DayOfWeek - DayOfWeek.Monday;
            if (difference < 0)
                difference += 7;
            var mondayDate = date.AddDays(-1 * difference).Date;
            
            labelMonday.Text += mondayDate.ToString("d");
            labelWensday.Text += mondayDate.AddDays(2).ToString("d");
            labelFriday.Text += mondayDate.AddDays(4).ToString("d");
        }

        private void buttonMed_Click(object sender, EventArgs e)
        {
            
        }

        private void tabControlMenuServices_Enter(object sender, EventArgs e)
        {
            //поиск даты понедельника
            var date = DateTime.Today;
            MessageBox.Show(date.DayOfWeek.ToString());
            if(date.DayOfWeek.ToString() == "Sunday" || date.DayOfWeek.ToString() == "Saturday" || date.DayOfWeek.ToString() == "Friday")
            {
                var difference = date.DayOfWeek - DayOfWeek.Monday;
                if (difference < 0)
                    difference += 7;
                var mondayDate = date.AddDays(-1 * difference).Date;

                labelMonday.Text += mondayDate.ToString();
                labelWensday.Text += mondayDate.AddDays(2).ToString();
                labelFriday.Text += mondayDate.AddDays(4).ToString();
            }
            else
            {
                date = date.AddDays(3);
                var difference = date.DayOfWeek - DayOfWeek.Monday;
                if (difference < 0)
                    difference += 7;
                var mondayDate = date.AddDays(-1 * difference).Date;

                labelMonday.Text += mondayDate.ToString();
                labelWensday.Text += mondayDate.AddDays(2).ToString();
                labelFriday.Text += mondayDate.AddDays(4).ToString();
            }
            
        }

        private void labelNextWeek_Click(object sender, EventArgs e)
        {
            k += 7;
            change_date(true);
        }

        private void labelPreviousWeek_Click(object sender, EventArgs e)
        {
            k -= 7;
            change_date(false);
        }
    }
}
