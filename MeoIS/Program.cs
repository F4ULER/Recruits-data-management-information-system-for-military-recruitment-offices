using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeoIS
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Transfer.Doc_num = "";
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }

    // класс для перенесения основной информации о пользователе между формами
    static class Transfer
    {
        public static string Doc_num
        { get; set; }
        public static string Pass
        { get; set; }
        public static string Name
        { get; set; }
        public static string Category
        { get; set; }
        public static string City
        { get; set; }
        public static string Email
        { get; set; }
        public static string Phone
        { get; set; }
    }
}
