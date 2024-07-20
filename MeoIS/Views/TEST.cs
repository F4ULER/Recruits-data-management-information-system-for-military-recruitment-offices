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
    public partial class TEST : Form
    {
        public TEST()
        {
            InitializeComponent();
        }

        private void buttonFirstReg_Click(object sender, EventArgs e)
        {
            //Advanced_search _Search = new Advanced_search();
            //Collect_statistics collect = new Collect_statistics();
            //DataTable table = _Search.searchFullName("Пресняков", " ", " ");
            //collect.export_to_file(table);
        }

        private void buttonStat_Click(object sender, EventArgs e)
        {
            DataBaseConnect dataBase = new DataBaseConnect();
            DataTable table = dataBase.sending_command_with_output_to_table("SELECT * FROM `users` WHERE 1");
            dataBase.change_date_style(table);
        }

        public void showOnWindow(string name, string value)
        {
            name = "Статистика по параметру " + name;
            MessageBox.Show(value, name, MessageBoxButtons.OK);
        }

        //попытка сделать статистику по возрасту(не удалось преобразовать string в int)
        public void tryStatAge ()
        {
            //string message = "SELECT `document_number` AS 'Номер документа', `password` AS 'Пароль', `last_name` AS 'Фамилия', `name` AS 'Имя', `patronymic` AS 'Отчество', `date_of_birth` AS 'Дата рождения', `address` AS 'Фактический адрес', `category` AS 'Категория годности'," +
            //    " `gender` AS 'Пол', `city` AS 'Город', `phone_number` AS 'Номер телефона', `email` AS 'Электронная почта', `user_status` AS 'Статус' FROM `users` WHERE 1=1";

            //DataTable tableAge = new DataTable(), tableAll = DataBase.sending_command_with_output_to_table(message);

            //string ff = "2003";
            //int gg = Convert.ToInt32(ff);



            //tableAge = tableAll.Clone();

            //for (int i = 0; i < tableAll.Rows.Count; i++)
            //{
            //    string[] age = tableAll.Rows[i][5].ToString().Split(new char[] { '.' });

            //    int age2 = Convert.ToInt32(age[2]), from = Convert.ToInt32(DateTime.Now.Year.ToString()) - Convert.ToInt32(fromAge), to = Convert.ToInt32(DateTime.Now.Year.ToString()) - Convert.ToInt32(toAge);

            //    if ((age2 <= from) && (age2 >= to))
            //    {
            //        DataRow dr = tableAll.Rows[i];
            //        tableAll.ImportRow(dr);
            //        MessageBox.Show(dr[2].ToString());
            //        tableAge.Rows.Add(dr.ItemArray);
            //    }
            //}

            //return tableAge;
        }
    }
}
