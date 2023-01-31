using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeRentalAppDotNet
{
    public partial class FormAddToCart : Form
    {
        public string name, brand, model, dimension, description;
        public int applianceId, energyConsumption, monthlyFees;
        public FormRent formRent;
        public FormAddToCart(FormRent formRent, int applianceId, string name, string brand, string model, string dimension, string description, int energyConsumption, int monthlyFees)
        {
            InitializeComponent();
            this.applianceId = applianceId;
            this.brand = brand;
            this.name = name;
            this.model = model;
            this.dimension = dimension;
            this.description = description;
            this.energyConsumption = energyConsumption;
            this.monthlyFees = monthlyFees;
            this.formRent = formRent;

        }

        private void FormAddToCart_Load(object sender, EventArgs e)
        {
            txtName.Text = this.name;
            txtBrand.Text = this.brand;
            txtModel.Text = this.model;
            txtDescription.Text = this.description;
            txtDimension.Text = this.dimension;
            txtEnergyConsum.Text = this.energyConsumption.ToString();
            txtFees.Text = this.monthlyFees.ToString();

        }

        private void txtEnergyConsum_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int rentalPeriod = Convert.ToInt32(txtRentalPeriod.Text);
                txtRentalPrice.Text = (this.monthlyFees * rentalPeriod).ToString();
            }
            catch (Exception)
            {
            }

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtRentalPeriod.Text.Length > 0)
            {
                SQLiteConnection sqlite_conn = Program.sqlite_conn;
                SQLiteCommand sqlite_cmd = sqlite_conn.CreateCommand();
                sqlite_cmd.CommandText = $"INSERT INTO Orders (userId, applianceId, rentalPeriod, rentalPrice) VALUES({2}, {this.applianceId}, {txtRentalPeriod.Text}, {txtRentalPrice.Text});";
                int result = sqlite_cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    this.formRent.getOrderAppliance();
                    this.Close();

                }
            }
        }
    }
}
