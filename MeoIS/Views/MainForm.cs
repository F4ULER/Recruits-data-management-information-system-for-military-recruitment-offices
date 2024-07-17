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
    //пользовательская панель
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            tabControlMenuServices.Visible = false;
            pictureCloseServises.Visible = false;
            labelExit.Visible = false;


            
            if (Transfer.Doc_num != "") // если вошел зарегистрированный пользователь
            {

                //labelExit.Visible = true;
                //labelEnterReg.Visible = false;

                pictureMedicalData.Visible = true;
                labelWelcome.Text = "Добрый день, " + Transfer.Name;
                labelCategory.Text = "Категория: " + Transfer.Category;
                labelRectal.Text = "Военкомат города: " + Transfer.City;
                groupBoxServices.Visible = true;
                labelExit.Visible = true;
                labelLogIn.Visible = false;
                labelWelcome1.Visible = false;
                labelWelcome2.Visible = false;
                labelWelcome3.Visible = false;
                labelLine.Visible = false;
            }
            else // если вошел незарегистрированный пользователь
            {
                pictureMedicalData.Visible = false;
                groupBoxServices.Visible = false;
                labelWelcome.Visible = false;
                labelCategory.Visible = false;
                labelChangeMilitaryRegistrationOffice.Visible = false;
                labelRectal.Visible = false;
                pictureOptions.Visible = false;
                labelExit.Visible = false;
                labelLogIn.Visible = true;
                labelWelcome1.Visible = true;
                labelWelcome2.Visible = true;
                labelWelcome3.Visible = true;
                labelLine.Visible = true;
            }
        }

        //кнопка выхода из аккаунта
        private void labelExit_Click(object sender, EventArgs e)
        {
            Transfer.Name = "";
            labelWelcome.Text = "";
            this.Hide();
            labelLogIn.Visible = true;
            labelExit.Visible = false;
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Закрытие всего приложения
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }

        // поиск по справочнику литературы в поисковой строке
        private void picSearch_Click(object sender, EventArgs e)
        {
            groupBoxServices.Visible = false;

            Search_note search = new Search_note();
            DataTable table = new DataTable();
            table = search.search_literature(tBSearch.Text);
            if(table.Rows.Count > 0)
            {
                dataGV.DataSource = table;
                dataGV.Visible = true;
            }
            else
            {
                MessageBox.Show("Не найдено ни одной записи");
                pictureCloseServises.Visible = false;
            }

            if (dataGV.Visible == true || tabControlMenuServices.Visible == true) { pictureCloseServises.Visible = true; }
        }

        private void labelChangeMilitaryRegistrationOffice_Click(object sender, EventArgs e)
        {
            tabControlMenuServices.Visible = true;
            groupBoxServices.Visible = false;
        }

       // параметры пользователя (значек шестеренки)
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

        // изменение номера телефона и/или электронной почты и/или пароля пользователем (значок шестеренки кнопка сохранить)
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
                account.change_email(Transfer.Doc_num, tBChangeEmail.Text);
                tBChangeEmail.Text = Transfer.Email;
            }

            if (tBChangePass.Text != Transfer.Pass)
            {
                UserAccount account = new UserAccount();
                account.change_password(Transfer.Doc_num, tBChangePass.Text);
                tBChangePass.Text = Transfer.Pass;
            }

        }

        //постановка на учет в новый военкомат
        private void buttonOldEnlistmentOffice_Click(object sender, EventArgs e)
        {
            if(tBEnlistmentOfficeWhereRegistered.Text != "" && tBNewAddress.Text != "")
            {
                string[] city = tBNewAddress.Text.Split(new char[] { ',' });

                Military_registration_and_enlistment_office Enlistment_Office = new Military_registration_and_enlistment_office();
                if (Enlistment_Office.change_military_registration_and_enlistment_office(Transfer.Doc_num, city[0]) == true)
                {
                    labelRectal.Text = "Военкомат города: " + Transfer.City;
                    tBNewAddress.Text = "";
                    tBEnlistmentOfficeWhereRegistered.Text = "";
                    tabControlMenuServices.Visible = false;
                } 
                else { MessageBox.Show("Ошибка!"); }
                tabControlMenuServices.Visible = false;
                pictureCloseServises.Visible = false;
                groupBoxServices.Visible = true;
            }
            else
            {
                MessageBox.Show("Заполните все поля!");
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

        int k = 0; //счетчик недель для мед осмотра

        //изменение даты в мед осморте
        protected void change_date()
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

        //кнопка "записаться" в мед осмотре
        private void buttonMed_Click(object sender, EventArgs e)
        {
            if (cBMonday.Text != "" || cBWednesday.Text != "" || cBFriday.Text != "")
            {
                string[] date;
                string title = "";
                string time = "";

                if (cBFriday.Text == "" && cBWednesday.Text == "")
                {
                    title = labelMonday.Text;
                    time = cBMonday.Text;
                }
                else if (cBMonday.Text == "" && cBFriday.Text == "")
                {
                    title = labelWensday.Text;
                    time = cBWednesday.Text;
                }
                else if (cBMonday.Text == "" && cBWednesday.Text == "")
                {
                    title = labelFriday.Text;
                    time = cBFriday.Text;
                }
                else
                {
                    MessageBox.Show("Нельзя выбирать больше одной даты в неделю.");
                }

                if (title != "")
                {
                    date = title.Split(new char[] { '\n' });

                    Military_registration_and_enlistment_office Enlistment_Office = new Military_registration_and_enlistment_office();
                    Enlistment_Office.registration_for_medical_check_up(Transfer.Doc_num, Transfer.City, date[1], time);

                    cBMonday.SelectedIndex = 0;
                    cBWednesday.SelectedIndex = 0;
                    cBFriday.SelectedIndex = 0;
                    tabControlMenuServices.Visible = false;
                    pictureCloseServises.Visible = false;
                    groupBoxServices.Visible = true;
                }
            }
            else
            {
                MessageBox.Show("Выберите дату и время.");
            }
        }

        //поиск даты ближайшего понедельника
        private void tabControlMenuServices_Enter(object sender, EventArgs e)
        {
            var date = DateTime.Today;
            if(date.DayOfWeek.ToString() == "Sunday" || date.DayOfWeek.ToString() == "Saturday" || date.DayOfWeek.ToString() == "Friday")
            {
                var difference = date.DayOfWeek - DayOfWeek.Monday;
                if (difference < 0)
                    difference += 7;
                var mondayDate = date.AddDays(-1 * difference).Date;

                labelMonday.Text += mondayDate.ToString("d");
                labelWensday.Text += mondayDate.AddDays(2).ToString("d");
                labelFriday.Text += mondayDate.AddDays(4).ToString("d");
            }
            else
            {
                date = date.AddDays(3);
                var difference = date.DayOfWeek - DayOfWeek.Monday;
                if (difference < 0)
                    difference += 7;
                var mondayDate = date.AddDays(-1 * difference).Date;

                labelMonday.Text += mondayDate.ToString("d");
                labelWensday.Text += mondayDate.AddDays(2).ToString("d");
                labelFriday.Text += mondayDate.AddDays(4).ToString("d");
            }
        }

        //следущая неделя
        private void labelNextWeek_Click(object sender, EventArgs e)
        {
            k += 7;
            change_date();
        }

        // предыдущая неделя
        private void labelPreviousWeek_Click(object sender, EventArgs e)
        {
            k -= 7;
            change_date();
        }

        // показывает все поля для изменения места учебы
        private void show_education_objects()
        {
            labelNameOfEducationalOrganization.Visible = true;
            tBNameOfEducationalOrganization.Text = "";
            tBNameOfEducationalOrganization.Visible = true;

            labelNameOfSpecialty.Visible = true;
            tBNameOfSpecialty.Visible = true;
            tBNameOfSpecialty.Text = "";

            labelEnrollmentDate.Visible = true;
            dateTPEnrollmentDate.Visible = true;

            labelDurationOfTraining.Visible = true;
            tBDurationOfTraining.Visible = true;
            tBDurationOfTraining.Text = "";

            labelAddressOfEducationalOrganization.Visible = true;
            tBAddressOfEducationalOrganization.Visible = true;
            tBAddressOfEducationalOrganization.Text = "";

            buttonChangePlaceOfStudyOrWork.Visible = true;
        }

        // скрывает все поля для изменения места учебы
        private void hide_education_objects()
        {
            labelNameOfEducationalOrganization.Visible = false;
            tBNameOfEducationalOrganization.Text = "";
            tBNameOfEducationalOrganization.Visible = false;

            labelNameOfSpecialty.Visible = false;
            tBNameOfSpecialty.Visible = false;
            tBNameOfSpecialty.Text = "";

            labelEnrollmentDate.Visible = false;
            dateTPEnrollmentDate.Visible = false;

            labelDurationOfTraining.Visible = false;
            tBDurationOfTraining.Visible = false;
            tBDurationOfTraining.Text = "";

            labelAddressOfEducationalOrganization.Visible = false;
            tBAddressOfEducationalOrganization.Visible = false;
            tBAddressOfEducationalOrganization.Text = "";

            buttonChangePlaceOfStudyOrWork.Visible = false;
        }

        // показывает все поля для изменения места работы
        private void show_work_objects()
        {
            labelNameOfOrganizationOrIndividualEntrepreneur.Visible = true;
            tBNameOfWorkOrganizationOrIndividualEntrepreneur.Visible = true;
            tBNameOfWorkOrganizationOrIndividualEntrepreneur.Text = "";

            labelJobTitle.Visible = true;
            tBJobTitle.Visible = true;
            tBJobTitle.Text = "";

            labelWorkOrganizationAddress.Visible = true;
            tBWorkOrganizationAddress.Visible = true;
            tBAddressOfEducationalOrganization.Text = "";

            buttonChangePlaceOfStudyOrWork.Visible = true;
        }

        // скрывает все поля для изменения места работы
        private void hide_work_objects()
        {
            labelNameOfOrganizationOrIndividualEntrepreneur.Visible = false;
            tBNameOfWorkOrganizationOrIndividualEntrepreneur.Visible = false;
            tBNameOfWorkOrganizationOrIndividualEntrepreneur.Text = "";

            labelJobTitle.Visible = false;
            tBJobTitle.Visible = false;
            tBJobTitle.Text = "";

            labelWorkOrganizationAddress.Visible = false;
            tBWorkOrganizationAddress.Visible = false;
            tBAddressOfEducationalOrganization.Text = "";

            buttonChangePlaceOfStudyOrWork.Visible = false;
        }

        //переключать учебы и работы
        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if(rBEducation.Checked == true)
            {
                hide_work_objects();
                show_education_objects();

            } else if (rBWork.Checked == true)
            {
                hide_education_objects();
                show_work_objects();
            }
        }

        // кнопка сохрания данных о изменении места учебы или работы
        private void buttonChangePlaceOfStudyOrWork_Click(object sender, EventArgs e)
        {
            if (rBEducation.Checked == true)
            {
                if (tBNameOfEducationalOrganization.Text != "" && tBNameOfSpecialty.Text != "" && tBDurationOfTraining.Text != "" && tBAddressOfEducationalOrganization.Text != "")
                {
                    string message = "INSERT INTO `education`(`document_number`, `Name_of_educational_organization`, `Name_of_specialty`," +
                        " `Enrollment_date`, `Duration_of_training`, `Address_educational_organization`)" +
                        " VALUES (" + Transfer.Doc_num + ", '" + tBNameOfEducationalOrganization.Text + "', '" + tBNameOfSpecialty.Text + "', '" +
                        "" + dateTPEnrollmentDate.Text + "', '" + tBDurationOfTraining.Text + "', '" + tBAddressOfEducationalOrganization.Text + "')";

                    DataBaseConnect DB = new DataBaseConnect();

                    if (DB.sending_command(message) == true)
                    {
                        MessageBox.Show("Место учебы успешно изменено на " + tBNameOfEducationalOrganization.Text);
                    }
                    else MessageBox.Show("Ошибка!");

                    hide_education_objects();
                    defolt_change_of_study_or_job();
                    tabControlMenuServices.Visible = false;
                }
                else
                {
                    MessageBox.Show("Заполните все поля!");
                }

            } else if (rBWork.Checked == true)
            {
                if (tBNameOfWorkOrganizationOrIndividualEntrepreneur.Text != "" && tBWorkOrganizationAddress.Text != "" && tBJobTitle.Text != "")
                {
                    string message = "INSERT INTO `work`(`document_number`, `name_of_work_organization`, `work_organization_address`, `job_title`) " +
                        "VALUES (" + Transfer.Doc_num + ", '" + tBNameOfWorkOrganizationOrIndividualEntrepreneur.Text + "', '" + tBWorkOrganizationAddress.Text + "', '" + tBJobTitle.Text + "')";

                    DataBaseConnect DB = new DataBaseConnect();

                    if (DB.sending_command(message) == true)
                    {
                        MessageBox.Show("Место работы успешно изменено на " + tBNameOfWorkOrganizationOrIndividualEntrepreneur.Text);
                    }
                    else MessageBox.Show("Ошибка!");

                    hide_work_objects();
                    defolt_change_of_study_or_job();
                    tabControlMenuServices.Visible = false;

                } else
                {
                    MessageBox.Show("Заполните все поля!");
                }
            }
        }

        //обычное состояние вкладки смены учебы или работы
        private void defolt_change_of_study_or_job()
        {
            hide_education_objects();
            hide_work_objects();
            rBEducation.Checked = false;
            rBWork.Checked = false;
        }

        private void tPChange_Enter(object sender, EventArgs e)
        {
            defolt_change_of_study_or_job();
        }

        private void labelRegistrationWithEnlistmentOffice_Click(object sender, EventArgs e)
        {
            tabControlMenuServices.Visible = true;
            tabControlMenuServices.SelectedIndex = 0;
            groupBoxServices.Visible = false;
        }

        private void labelSignUpForMedicalExamination_Click(object sender, EventArgs e)
        {
            tabControlMenuServices.Visible = true;
            tabControlMenuServices.SelectedIndex = 1;
            groupBoxServices.Visible = false;
        }

        private void labelApplicationForChangeOfPlaceOfWorkOrStudy_Click(object sender, EventArgs e)
        {
            tabControlMenuServices.Visible = true;
            tabControlMenuServices.SelectedIndex = 2;
            groupBoxServices.Visible = false;
        }

        private void tabControlMenuServices_VisibleChanged(object sender, EventArgs e)
        {
            if (tabControlMenuServices.Visible == true) pictureCloseServises.Visible = true;
        }

        // отображение таблицы посещения врачей в военкомате (иконка медицинского планшета)
        private void pictureMedicalData_Click(object sender, EventArgs e)
        {
            tabControlMenuServices.Visible = false;
            groupBoxServices.Visible = false;
            pictureCloseServises.Visible = true;

            Search_note search = new Search_note();
            DataTable table = new DataTable();
            table = search.searchMedicalData(Transfer.Doc_num);
            if (table.Rows.Count > 0)
            {
                dataGV.DataSource = table;
                dataGV.Visible = true;
            }
            else
            {
                MessageBox.Show("Не найдено ни одной записи");
            }
        }

        private void pictureCloseServises_Click(object sender, EventArgs e)
        {
            pictureCloseServises.Visible = false;
            dataGV.Visible = false;
            tabControlMenuServices.Visible = false;
            groupBoxServices.Visible = true;
            tBSearch.Text = "";

        }

        // открытие окна аутентификации (кнопка вход)
        private void labelLogIn_Click(object sender, EventArgs e)
        {
            labelLogIn.Visible = false;
            labelExit.Visible = true;
            AuthenticationForm authenticationForm = new AuthenticationForm();
            authenticationForm.Show();
            this.Hide();
        }

        private void buttonFirstReg_Click(object sender, EventArgs e)
        {
            RegistrationForm reg = new RegistrationForm();
            reg.Show();
        }
    }
}
