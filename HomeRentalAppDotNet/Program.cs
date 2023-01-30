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
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        //static void Main()
        //{
        //    Application.EnableVisualStyles();
        //    Application.SetCompatibleTextRenderingDefault(false);
        //    Application.Run(new Form1());
        //}

        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        public static SQLiteConnection CreateConnection()
        {

            SQLiteConnection sqlite_conn;
            // Create a new database connection:
            sqlite_conn = new SQLiteConnection("Data Source=D:\\database.db; Version = 3; New = True; Compress = True; ");
            // Open the connection:
            try
            {
                sqlite_conn.Open();
            }
            catch (Exception)
            {

            }
            return sqlite_conn;
        }

        //static void CreateTable(SQLiteConnection conn)
        //{

        //    SQLiteCommand sqlite_cmd;
        //    string Createsql = "CREATE TABLE SampleTable (Col1 VARCHAR(20), Col2 INT)";
        //    string Createsql1 = "CREATE TABLE SampleTable1 (Col1 VARCHAR(20), Col2 INT)";
        //    sqlite_cmd = conn.CreateCommand();
        //    sqlite_cmd.CommandText = Createsql;
        //    sqlite_cmd.ExecuteNonQuery();
        //    sqlite_cmd.CommandText = Createsql1;
        //    sqlite_cmd.ExecuteNonQuery();

        //}

        //static void InsertData(SQLiteConnection conn)
        //{
        //    SQLiteCommand sqlite_cmd;
        //    sqlite_cmd = conn.CreateCommand();
        //    sqlite_cmd.CommandText = "INSERT INTO SampleTable
        //       (Col1, Col2) VALUES('Test Text ', 1); ";
        //   sqlite_cmd.ExecuteNonQuery();
        //    sqlite_cmd.CommandText = "INSERT INTO SampleTable
        //       (Col1, Col2) VALUES('Test1 Text1 ', 2); ";
        //   sqlite_cmd.ExecuteNonQuery();
        //    sqlite_cmd.CommandText = "INSERT INTO SampleTable
        //       (Col1, Col2) VALUES('Test2 Text2 ', 3); ";
        //   sqlite_cmd.ExecuteNonQuery();


        //    sqlite_cmd.CommandText = "INSERT INTO SampleTable1
        //       (Col1, Col2) VALUES('Test3 Text3 ', 3); ";
        //   sqlite_cmd.ExecuteNonQuery();

        //}

        //static void ReadData(SQLiteConnection conn)
        //{
        //    SQLiteDataReader sqlite_datareader;
        //    SQLiteCommand sqlite_cmd;
        //    sqlite_cmd = conn.CreateCommand();
        //    sqlite_cmd.CommandText = "SELECT * FROM Appliances";

        //    sqlite_datareader = sqlite_cmd.ExecuteReader();
        //    while (sqlite_datareader.Read())
        //    {
        //        string myreader = sqlite_datareader.GetString(3);
        //        Debug.WriteLine(myreader);
                
        //    }
        //    conn.Close();
        //}
    }
}
