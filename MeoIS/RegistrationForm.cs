using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeoIS
{
    public partial class RegistrationForm : Form
    {
        public void set_gray_text_in_tBDocumentNumber()
        {
            tBDocNumber.Text = "Введите номер документа";
            tBDocNumber.ForeColor = Color.Gray;
        }

        public void set_gray_text_in_tBPass()
        {
            tBPass.Text = "Введите пароль";
            tBPass.ForeColor = Color.Gray;
            tBPass.PasswordChar = (char)0;
        }

        public void set_gray_text_in_tBNameUser()
        {
            tBNameUser.Text = "Введите имя";
            tBNameUser.ForeColor = Color.Gray;
        }

        public void set_gray_text_in_tBLastName()
        {
            tBLastName.Text = "Введите фамилию";
            tBLastName.ForeColor = Color.Gray;
        }

        public void set_gray_text_in_tBPatronymic()
        {
            tBPatronymic.Text = "Введите отчество";
            tBPatronymic.ForeColor = Color.Gray;
        }

        public void set_gray_text_in_tBCity()
        {
            tBCity.Text = "Введите город";
            tBCity.ForeColor = Color.Gray;
        }

        public void set_gray_text_in_tBDistrict()
        {
            tBDistrict.Text = "Введите район";
            tBDistrict.ForeColor = Color.Gray;
        }

        public void set_gray_text_in_tBPhone()
        {
            tBPhone.Text = "Введите номер телефона";
            tBPhone.ForeColor = Color.Gray;
        }

        public void set_gray_text_in_tBEmail()
        {
            tBEmail.Text = "Введите email";
            tBEmail.ForeColor = Color.Gray;
        }

        public void set_gray_text_in_tBStatus()
        {
            tBStatus.Text = "Выберите статус";
            tBStatus.ForeColor = Color.Gray;
        }

        public RegistrationForm()
        {
            InitializeComponent();

            buttonReg.Visible = false;
            buttonBack.Visible = false;
            tBNameUser.Visible = false;
            tBLastName.Visible = false;
            tBPatronymic.Visible = false;
            rBF.Visible = false;
            rBM.Visible = false;
            labelGender.Visible = false;
            tBCity.Visible = false;
            tBDistrict.Visible = false;
            tBPhone.Visible = false;
            tBEmail.Visible = false;

            set_gray_text_in_tBCity();
            set_gray_text_in_tBDistrict();
            set_gray_text_in_tBDocumentNumber();
            set_gray_text_in_tBEmail();
            set_gray_text_in_tBLastName();
            set_gray_text_in_tBNameUser();
            set_gray_text_in_tBPass();
            set_gray_text_in_tBPatronymic();
            set_gray_text_in_tBPhone();
            set_gray_text_in_tBStatus();
        }

        

        public Boolean сheckCompletedInputFields()
        {
            string[] mass = new string[] { tBDocNumber.Text, tBPass.Text, tBStatus.Text, tBNameUser.Text, tBLastName.Text, tBPatronymic.Text, tBPhone.Text, tBEmail.Text, tBCity.Text, tBDistrict.Text};
            bool trouble = false;

            for (int i = 0; i < 10; i++)
            {
                if (mass[i] == "" || mass[i].IndexOf("Введите") == 0)
                {
                    trouble = true;
                }
            }
            if (trouble == true)
            {
                MessageBox.Show("Заполните все поля!");
                return true;
            }
            else
            {
                return false;
            }
        }

        private void buttonRegReg_Click(object sender, EventArgs e)
        {
            LogIn log = new LogIn();
            if (сheckCompletedInputFields())
            {
                return;
            }

            if (log.check_document_number(tBDocNumber.Text))
            {
                return;
            }

            DataBase DB_Reg = new DataBase();
            DataTable table = new DataTable();

            bool gender = true;
            if(rBM.Checked == false)
            {
                gender = false;
            }

            if (DB_Reg.addUser(tBDocNumber.Text, tBPass.Text, tBLastName.Text, tBNameUser.Text, tBPatronymic.Text, tBStatus.Text, gender, tBCity.Text, tBPhone.Text, tBEmail.Text))
            {
                MessageBox.Show("Регистрация прошла успешно!");
                AuthenticationForm form = new AuthenticationForm();
                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Ошибка!");
            }
        }

        private void tBDocNumber_Enter(object sender, EventArgs e)
        {
            if (tBDocNumber.Text == "Введите номер документа")
            {
                tBDocNumber.Text = "";
                tBDocNumber.ForeColor = Color.Black;
            }
        }

        private void tBDocNumber_Leave(object sender, EventArgs e)
        {
            if (tBDocNumber.Text == "")
            {
                set_gray_text_in_tBDocumentNumber();
            }
        }

        private void tBPass_Enter(object sender, EventArgs e)
        {
            if (tBPass.Text == "Введите пароль")
            {
                tBPass.Text = "";
                tBPass.ForeColor = Color.Black;
                tBPass.PasswordChar = '*';
            }
        }

        private void tBPass_Leave(object sender, EventArgs e)
        {
            if (tBPass.Text == "")
            {
                set_gray_text_in_tBPass();
            }
        }

        private void tBNameUser_Enter(object sender, EventArgs e)
        {
            if (tBNameUser.Text == "Введите имя")
            {
                tBNameUser.Text = "";
                tBNameUser.ForeColor = Color.Black;
            }
        }

        private void tBNameUser_Leave(object sender, EventArgs e)
        {
            if (tBNameUser.Text == "")
            {
                set_gray_text_in_tBNameUser();
            }
        }

        private void tBLastName_Enter(object sender, EventArgs e)
        {
            if (tBLastName.Text == "Введите фамилию")
            {
                tBLastName.Text = "";
                tBLastName.ForeColor = Color.Black;
            }
        }

        private void tBLastName_Leave(object sender, EventArgs e)
        {
            if (tBLastName.Text == "")
            {
                set_gray_text_in_tBLastName();
            }
        }

        private void tBPatronymic_Enter(object sender, EventArgs e)
        {
            if (tBPatronymic.Text == "Введите отчество")
            {
                tBPatronymic.Text = "";
                tBPatronymic.ForeColor = Color.Black;
            }
        }

        private void tBPatronymic_Leave(object sender, EventArgs e)
        {
            if (tBPatronymic.Text == "")
            {
                set_gray_text_in_tBPatronymic();
            }
        }

        private void tBCity_Enter(object sender, EventArgs e)
        {
            if (tBCity.Text == "Введите город")
            {
                tBCity.Text = "";
                tBCity.ForeColor = Color.Black;
            }
        }

        private void tBCity_Leave(object sender, EventArgs e)
        {
            if (tBCity.Text == "")
            {
                set_gray_text_in_tBCity();
            }
        }

        private void tBDistrict_Enter(object sender, EventArgs e)
        {
            if (tBDistrict.Text == "Введите район")
            {
                tBDistrict.Text = "";
                tBDistrict.ForeColor = Color.Black;
            }
        }

        private void tBDistrict_Leave(object sender, EventArgs e)
        {
            if (tBDistrict.Text == "")
            {
                set_gray_text_in_tBDistrict();
            }
        }

        private void tBPhone_Enter(object sender, EventArgs e)
        {
            if (tBPhone.Text == "Введите номер телефона")
            {
                tBPhone.Text = "";
                tBPhone.ForeColor = Color.Black;
            }
        }

        private void tBPhone_Leave(object sender, EventArgs e)
        {
            if (tBPhone.Text == "")
            {
                set_gray_text_in_tBPhone();
            }
        }

        private void tBEmail_Enter(object sender, EventArgs e)
        {
            if (tBEmail.Text == "Введите email")
            {
                tBEmail.Text = "";
                tBEmail.ForeColor = Color.Black;
            }
        }

        private void tBEmail_Leave(object sender, EventArgs e)
        {
            if (tBEmail.Text == "")
            {
                set_gray_text_in_tBEmail();
            }
        }

        private void tBStatus_Enter(object sender, EventArgs e)
        {
            if (tBStatus.Text == "Выберите статус")
            {
                tBStatus.Text = "";
                tBStatus.ForeColor = Color.Black;
            }
        }

        private void tBStatus_Leave(object sender, EventArgs e)
        {
            if (tBStatus.Text == "")
            {
                set_gray_text_in_tBStatus();
            }
        }

        private void buttonContinue_Click(object sender, EventArgs e)
        {
            if(tBDocNumber.Visible == true)
            {
                tBDocNumber.Visible = false;
                tBPass.Visible = false;
                tBStatus.Visible = false;
                tBLastName.Visible = true;
                tBNameUser.Visible = true;
                tBPatronymic.Visible = true;
                rBF.Visible = true;
                rBM.Visible = true;
                labelGender.Visible = true;
                buttonBack.Visible = true;
            } else if (tBNameUser.Visible == true)
            {
                tBLastName.Visible = false;
                tBNameUser.Visible = false;
                tBPatronymic.Visible = false;
                rBF.Visible = false;
                rBM.Visible = false;
                labelGender.Visible = false;
                tBCity.Visible = true;
                tBDistrict.Visible = true;
                tBPhone.Visible = true;
                tBEmail.Visible = true;
                buttonReg.Visible = true;
                buttonContinue.Visible = false;
            } 
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            if (tBNameUser.Visible == true)
            {
                tBDocNumber.Visible = true;
                tBPass.Visible = true;
                tBStatus.Visible = true;
                tBLastName.Visible = false;
                tBNameUser.Visible = false;
                tBPatronymic.Visible = false;
                rBF.Visible = false;
                rBM.Visible = false;
                labelGender.Visible = false;
                buttonBack.Visible = false;
            }
            else if (tBCity.Visible == true)
            {
                tBLastName.Visible = true;
                tBNameUser.Visible = true;
                tBPatronymic.Visible = true;
                tBCity.Visible = false;
                tBDistrict.Visible = false;
                tBPhone.Visible = false;
                tBEmail.Visible = false;
                rBF.Visible = true;
                rBM.Visible = true;
                labelGender.Visible = true;
                buttonContinue.Visible = true;
            }
        }

        private void RegistrationForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }
    }
}
