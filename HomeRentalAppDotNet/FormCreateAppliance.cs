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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HomeRentalAppDotNet
{
    public partial class FormCreateAppliance : Form
    {
        FormMain f1;

        public FormCreateAppliance(FormMain _f1)
        {
            InitializeComponent();
            this.f1 = _f1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (
                textBoxName.Text != "" &&
                textBoxBrand.Text != "" &&
                textBoxModel.Text != "" &&
                textBoxDimension.Text != "" &&
                textBoxDescription.Text != "" &&
                numberEnergyConsump.Value > 0 &&
                numberFees.Value > 0 &&
                comboBoxApplianceTypes.SelectedIndex >= 0)
            {
                int applianceTypeId = ((KeyValuePair<int, string>)comboBoxApplianceTypes.SelectedItem).Key;

                SQLiteConnection sqlite_conn = Program.sqlite_conn;
                SQLiteCommand sqlite_cmd = sqlite_conn.CreateCommand();
                sqlite_cmd.CommandText = $"INSERT INTO Appliances (name, brand, model, dimension, description, energyConsumption, monthlyFees, applianceTypeId) VALUES('{textBoxName.Text}', '{textBoxBrand.Text}', '{textBoxModel.Text}', '{textBoxDimension.Text}', '{textBoxDescription.Text}', '{numberEnergyConsump.Value}', '{numberFees.Value}', {applianceTypeId});";
                int result = sqlite_cmd.ExecuteNonQuery();
                if(result > 0)
                {
                    f1.refreshAppliances();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Please fill all the fields", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
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


            comboBoxApplianceTypes.SelectedIndex = -1;
            comboBoxApplianceTypes.Text = "Please Select Appliance Type";

        }
    }
}
