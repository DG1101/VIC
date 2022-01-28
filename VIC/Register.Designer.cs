
namespace VIC
{
    partial class Register
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.reg_login = new System.Windows.Forms.TextBox();
            this.reg_pwd = new System.Windows.Forms.TextBox();
            this.reg_confirm = new System.Windows.Forms.TextBox();
            this.reg_click = new System.Windows.Forms.Button();
            this.reg_interact = new System.Windows.Forms.Label();
            this.reg_interact2 = new System.Windows.Forms.Label();
            this.reg_to_log = new System.Windows.Forms.LinkLabel();
            this.reg_interact3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // reg_login
            // 
            this.reg_login.Location = new System.Drawing.Point(65, 40);
            this.reg_login.Name = "reg_login";
            this.reg_login.PlaceholderText = "Логин";
            this.reg_login.Size = new System.Drawing.Size(150, 23);
            this.reg_login.TabIndex = 0;
            // 
            // reg_pwd
            // 
            this.reg_pwd.Location = new System.Drawing.Point(65, 90);
            this.reg_pwd.Name = "reg_pwd";
            this.reg_pwd.PasswordChar = '*';
            this.reg_pwd.PlaceholderText = "Пароль";
            this.reg_pwd.Size = new System.Drawing.Size(150, 23);
            this.reg_pwd.TabIndex = 1;
            // 
            // reg_confirm
            // 
            this.reg_confirm.Location = new System.Drawing.Point(65, 140);
            this.reg_confirm.Name = "reg_confirm";
            this.reg_confirm.PasswordChar = '*';
            this.reg_confirm.PlaceholderText = "Подтверждение пароля";
            this.reg_confirm.Size = new System.Drawing.Size(150, 23);
            this.reg_confirm.TabIndex = 2;
            // 
            // reg_click
            // 
            this.reg_click.Location = new System.Drawing.Point(65, 195);
            this.reg_click.Name = "reg_click";
            this.reg_click.Size = new System.Drawing.Size(150, 23);
            this.reg_click.TabIndex = 3;
            this.reg_click.Text = "Зарегистрироваться";
            this.reg_click.UseVisualStyleBackColor = true;
            this.reg_click.Click += new System.EventHandler(this.reg_click_Click);
            // 
            // reg_interact
            // 
            this.reg_interact.AutoSize = true;
            this.reg_interact.ForeColor = System.Drawing.Color.Red;
            this.reg_interact.Location = new System.Drawing.Point(100, 230);
            this.reg_interact.Name = "reg_interact";
            this.reg_interact.Size = new System.Drawing.Size(76, 15);
            this.reg_interact.TabIndex = 4;
            this.reg_interact.Text = " Имя занято";
            this.reg_interact.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.reg_interact.Visible = false;
            // 
            // reg_interact2
            // 
            this.reg_interact2.AutoSize = true;
            this.reg_interact2.ForeColor = System.Drawing.Color.Red;
            this.reg_interact2.Location = new System.Drawing.Point(73, 230);
            this.reg_interact2.Name = "reg_interact2";
            this.reg_interact2.Size = new System.Drawing.Size(133, 15);
            this.reg_interact2.TabIndex = 5;
            this.reg_interact2.Text = "Пароли не совпадают";
            this.reg_interact2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.reg_interact2.Visible = false;
            // 
            // reg_to_log
            // 
            this.reg_to_log.AutoSize = true;
            this.reg_to_log.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.reg_to_log.Location = new System.Drawing.Point(117, 250);
            this.reg_to_log.Name = "reg_to_log";
            this.reg_to_log.Size = new System.Drawing.Size(43, 15);
            this.reg_to_log.TabIndex = 6;
            this.reg_to_log.TabStop = true;
            this.reg_to_log.Text = "Войти";
            this.reg_to_log.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.reg_to_log_LinkClicked);
            // 
            // reg_interact3
            // 
            this.reg_interact3.AutoSize = true;
            this.reg_interact3.ForeColor = System.Drawing.Color.Red;
            this.reg_interact3.Location = new System.Drawing.Point(90, 230);
            this.reg_interact3.Name = "reg_interact3";
            this.reg_interact3.Size = new System.Drawing.Size(95, 15);
            this.reg_interact3.TabIndex = 7;
            this.reg_interact3.Text = "Введите Логин";
            this.reg_interact3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.reg_interact3.Visible = false;
            // 
            // Register
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(255, 267);
            this.ControlBox = false;
            this.Controls.Add(this.reg_interact3);
            this.Controls.Add(this.reg_to_log);
            this.Controls.Add(this.reg_interact2);
            this.Controls.Add(this.reg_interact);
            this.Controls.Add(this.reg_click);
            this.Controls.Add(this.reg_confirm);
            this.Controls.Add(this.reg_pwd);
            this.Controls.Add(this.reg_login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(275, 310);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(275, 310);
            this.Name = "Register";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Регистрация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox reg_login;
        private System.Windows.Forms.TextBox reg_pwd;
        private System.Windows.Forms.TextBox reg_confirm;
        private System.Windows.Forms.Button reg_click;
        private System.Windows.Forms.Label reg_interact;
        private System.Windows.Forms.Label reg_interact2;
        private System.Windows.Forms.LinkLabel reg_to_log;
        private System.Windows.Forms.Label reg_interact3;
    }
}