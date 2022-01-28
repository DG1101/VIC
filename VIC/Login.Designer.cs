
namespace VIC
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.log_login = new System.Windows.Forms.TextBox();
            this.log_pwd = new System.Windows.Forms.TextBox();
            this.log_click = new System.Windows.Forms.Button();
            this.log_to_reg = new System.Windows.Forms.LinkLabel();
            this.log_interact = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // log_login
            // 
            this.log_login.Location = new System.Drawing.Point(12, 20);
            this.log_login.Name = "log_login";
            this.log_login.PlaceholderText = "Логин";
            this.log_login.Size = new System.Drawing.Size(150, 23);
            this.log_login.TabIndex = 1;
            // 
            // log_pwd
            // 
            this.log_pwd.Location = new System.Drawing.Point(12, 50);
            this.log_pwd.Name = "log_pwd";
            this.log_pwd.PasswordChar = '*';
            this.log_pwd.PlaceholderText = "Пароль";
            this.log_pwd.Size = new System.Drawing.Size(150, 23);
            this.log_pwd.TabIndex = 2;
            // 
            // log_click
            // 
            this.log_click.Location = new System.Drawing.Point(48, 85);
            this.log_click.Name = "log_click";
            this.log_click.Size = new System.Drawing.Size(75, 23);
            this.log_click.TabIndex = 3;
            this.log_click.Text = "Вход";
            this.log_click.UseVisualStyleBackColor = true;
            this.log_click.Click += new System.EventHandler(this.log_click_Click);
            // 
            // log_to_reg
            // 
            this.log_to_reg.AutoSize = true;
            this.log_to_reg.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.log_to_reg.Location = new System.Drawing.Point(25, 145);
            this.log_to_reg.Name = "log_to_reg";
            this.log_to_reg.Size = new System.Drawing.Size(125, 15);
            this.log_to_reg.TabIndex = 5;
            this.log_to_reg.TabStop = true;
            this.log_to_reg.Text = "Зарегистрироваться";
            this.log_to_reg.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.log_to_reg_LinkClicked);
            // 
            // log_interact
            // 
            this.log_interact.AutoSize = true;
            this.log_interact.ForeColor = System.Drawing.Color.Red;
            this.log_interact.Location = new System.Drawing.Point(0, 111);
            this.log_interact.Name = "log_interact";
            this.log_interact.Size = new System.Drawing.Size(171, 30);
            this.log_interact.TabIndex = 6;
            this.log_interact.Text = "Неверое имя пользователя \r\nили пароль";
            this.log_interact.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.log_interact.Visible = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(172, 162);
            this.ControlBox = false;
            this.Controls.Add(this.log_interact);
            this.Controls.Add(this.log_to_reg);
            this.Controls.Add(this.log_click);
            this.Controls.Add(this.log_pwd);
            this.Controls.Add(this.log_login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Вход";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox log_login;
        private System.Windows.Forms.TextBox log_pwd;
        private System.Windows.Forms.Button log_click;
        private System.Windows.Forms.LinkLabel log_to_reg;
        private System.Windows.Forms.Label log_interact;
    }
}

