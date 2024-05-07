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

            textBoxLogin.Text = "Введите номер документа";
            textBoxLogin.ForeColor = Color.Gray;

            textBoxPass.Text = "Введите пароль";
            textBoxPass.ForeColor = Color.Gray;
            textBoxPass.PasswordChar = (char)0;
        }

        private void buttonAuthEnter_Click(object sender, EventArgs e)
        {
            string log = textBoxLogin.Text;
            string pass = textBoxPass.Text;

            DataBase DB_users = new DataBase();
            DataTable table_users = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `document_number` = @Log AND `password` = @Pass", DB_users.getConnection());
            command.Parameters.Add("@Log", MySqlDbType.VarChar).Value = log;
            command.Parameters.Add("@Pass", MySqlDbType.VarChar).Value = pass;

            adapter.SelectCommand = command;
            adapter.Fill(table_users);

            if (table_users.Rows.Count > 0)
            {

                MessageBox.Show("Всё окэй");

                //Transfer.Welcome = log;
                MainForm form = new MainForm();
                form.Show();
                this.Hide();
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
            this.Hide();
            RegistrationForm reg = new RegistrationForm();
            reg.Show();
        }

        private void AuthenticationForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }

        
    }
}
