using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SQLite;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeRentalAppDotNet
{
    internal static class Program
    {


        public static SQLiteConnection sqlite_conn;
        public static int Session_UserId;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]

        static void Main(string[] args)
        {
            CreateConnection();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormLogin());
        }

        static void CreateConnection()
        {
            // Create a new database connection:
            sqlite_conn = new SQLiteConnection("Data Source=D:\\database.db; Version = 3; Compress = True;");
            // Open the connection:
            try
            {
                sqlite_conn.Open();
            }
            catch (Exception)
            {
                sqlite_conn.Close();
            }
        }

        
    }
}
