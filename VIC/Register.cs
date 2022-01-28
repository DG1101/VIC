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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
            
        }

        private void reg_click_Click(object sender, EventArgs e)
        {
            reg_interact.Visible = false;
            reg_interact2.Visible = false;
            reg_interact3.Visible = false;
            
            if (String.IsNullOrEmpty(reg_login.Text)==false)
            {
                long id = Program.logincheck(Program.hash((reg_login.Text).ToLower()));
            
            if (id >= 0)
            {
                reg_interact.Visible = true;
            }
            else
            {
                if (id == -1)
                {
                    if (reg_pwd.Text == reg_confirm.Text && String.IsNullOrEmpty(reg_pwd.Text) != true)
                    {
                        User.Login = Program.hash((reg_login.Text).ToLower());
                        User.Password = Program.hash(reg_pwd.Text + User.Login);
                        Program.register(User.Login, User.Password);
                        Owner.Enabled = true;
                        Owner.Text = reg_login.Text;
                        this.Close();
                    }
                    else
                    {
                        reg_interact2.Visible = true;
                    }
                }
            }
        }
            else
            {
                reg_interact3.Visible = true;
            }
     }

        private void reg_to_log_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Login logform = new Login();
            logform.Owner = this.Owner;
            logform.Show();
            this.Close();
        }
    }
}
