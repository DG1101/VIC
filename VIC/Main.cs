using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using Microsoft.Data.Sqlite;

namespace VIC
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            var conn = new SqliteConnection("Data Source=database.db");
            conn.Open();
            SqliteCommand comm = new SqliteCommand("CREATE TABLE IF NOT EXISTS Users (_id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE, login TEXT NOT NULL, pass TEXT NOT NULL)", conn);
            comm.ExecuteNonQuery();
            comm.CommandText = "CREATE TABLE IF NOT EXISTS Documents (_id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE, text TEXT NOT NULL, uid INTEGER NOT NULL)";
            comm.ExecuteNonQuery();
            conn.Dispose();

            toolTip1.SetToolTip(ciphertext, "В данном поле отображается зашифрованный текст");
            toolTip2.SetToolTip(plaintext, "Данное поле предназначено для ввода шифруемой информации");
            toolTip3.SetToolTip(listBox1, "Данный список отображает доступные вам документы и позволяет переключаться между ними");

            if (User.verify() == false)
                {
                    this.Enabled = false;
                    Login logform = new Login();
                    logform.Owner = this;
                    logform.Show();
                }
            

        }

        private void load()
        {
            if (User.verify() == true)
            {
                long session_id = Program.logincheck(User.Login);
                listBox1.Items.Clear();

                var conn = new SqliteConnection("Data Source=database.db;Mode=ReadOnly");
                conn.Open();
                SqliteCommand comm = new SqliteCommand("SELECT _id,text,uid FROM Documents", conn);
                SqliteDataReader reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    if ((long)reader[2] == session_id)
                    {
                        listBox1.Items.Add((long)reader[0] + " ");
                    }
                }
                conn.Dispose();
                listBox1.SelectedIndex = listBox1.Items.Count - 1;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            long session_id = Program.logincheck(User.Login);

            var conn = new SqliteConnection("Data Source=database.db");
            conn.Open();
            string text = "Пустая ячейка";
            SqliteCommand comm = new SqliteCommand($"INSERT INTO Documents (text, uid) SELECT '{text}', '{session_id}' EXCEPT SELECT text, uid FROM Documents WHERE text='{text}' AND uid='{session_id}'", conn);

            comm.ExecuteNonQuery();
            conn.Dispose();
            load();
            
        }

        private void Main_EnabledChanged(object sender, EventArgs e)
        {
            load();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(toolStripTextBox1.Text) == false)
            {
                toolStripTextBox1.Text = toolStripTextBox1.Text.Remove(0);
            }

            if (string.IsNullOrEmpty(plaintext.Text) == false)
            {
                plaintext.Text = plaintext.Text.Remove(0);
            }

            if (string.IsNullOrEmpty(ciphertext.Text) == false)
            {
                ciphertext.Text = ciphertext.Text.Remove(0);
            }
            if (listBox1.SelectedItem != null)
            {
                button2.Enabled = true;
                button3.Enabled = true;

                string command = (string)listBox1.SelectedItem;
                char[] cid = new char[256];
                for (int i = 0; command[i] != ' '; i++)
                {
                    cid[i] = command[i];
                }
                string temp = new string(cid);
                long id = Convert.ToInt64(temp);


                var conn = new SqliteConnection("Data Source=database.db;Mode=ReadOnly");

                conn.Open();
                SqliteCommand comm = new SqliteCommand("SELECT _id,text FROM Documents", conn);
                SqliteDataReader read = comm.ExecuteReader();

                while (read.Read())
                {
                    if ((long)read[0] == id)
                    {
                        Document.Ciphertext = (string)read[1];

                    }
                }
                conn.Dispose();
                ciphertext.Text = Document.Ciphertext;
                toolStripTextBox1.Enabled = true;
                plaintext.Enabled = true;
            }
            else
            {


                button2.Enabled = false;
                button3.Enabled = false;
               // toolStripTextBox1.Enabled = false;
              //  plaintext.Enabled = false;
                Document.Ciphertext = "null";
                Document.Plaintext = "null";
            }
            }

        private void decipherbutton_Click(object sender, EventArgs e)
        {

            Document.Key = toolStripTextBox1.Text;

            if(Document.Decrypt() == false)
            {
                ciphererror.Visible = true;
            }
            else
            {
                ciphererror.Visible = false;
            }
            
            plaintext.Text = Document.Plaintext;
           
        }

        private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(toolStripTextBox1.Text) == false)
            {
                cipherbutton.Enabled = true;
                decipherbutton.Enabled = true;
            }
            else
            {
                cipherbutton.Enabled = false;
                decipherbutton.Enabled = false;
            }
        }

        private void cipherbutton_Click(object sender, EventArgs e)
        {
            Document.Plaintext = plaintext.Text;
            Document.Key = toolStripTextBox1.Text;

            if (Document.Encrypt() == false)
            {
                ciphererror.Visible = true;
            }
            else
            {
                ciphererror.Visible = false;
            }
            ciphertext.Text = Document.Ciphertext;

            if (listBox1.SelectedItem != null)
            {
                string command = (string)listBox1.SelectedItem;
                char[] cid = new char[256];
                for (int i = 0; command[i] != ' '; i++)
                {
                    cid[i] = command[i];
                }
                string temp = new string(cid);
                long id = Convert.ToInt64(temp);

                var conn = new SqliteConnection("Data Source=database.db");
                conn.Open();
                string text = Document.Ciphertext;
                SqliteCommand comm = new SqliteCommand($"UPDATE Documents SET text = '{text}' WHERE _id = {id}", conn);

                comm.ExecuteNonQuery();
                conn.Dispose();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
           

            string sel = (string)listBox1.SelectedItem;
            char[] cid = new char[256];
            for (int i = 0; sel[i] != ' '; i++)
            {
                cid[i] = sel[i];
            }
            string temp = new string(cid);
            long id = Convert.ToInt64(temp);
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);

            var conn = new SqliteConnection("Data Source=database.db");

            conn.Open();
            SqliteCommand comm = new SqliteCommand($"DELETE FROM Documents WHERE _id='{id}'", conn);
            comm.ExecuteNonQuery();
            conn.Dispose();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Title = "Сохранить";
            save.Filter = "Зашифрованные VIC файлы (*.VIC)|*.VIC";

            if(save.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                StreamWriter write = new StreamWriter(File.Create(save.FileName));

                write.Write(ciphertext.Text);
                write.Dispose();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Title = "Открыть";
            open.Filter = "Зашифрованные VIC файлы (*.VIC)|*.VIC";

            if (open.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                StreamReader read = new StreamReader(File.OpenRead(open.FileName));

                ciphertext.Text = read.ReadToEnd();
                read.Dispose();

                Document.Ciphertext = ciphertext.Text;
                

                if (string.IsNullOrEmpty(plaintext.Text) == false)
                {
                    plaintext.Text = plaintext.Text.Remove(0);
                }

                Document.Plaintext = "null";
               // plaintext.Enabled = true;
               // toolStripTextBox1.Enabled = true;

                if (listBox1.SelectedItem != null)
                {
                    string command = (string)listBox1.SelectedItem;
                    char[] cid = new char[256];
                    for (int i = 0; command[i] != ' '; i++)
                    {
                        cid[i] = command[i];
                    }
                    string temp = new string(cid);
                    long id = Convert.ToInt64(temp);

                    var conn = new SqliteConnection("Data Source=database.db");
                    conn.Open();
                    string text = Document.Ciphertext;
                    SqliteCommand comm = new SqliteCommand($"UPDATE Documents SET text = '{text}' WHERE _id = {id}", conn);

                    comm.ExecuteNonQuery();
                    conn.Dispose();
                }

                plaintext.Enabled = true;
                toolStripTextBox1.Enabled = true;
            }
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            listBox1.SelectedItem = null;
            if (string.IsNullOrEmpty(plaintext.Text) == false)
            {
                plaintext.Text = plaintext.Text.Remove(0);
            }
            if (string.IsNullOrEmpty(ciphertext.Text) == false)
            {
                ciphertext.Text = ciphertext.Text.Remove(0);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(toolTip1.Active == true)
            {
                toolTip1.Active = false;
                toolTip2.Active = false;
                toolTip3.Active = false;
            }
            else
            {
                toolTip1.Active = true;
                toolTip2.Active = true;
                toolTip3.Active = true;
            }


            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Restart();
            Environment.Exit(0);
        }
    }
    }

