using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuakeApp
{

    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string connection_string = @"server=localhost;userid=root;password=password;database=quakeapp";
            db_con = new MySqlConnection(connection_string);
            db_con.Open();
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
        public static MySqlConnection db_con;
        public enum TEMPER
        {
            HARSH = 0,
            NEUTRAL = 1,
            SUPPORTIVE = 2
        };
        public static TEMPER temper;
    }
}
