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
    public partial class FormRegister : Form
    {

        public FormRegister()
        {
            InitializeComponent();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }

        private void linkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            (new FormLogin()).Show();
            this.Hide();
        }

        private void RegisterForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (
                txtUsername.Text != "" &&
                txtPassword.Text != "" &&
                txtPassword2.Text != "" &&
                txtPassword.Text.Equals(txtPassword2.Text))
            {
                SQLiteConnection sqlite_conn = Program.sqlite_conn;
                SQLiteCommand sqlite_cmd = sqlite_conn.CreateCommand();
                sqlite_cmd.CommandText = $"INSERT INTO Users (username, password, isAdmin) VALUES('{txtUsername.Text}', '{txtPassword.Text}', 0);";
                int result = sqlite_cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    this.Hide();
                    (new FormLogin()).Show();
                }
            }
            else
            {
                MessageBox.Show("Please fill all the fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
