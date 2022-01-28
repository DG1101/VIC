using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Microsoft.Data.Sqlite;



namespace VIC
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
           
        }

        private void log_click_Click(object sender, EventArgs e)
        {
            log_interact.Visible = false;
            User.Login = Program.hash((log_login.Text).ToLower());
            User.Password = Program.hash(log_pwd.Text + User.Login);
            if(User.verify() == true)
            {
                this.Owner.Enabled = true;
                Owner.Text = log_login.Text;
                this.Close();
            }
            else
            {
                log_interact.Visible = true;
            }
        }

        private void log_to_reg_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Register regform = new Register();
            regform.Owner = this.Owner;
            regform.Show();
            this.Close();
        }
    }

    
}
