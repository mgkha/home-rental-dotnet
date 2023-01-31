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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var workingArea = Screen.FromHandle(Handle).WorkingArea;
            this.MaximizedBounds = new Rectangle(0, 0, workingArea.Width, workingArea.Height);
            this.WindowState = FormWindowState.Maximized;

            refreshAppliances();

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addNewApplianceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form addForm = new FormCreateAppliance(this); ;
            addForm.ShowDialog();
        }

        public void refreshAppliances()
        {
            dataGridView1.Rows.Clear();

            SQLiteConnection sqlite_conn = Program.sqlite_conn;
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
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            refreshAppliances();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure you want to delete this appliance?", "Delete the appliance", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.Yes)
            {
                int applianceId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);

                SQLiteConnection sqlite_conn = Program.sqlite_conn;
                SQLiteCommand sqlite_cmd = sqlite_conn.CreateCommand();
                sqlite_cmd.CommandText = $"DELETE FROM Appliances WHERE id = {applianceId};";
                int result = sqlite_cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Appliance is removed from the database.");
                }

                this.refreshAppliances();
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new FormLogin()).Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
