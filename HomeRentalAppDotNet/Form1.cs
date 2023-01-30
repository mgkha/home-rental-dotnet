using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeRentalAppDotNet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SQLiteConnection sqlite_conn;
            sqlite_conn = Program.CreateConnection();
            SQLiteDataReader sqlite_datareader;
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = "SELECT * FROM Appliances";

            sqlite_datareader = sqlite_cmd.ExecuteReader();
            while (sqlite_datareader.Read())
            {
                SQLiteCommand sqlite_cmd2 = sqlite_conn.CreateCommand();
                sqlite_cmd2.CommandText = "SELECT * FROM ApplianceTypes WHERE id=" + sqlite_datareader.GetValue(sqlite_datareader.GetOrdinal("applianceTypeId"));
                SQLiteDataReader sqlite_datareader2 = sqlite_cmd2.ExecuteReader();
                sqlite_datareader2.Read();
                string applianceTypeName = sqlite_datareader2.GetString(sqlite_datareader2.GetOrdinal("name"));

                //string myreader = sqlite_datareader.GetString(3);
                //Debug.WriteLine(myreader);
                dataGridView1.Rows.Add(new object[]
                {
                    sqlite_datareader.GetValue(0),
                    sqlite_datareader.GetValue(sqlite_datareader.GetOrdinal("name")),
                    applianceTypeName,
                    sqlite_datareader.GetValue(sqlite_datareader.GetOrdinal("brand")),
                    sqlite_datareader.GetValue(sqlite_datareader.GetOrdinal("model")),
                    sqlite_datareader.GetValue(sqlite_datareader.GetOrdinal("dimension")),
                    sqlite_datareader.GetValue(sqlite_datareader.GetOrdinal("description")),
                    sqlite_datareader.GetValue(sqlite_datareader.GetOrdinal("energyConsumption")),
                    sqlite_datareader.GetValue(sqlite_datareader.GetOrdinal("monthlyFees")),
                });


            }
            sqlite_conn.Close();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addNewApplianceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form addForm = new Form2();
            addForm.Show();
        }
    }
}
