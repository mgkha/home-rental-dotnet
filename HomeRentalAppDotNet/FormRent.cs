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
    public partial class FormRent : Form
    {
        public FormRent()
        {
            InitializeComponent();
        }

        private void FormRent_Load(object sender, EventArgs e)
        {

            var workingArea = Screen.FromHandle(Handle).WorkingArea;
            this.MaximizedBounds = new Rectangle(0, 0, workingArea.Width, workingArea.Height);
            this.WindowState = FormWindowState.Maximized;

            SQLiteConnection sqlite_conn = Program.sqlite_conn;
            SQLiteDataReader sqlite_datareader;
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = "SELECT * FROM ApplianceTypes";

            sqlite_datareader = sqlite_cmd.ExecuteReader();

            Dictionary<int, string> comboSource = new Dictionary<int, string>();

            while (sqlite_datareader.Read())
            {
                int applianceTypeId = sqlite_datareader.GetInt16(sqlite_datareader.GetOrdinal("id"));
                string applianceTypeName = sqlite_datareader.GetString(sqlite_datareader.GetOrdinal("name"));
                comboSource.Add(applianceTypeId, applianceTypeName);
            }


            comboBoxApplianceTypes.DataSource = new BindingSource(comboSource, null);
            comboBoxApplianceTypes.DisplayMember = "Value";
            comboBoxApplianceTypes.ValueMember = "Key";


            comboBoxApplianceTypes.SelectedIndex = -1;
            comboBoxApplianceTypes.Text = "Please Select Appliance Type";


            // load shopping cart
            getOrderAppliance();

        }

        public void getOrderAppliance()
        {
            int userId = 2;

            this.dataGridView2.Rows.Clear();

            SQLiteConnection sqlite_conn = Program.sqlite_conn;
            SQLiteDataReader sqlite_datareader;
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = $"select a.name , a.brand, a.model, o.rentalPeriod , o.rentalPrice  from Orders as o  left join Appliances as a on a.id = o.applianceId where o.userId = {userId};";

            sqlite_datareader = sqlite_cmd.ExecuteReader();
            while (sqlite_datareader.Read())
            {
                dataGridView2.Rows.Add(new object[]
                {
                    sqlite_datareader.GetValue(sqlite_datareader.GetOrdinal("name")),
                    sqlite_datareader.GetValue(sqlite_datareader.GetOrdinal("brand")),
                    sqlite_datareader.GetValue(sqlite_datareader.GetOrdinal("model")),
                    sqlite_datareader.GetValue(sqlite_datareader.GetOrdinal("rentalPeriod")),
                    sqlite_datareader.GetValue(sqlite_datareader.GetOrdinal("rentalPrice")),
                });
            }

            // calculate total price for order
            int sum = 0;
            for (int i = 0; i < dataGridView2.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(dataGridView2.Rows[i].Cells[4].Value);
            }
            txtTotalPrice.Text = sum.ToString();

        }

        private void FormRent_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void comboBoxApplianceTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBoxApplianceTypes.SelectedIndex == -1) { return; }

            int applianceTypeId = ((KeyValuePair<int, string>)comboBoxApplianceTypes.SelectedItem).Key;

            this.dataGridView1.Rows.Clear();

            SQLiteConnection sqlite_conn = Program.sqlite_conn;
            SQLiteDataReader sqlite_datareader;
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = $"SELECT * FROM Appliances WHERE applianceTypeId = {applianceTypeId}";

            sqlite_datareader = sqlite_cmd.ExecuteReader();
            while (sqlite_datareader.Read())
            {
                dataGridView1.Rows.Add(new object[]
                {
                    sqlite_datareader.GetValue(sqlite_datareader.GetOrdinal("id")),
                    sqlite_datareader.GetValue(sqlite_datareader.GetOrdinal("energyConsumption")),
                    sqlite_datareader.GetValue(sqlite_datareader.GetOrdinal("name")),
                    sqlite_datareader.GetValue(sqlite_datareader.GetOrdinal("brand")),
                    sqlite_datareader.GetValue(sqlite_datareader.GetOrdinal("model")),
                    sqlite_datareader.GetValue(sqlite_datareader.GetOrdinal("dimension")),
                    sqlite_datareader.GetValue(sqlite_datareader.GetOrdinal("description")),
                    sqlite_datareader.GetValue(sqlite_datareader.GetOrdinal("monthlyFees")),
                });
            }
            this.dataGridView1.Sort(this.dataGridView1.Columns["energyConsumption"], ListSortDirection.Descending);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new FormLogin()).Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void addToCartToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0) { return; }
            int applianceId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);

            int energyConsumption = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[1].Value);
            string name = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            string brand = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            string model = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            string dimension = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            string description = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            int monthlyFees = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[7].Value);

            (new FormAddToCart(this, applianceId, name, brand, model, dimension, description, energyConsumption, monthlyFees)).ShowDialog();


        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnClearCart_Click(object sender, EventArgs e)
        {
            getOrderAppliance();
        }

        private void dataGridView2_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
        }
    }
}
