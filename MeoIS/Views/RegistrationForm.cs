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
    //класс регистрации
    public partial class RegistrationForm : Form
    {
        //установка серого цвета, если поле пустое (номер документа)
        public void set_gray_text_in_tBDocumentNumber()
        {
            tBDocNumber.Text = "Введите номер документа";
            tBDocNumber.ForeColor = Color.Gray;
        }

        //установка серого цвета, если поле пустое (пароль)
        public void set_gray_text_in_tBPass()
        {
            tBPass.Text = "Введите пароль";
            tBPass.ForeColor = Color.Gray;
            tBPass.PasswordChar = (char)0;
        }

        //установка серого цвета, если поле пустое (имя пользователя)
        public void set_gray_text_in_tBNameUser()
        {
            tBNameUser.Text = "Введите имя";
            tBNameUser.ForeColor = Color.Gray;
        }

        //установка серого цвета, если поле пустое (фамилия пользователя)
        public void set_gray_text_in_tBLastName()
        {
            tBLastName.Text = "Введите фамилию";
            tBLastName.ForeColor = Color.Gray;
        }

        //установка серого цвета, если поле пустое (отчество пользователя)
        public void set_gray_text_in_tBPatronymic()
        {
            tBPatronymic.Text = "Введите отчество";
            tBPatronymic.ForeColor = Color.Gray;
        }

        //установка серого цвета, если поле пустое (возраст)
        public void set_grey_text_in_tBAge()
        {
            tBAge.Text = "Введите дату рождения";
            tBAge.ForeColor = Color.Gray;
        }

        //установка серого цвета, если поле пустое (номер телефона)
        public void set_gray_text_in_tBPhone()
        {
            tBPhone.Text = "Введите номер телефона";
            tBPhone.ForeColor = Color.Gray;
        }

        //установка серого цвета, если поле пустое (электронная почта)
        public void set_gray_text_in_tBEmail()
        {
            tBEmail.Text = "Введите email";
            tBEmail.ForeColor = Color.Gray;
        }

        //установка серого цвета, если поле пустое (категория годности)
        public void set_gray_text_in_tBStatus()
        {
            tBCategory.Text = "Введите категорию годности";
            tBCategory.ForeColor = Color.Gray;
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
            tBAge.Visible = false;
            tBPhone.Visible = false;
            tBEmail.Visible = false;

            set_grey_text_in_tBAge();
            set_gray_text_in_tBDocumentNumber();
            set_gray_text_in_tBEmail();
            set_gray_text_in_tBLastName();
            set_gray_text_in_tBNameUser();
            set_gray_text_in_tBPass();
            set_gray_text_in_tBPatronymic();
            set_gray_text_in_tBPhone();
            set_gray_text_in_tBStatus();
            set_grey_text_in_tBAge();
        }

        // проверка заполнения полей
        public Boolean сheckCompletedInputFields()
        {
            string[] mass = new string[] { tBDocNumber.Text, tBPass.Text, tBCategory.Text, tBNameUser.Text, tBLastName.Text, tBPatronymic.Text, tBAge.Text, tBPhone.Text, tBEmail.Text};
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

        // добавление пользователя в базу данных
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

            if (log.check_email(tBEmail.Text))
            {
                return;
            }

            if (log.check_phone_number(tBPhone.Text))
            {
                return;
            }

            User_data user_Data = new User_data();
            DataTable table = new DataTable();

            string gender = "";
            if (rBM.Checked == false)
            {
                gender = "М";
            }
            else gender = "Ж";

            if (user_Data.addUser(tBDocNumber.Text, tBPass.Text, tBLastName.Text, tBNameUser.Text, tBPatronymic.Text, tBAge.Text, tBCategory.Text, gender,"", tBPhone.Text, tBEmail.Text))
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
            if (tBCategory.Text == "Введите категорию годности")
            {
                tBCategory.Text = "";
                tBCategory.ForeColor = Color.Black;
            }
        }

        private void tBStatus_Leave(object sender, EventArgs e)
        {
            if (tBCategory.Text == "")
            {
                set_gray_text_in_tBStatus();
            }
        }
        private void tBAge_Enter(object sender, EventArgs e)
        {
            if (tBAge.Text == "Введите дату рождения")
            {
                tBAge.Text = "";
                tBAge.ForeColor = Color.Black;
            }
        }

        private void tBAge_Leave(object sender, EventArgs e)
        {
            if (tBAge.Text == "")
            {
                set_grey_text_in_tBAge();
            }
        }

        // переключатель "далее"
        private void buttonContinue_Click(object sender, EventArgs e)
        {
            if(tBDocNumber.Visible == true)
            {
                tBDocNumber.Visible = false;
                tBPass.Visible = false;
                tBCategory.Visible = false;
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
                tBAge.Visible = true;
                tBPhone.Visible = true;
                tBEmail.Visible = true;
                buttonReg.Visible = true;
                buttonContinue.Visible = false;
            } 
        }

        // переключатель "назад"
        private void buttonBack_Click(object sender, EventArgs e)
        {
            buttonReg.Visible = false;
            if (tBNameUser.Visible == true)
            {
                tBDocNumber.Visible = true;
                tBPass.Visible = true;
                tBCategory.Visible = true;
                tBLastName.Visible = false;
                tBNameUser.Visible = false;
                tBPatronymic.Visible = false;
                rBF.Visible = false;
                rBM.Visible = false;
                labelGender.Visible = false;
                buttonBack.Visible = false;
            }
            else if (tBAge.Visible == true)
            {
                tBLastName.Visible = true;
                tBNameUser.Visible = true;
                tBPatronymic.Visible = true;
                tBAge.Visible = false;
                tBPhone.Visible = false;
                tBEmail.Visible = false;
                rBF.Visible = true;
                rBM.Visible = true;
                labelGender.Visible = true;
                buttonContinue.Visible = true;
            }
        }

        //закрытие приложения
        private void RegistrationForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }

        // возвращение к окну входа в  систему
        private void labelExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
