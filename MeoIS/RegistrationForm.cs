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
        public void formatting_tBDocNumber()
        {
            tBDocNumber.Text = "Введите номер документа";
            tBDocNumber.ForeColor = Color.Gray;
        }

        public void formatting_tBPass()
        {
            tBPass.Text = "Введите пароль";
            tBPass.ForeColor = Color.Gray;
            tBPass.PasswordChar = (char)0;
        }

        public void formatting_tBNameUser()
        {
            tBNameUser.Text = "Введите имя";
            tBNameUser.ForeColor = Color.Gray;
        }

        public void formatting_tBLastName()
        {
            tBLastName.Text = "Введите фамилию";
            tBLastName.ForeColor = Color.Gray;
        }

        public void formatting_tBPatronymic()
        {
            tBPatronymic.Text = "Введите отчество";
            tBPatronymic.ForeColor = Color.Gray;
        }

        public void formatting_tBCity()
        {
            tBCity.Text = "Введите город";
            tBCity.ForeColor = Color.Gray;
        }

        public void formatting_tBDistrict()
        {
            tBDistrict.Text = "Введите район";
            tBDistrict.ForeColor = Color.Gray;
        }

        public void formatting_tBPhone()
        {
            tBPhone.Text = "Введите номер телефона";
            tBPhone.ForeColor = Color.Gray;
        }

        public void formatting_tBEmail()
        {
            tBEmail.Text = "Введите email";
            tBEmail.ForeColor = Color.Gray;
        }

        public void formatting_tBStatus()
        {
            tBStatus.Text = "Выберите статус";
            tBStatus.ForeColor = Color.Gray;
        }

        public RegistrationForm()
        {
            InitializeComponent();

            formatting_tBCity();
            formatting_tBDistrict();
            formatting_tBDocNumber();
            formatting_tBEmail();
            formatting_tBLastName();
            formatting_tBNameUser();
            formatting_tBPass();
            formatting_tBPatronymic();
            formatting_tBPhone();
            formatting_tBStatus();
        }

        public Boolean checkLoggin()
        {
            DataBase DB_Log = new DataBase();
            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `document_number` = @Log", DB_Log.getConnection());
            command.Parameters.Add("@Log", MySqlDbType.VarChar).Value = tBDocNumber.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Данный номер документа уже зарегистрирован!");
                return true;
            }
            else
            {
                return false;
            }
        }

        private void buttonRegReg_Click(object sender, EventArgs e)
        {
            if (checkLoggin())
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
                formatting_tBDocNumber();
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
                formatting_tBPass();
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
                formatting_tBNameUser();
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
                formatting_tBLastName();
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
                formatting_tBPatronymic();
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
                formatting_tBCity();
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
                formatting_tBDistrict();
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
                formatting_tBPhone();
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
                formatting_tBEmail();
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
                formatting_tBStatus();
            }
        }
    }
    
}
