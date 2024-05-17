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
        }

        private void labelEnterReg_Click(object sender, EventArgs e)
        {
            labelEnterReg.Visible = false;
            labelExit.Visible = true;
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
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }

        private void picSearch_Click(object sender, EventArgs e)
        {
            //dataGVLitTable.Rows[0].Cells[0].Value= "ХУЕТА";
            Search_note search = new Search_note();
            DataTable table = new DataTable();
            table = search.search_literature(tBSearch.Text);
            if(table.Rows.Count > 0)
            {
                dataGVLitTable.DataSource = table;
            }
            else
            {
                MessageBox.Show("Не найдено ни одной записи");
            }
        }
    }
}
