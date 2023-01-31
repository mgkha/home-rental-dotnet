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
    public partial class FormLogin : Form
    {
        private int numberOfRetries = 0;
        public FormLogin()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            SQLiteConnection sqlite_conn = Program.sqlite_conn;
            SQLiteDataReader sqlite_datareader;
            SQLiteCommand sqlite_cmd = sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = $"SELECT * FROM Users WHERE username = '{txtUsername.Text}'";

            sqlite_datareader = sqlite_cmd.ExecuteReader();
            sqlite_datareader.Read();
            if (sqlite_datareader.HasRows)
            {
                int userId = sqlite_datareader.GetInt16(sqlite_datareader.GetOrdinal("id"));
                string password = sqlite_datareader.GetString(sqlite_datareader.GetOrdinal("password"));
                if (password.Equals(txtPassword.Text))
                {
                    Program.Session_UserId = userId;
                    int isAdmin = sqlite_datareader.GetInt16(sqlite_datareader.GetOrdinal("isAdmin"));
                    if (isAdmin == 1)
                    {
                        (new FormMain()).Show();
                    }
                    else
                    {
                        (new FormRent()).Show();
                    }
                    this.Hide();
                    return;
                }
            }

            lblPrompt.Text = "Username and password did not match";
            lblPrompt.Visible = true;
            numberOfRetries += 1;

            // delay 5 mins if the user fail to login 3 times;
            if(numberOfRetries >= 3)
            {
                timer1.Interval = 5000; // (5 * 60 * 1000); // 5 mins
                timer1.Start();
                lblPrompt.Text = "Too much attempted! Please wait 5 min.";
                txtUsername.ReadOnly = true;
                txtPassword.ReadOnly = true;
                btnLogin.Enabled = false;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            lblPrompt.Visible = false;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            lblPrompt.Visible = false;
        }

        private void linkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            (new FormRegister()).Show();
            this.Hide();
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            btnLogin.Enabled = true;
            txtUsername.ReadOnly = false;
            txtPassword.ReadOnly = false;
            lblPrompt.Visible = false;
        }
    }
}
