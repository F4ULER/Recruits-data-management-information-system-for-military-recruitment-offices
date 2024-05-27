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

    }
}
