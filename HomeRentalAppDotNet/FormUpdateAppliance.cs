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
    public partial class FormUpdateAppliance : Form
    {
        private int id, type;
        private string name, brand, model, dimension, description, energyConsum, monthlyFees;
        private FormMain mainForm;
        public FormUpdateAppliance(FormMain mainForm, int id, int type, string name, string brand, string model, string dimension, string description, string energyConsum, string monthlyFees)
        {
            InitializeComponent();
            this.id = id;
            this.type = type;
            this.name = name;
            this.brand = brand;
            this.model = model;
            this.dimension = dimension;
            this.description = description;
            this.energyConsum = energyConsum;
            this.monthlyFees = monthlyFees;
            this.mainForm = mainForm;
        }

        private void FormUpdateAppliance_Load(object sender, EventArgs e)
        {

            // load appliance type from db
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


            comboBoxApplianceTypes.SelectedIndex = comboSource.Keys.ToList().IndexOf(this.type);
            txtName.Text = this.name;
            txtBrand.Text = this.brand;
            txtModel.Text = this.model;
            txtDescription.Text = this.description;
            txtDimension.Text = this.dimension;
            numEnergyConsum.Text = this.energyConsum;
            numFees.Text = this.monthlyFees;

        }

        private void btnUpdateAppliance_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure you want to update this appliance?", "Update the appliance", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.Yes)
            {
                if (
              txtName.Text != "" &&
              txtBrand.Text != "" &&
              txtModel.Text != "" &&
              txtDimension.Text != "" &&
              txtDescription.Text != "" &&
              numEnergyConsum.Value > 0 &&
              numFees.Value > 0 &&
              comboBoxApplianceTypes.SelectedIndex >= 0)
                {
                    int applianceTypeId = ((KeyValuePair<int, string>)comboBoxApplianceTypes.SelectedItem).Key;

                    SQLiteConnection sqlite_conn = Program.sqlite_conn;
                    SQLiteCommand sqlite_cmd = sqlite_conn.CreateCommand();
                    sqlite_cmd.CommandText = $"UPDATE Appliances SET name = '{txtName.Text}', brand = '{txtBrand.Text}', model = '{txtModel.Text}', dimension = '{txtDimension.Text}', description = '{txtDescription.Text}', energyConsumption = '{numEnergyConsum.Text}', monthlyFees = '{numFees.Text}', applianceTypeId = {applianceTypeId} WHERE id = {this.id};";
                    int result = sqlite_cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Appliance has been updated.");
                        this.mainForm.refreshAppliances();
                        this.Close();
                    }
                }

                else
                {
                    MessageBox.Show("Please fill all the fields", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }



        }

    }
}

