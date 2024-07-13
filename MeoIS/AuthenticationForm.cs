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
    public partial class AuthenticationForm : Form
    {
        public AuthenticationForm()
        {
            InitializeComponent();

            Transfer.Doc_num = "ERROR";

            textBoxLogin.Text = "Введите номер документа";
            textBoxLogin.ForeColor = Color.Gray;

            textBoxPass.Text = "Введите пароль";
            textBoxPass.ForeColor = Color.Gray;
            textBoxPass.PasswordChar = (char)0;
        }

        // аутентификация пользователя
        private void buttonAuthEnter_Click(object sender, EventArgs e)
        {

            string log = textBoxLogin.Text;
            string pass = textBoxPass.Text;

            DataBaseConnect DB_users = new DataBaseConnect();
            DataTable table_users = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `document_number` = @Log AND `password` = @Pass", DB_users.getConnection());
            command.Parameters.Add("@Log", MySqlDbType.VarChar).Value = log;
            command.Parameters.Add("@Pass", MySqlDbType.VarChar).Value = pass;

            adapter.SelectCommand = command;
            adapter.Fill(table_users);

            if (table_users.Rows.Count > 0)
            {

                Transfer.Doc_num = log;
                
                for(int i = 3; i < 6; i++)
                {
                    Transfer.Name += table_users.Rows[0][i].ToString() + " ";
                }
                Transfer.Category = table_users.Rows[0][7].ToString();
                Transfer.City = table_users.Rows[0][9].ToString();
                Transfer.Pass = pass;
                Transfer.Email = table_users.Rows[0][11].ToString();
                Transfer.Phone = table_users.Rows[0][10].ToString();

                textBoxLogin.Text = "";
                textBoxPass.Text = "";

                if(table_users.Rows[0][12].ToString() == "user")
                {
                    MainForm form = new MainForm();
                    form.Show();
                    //this.Hide();
                } else if (table_users.Rows[0][12].ToString() == "admin")
                {
                    Admin_panel form = new Admin_panel();
                    form.Show();
                    //this.Hide();
                } else { MessageBox.Show("Ошибка!"); }
            }
            else
            {
                MessageBox.Show("Неверный номер документа или пароль!");
            }
        }
        private void textBoxLogin_Enter(object sender, EventArgs e)
        {
            if (textBoxLogin.Text == "Введите номер документа")
            {
                textBoxLogin.Text = "";
                textBoxLogin.ForeColor = Color.Black;
            }
        }

        private void textBoxLogin_Leave(object sender, EventArgs e)
        {
            if (textBoxLogin.Text == "")
            {
                textBoxLogin.Text = "Введите номер документа";
                textBoxLogin.ForeColor = Color.Gray;
            }
        }

        private void textBoxPass_Enter(object sender, EventArgs e)
        {
            if (textBoxPass.Text == "Введите пароль")
            {
                textBoxPass.Text = "";
                textBoxPass.ForeColor = Color.Black;
                textBoxPass.PasswordChar = '*';
            }
        }

        private void textBoxPass_Leave(object sender, EventArgs e)
        {
            if (textBoxPass.Text == "")
            {
                textBoxPass.Text = "Введите пароль";
                textBoxPass.ForeColor = Color.Gray;
                textBoxPass.PasswordChar = (char)0;
            }
        }

        private void buttonReg_Click(object sender, EventArgs e)
        {
            //this.Hide();
            RegistrationForm reg = new RegistrationForm();
            reg.Show();
        }

        private void AuthenticationForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Закрытие всего приложения
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }

        private void buttonWithoutReg_Click(object sender, EventArgs e)
        {
            Transfer.Doc_num = "";
            MainForm form = new MainForm();

            form.Show();
            //this.Hide();
        }
    }
}
