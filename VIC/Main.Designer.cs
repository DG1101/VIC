
namespace VIC
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.doc_list = new System.Windows.Forms.SplitContainer();
            this.button5 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.doc = new System.Windows.Forms.SplitContainer();
            this.plaintoolbox = new System.Windows.Forms.SplitContainer();
            this.ciphererror = new System.Windows.Forms.Label();
            this.tools = new System.Windows.Forms.ToolStrip();
            this.cipherbutton = new System.Windows.Forms.ToolStripButton();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.decipherbutton = new System.Windows.Forms.ToolStripButton();
            this.plaintext = new System.Windows.Forms.RichTextBox();
            this.ciphertext = new System.Windows.Forms.RichTextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.doc_list)).BeginInit();
            this.doc_list.Panel1.SuspendLayout();
            this.doc_list.Panel2.SuspendLayout();
            this.doc_list.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doc)).BeginInit();
            this.doc.Panel1.SuspendLayout();
            this.doc.Panel2.SuspendLayout();
            this.doc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.plaintoolbox)).BeginInit();
            this.plaintoolbox.Panel1.SuspendLayout();
            this.plaintoolbox.Panel2.SuspendLayout();
            this.plaintoolbox.SuspendLayout();
            this.tools.SuspendLayout();
            this.SuspendLayout();
            // 
            // doc_list
            // 
            this.doc_list.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.doc_list.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.doc_list.Dock = System.Windows.Forms.DockStyle.Fill;
            this.doc_list.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.doc_list.Location = new System.Drawing.Point(0, 0);
            this.doc_list.Name = "doc_list";
            // 
            // doc_list.Panel1
            // 
            this.doc_list.Panel1.Controls.Add(this.button5);
            this.doc_list.Panel1.Controls.Add(this.checkBox1);
            this.doc_list.Panel1.Controls.Add(this.button4);
            this.doc_list.Panel1.Controls.Add(this.button3);
            this.doc_list.Panel1.Controls.Add(this.button2);
            this.doc_list.Panel1.Controls.Add(this.button1);
            this.doc_list.Panel1.Controls.Add(this.listBox1);
            this.doc_list.Panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.doc_list.Panel1MinSize = 175;
            // 
            // doc_list.Panel2
            // 
            this.doc_list.Panel2.Controls.Add(this.doc);
            this.doc_list.Size = new System.Drawing.Size(800, 444);
            this.doc_list.SplitterDistance = 176;
            this.doc_list.TabIndex = 0;
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.Location = new System.Drawing.Point(50, 400);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 6;
            this.button5.Text = "Выход";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox1.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(10, 368);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(155, 26);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Отображать подсказки";
            this.checkBox1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Location = new System.Drawing.Point(19, 275);
            this.button4.MaximumSize = new System.Drawing.Size(9999, 25);
            this.button4.MinimumSize = new System.Drawing.Size(140, 25);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(140, 25);
            this.button4.TabIndex = 4;
            this.button4.Text = "Загрузить Документ";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(19, 306);
            this.button3.MaximumSize = new System.Drawing.Size(9999, 25);
            this.button3.MinimumSize = new System.Drawing.Size(140, 25);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(140, 25);
            this.button3.TabIndex = 3;
            this.button3.Text = "Сохранить Документ";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(19, 337);
            this.button2.MaximumSize = new System.Drawing.Size(9999, 25);
            this.button2.MinimumSize = new System.Drawing.Size(140, 25);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 25);
            this.button2.TabIndex = 2;
            this.button2.Text = "Удалить Документ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(19, 244);
            this.button1.MaximumSize = new System.Drawing.Size(9999, 25);
            this.button1.MinimumSize = new System.Drawing.Size(140, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 25);
            this.button1.TabIndex = 1;
            this.button1.Text = "Создать Документ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.ColumnWidth = 100;
            this.listBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.MultiColumn = true;
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(172, 229);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            this.listBox1.DoubleClick += new System.EventHandler(this.listBox1_DoubleClick);
            // 
            // doc
            // 
            this.doc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.doc.Cursor = System.Windows.Forms.Cursors.HSplit;
            this.doc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.doc.Location = new System.Drawing.Point(0, 0);
            this.doc.Name = "doc";
            this.doc.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // doc.Panel1
            // 
            this.doc.Panel1.Controls.Add(this.plaintoolbox);
            // 
            // doc.Panel2
            // 
            this.doc.Panel2.Controls.Add(this.ciphertext);
            this.doc.Size = new System.Drawing.Size(620, 444);
            this.doc.SplitterDistance = 229;
            this.doc.TabIndex = 0;
            // 
            // plaintoolbox
            // 
            this.plaintoolbox.Cursor = System.Windows.Forms.Cursors.HSplit;
            this.plaintoolbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plaintoolbox.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.plaintoolbox.IsSplitterFixed = true;
            this.plaintoolbox.Location = new System.Drawing.Point(0, 0);
            this.plaintoolbox.Name = "plaintoolbox";
            this.plaintoolbox.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // plaintoolbox.Panel1
            // 
            this.plaintoolbox.Panel1.Controls.Add(this.ciphererror);
            this.plaintoolbox.Panel1.Controls.Add(this.tools);
            this.plaintoolbox.Panel1.Cursor = System.Windows.Forms.Cursors.Default;
            // 
            // plaintoolbox.Panel2
            // 
            this.plaintoolbox.Panel2.Controls.Add(this.plaintext);
            this.plaintoolbox.Panel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.plaintoolbox.Size = new System.Drawing.Size(616, 225);
            this.plaintoolbox.SplitterDistance = 25;
            this.plaintoolbox.TabIndex = 0;
            // 
            // ciphererror
            // 
            this.ciphererror.AutoSize = true;
            this.ciphererror.BackColor = System.Drawing.Color.White;
            this.ciphererror.ForeColor = System.Drawing.Color.Red;
            this.ciphererror.Location = new System.Drawing.Point(379, 7);
            this.ciphererror.Name = "ciphererror";
            this.ciphererror.Size = new System.Drawing.Size(227, 15);
            this.ciphererror.TabIndex = 1;
            this.ciphererror.Text = "Встречен необрабатываемый символ";
            this.ciphererror.Visible = false;
            // 
            // tools
            // 
            this.tools.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cipherbutton,
            this.toolStripTextBox1,
            this.decipherbutton});
            this.tools.Location = new System.Drawing.Point(0, 0);
            this.tools.Name = "tools";
            this.tools.Size = new System.Drawing.Size(616, 25);
            this.tools.TabIndex = 0;
            this.tools.Text = "toolStrip1";
            // 
            // cipherbutton
            // 
            this.cipherbutton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.cipherbutton.Enabled = false;
            this.cipherbutton.Image = ((System.Drawing.Image)(resources.GetObject("cipherbutton.Image")));
            this.cipherbutton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cipherbutton.Name = "cipherbutton";
            this.cipherbutton.Size = new System.Drawing.Size(90, 22);
            this.cipherbutton.Text = "Зашифровать";
            this.cipherbutton.Click += new System.EventHandler(this.cipherbutton_Click);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Enabled = false;
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(150, 25);
            this.toolStripTextBox1.ToolTipText = "Ключ шифрования";
            this.toolStripTextBox1.TextChanged += new System.EventHandler(this.toolStripTextBox1_TextChanged);
            // 
            // decipherbutton
            // 
            this.decipherbutton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.decipherbutton.Enabled = false;
            this.decipherbutton.Image = ((System.Drawing.Image)(resources.GetObject("decipherbutton.Image")));
            this.decipherbutton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.decipherbutton.Name = "decipherbutton";
            this.decipherbutton.Size = new System.Drawing.Size(96, 22);
            this.decipherbutton.Text = "Расшифровать";
            this.decipherbutton.Click += new System.EventHandler(this.decipherbutton_Click);
            // 
            // plaintext
            // 
            this.plaintext.AcceptsTab = true;
            this.plaintext.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plaintext.Enabled = false;
            this.plaintext.Location = new System.Drawing.Point(0, 0);
            this.plaintext.Name = "plaintext";
            this.plaintext.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.plaintext.Size = new System.Drawing.Size(616, 196);
            this.plaintext.TabIndex = 0;
            this.plaintext.Text = "";
            // 
            // ciphertext
            // 
            this.ciphertext.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ciphertext.Location = new System.Drawing.Point(0, 0);
            this.ciphertext.Name = "ciphertext";
            this.ciphertext.ReadOnly = true;
            this.ciphertext.Size = new System.Drawing.Size(616, 207);
            this.ciphertext.TabIndex = 0;
            this.ciphertext.Text = "";
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Шифр-текст";
            // 
            // toolTip2
            // 
            this.toolTip2.IsBalloon = true;
            this.toolTip2.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip2.ToolTipTitle = "Открытый текст";
            // 
            // toolTip3
            // 
            this.toolTip3.IsBalloon = true;
            this.toolTip3.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip3.ToolTipTitle = "Список документов";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 444);
            this.Controls.Add(this.doc_list);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Шифр Виженера";
            this.EnabledChanged += new System.EventHandler(this.Main_EnabledChanged);
            this.doc_list.Panel1.ResumeLayout(false);
            this.doc_list.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.doc_list)).EndInit();
            this.doc_list.ResumeLayout(false);
            this.doc.Panel1.ResumeLayout(false);
            this.doc.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.doc)).EndInit();
            this.doc.ResumeLayout(false);
            this.plaintoolbox.Panel1.ResumeLayout(false);
            this.plaintoolbox.Panel1.PerformLayout();
            this.plaintoolbox.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.plaintoolbox)).EndInit();
            this.plaintoolbox.ResumeLayout(false);
            this.tools.ResumeLayout(false);
            this.tools.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer doc_list;
        private System.Windows.Forms.SplitContainer doc;
        private System.Windows.Forms.SplitContainer plaintoolbox;
        private System.Windows.Forms.ToolStrip tools;
        private System.Windows.Forms.RichTextBox plaintext;
        private System.Windows.Forms.RichTextBox ciphertext;
        private System.Windows.Forms.ToolStripButton cipherbutton;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripButton decipherbutton;
        private System.Windows.Forms.Label ciphererror;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button5;
    }
}