using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using Microsoft.Data.Sqlite;
using System.Security.Cryptography;
using System.Text;

namespace VIC
{
    public static class User
    {
        public static string Login, Password;
        static User()
        {
            Login = "null";
            Password = "null";
        }

        

        public static bool verify()
        {

            long id = Program.logincheck(Login);
            if (id >= 0)
            {
                var conn = new SqliteConnection("Data Source=database.db;Mode=ReadOnly");
                try
                {
                    conn.Open();
                    SqliteCommand comm = new SqliteCommand("SELECT _id,pass FROM Users", conn);
                    SqliteDataReader read = comm.ExecuteReader();
                    while (read.Read())
                    {
                        if ((long)read[0] == id && (string)read[1] == Password)
                        {
                            conn.Dispose();
                            return true; //доступ разрешЄн
                        }
                    }
                }
                catch
                {
                    conn.Dispose();
                    return false;//внутренн€€ ошибка
                }
                conn.Dispose();
            }
            return false; //отказано в доступе


        }

    }

    public static class Document
    {
        public static string Plaintext;
        public static string Ciphertext;
        public static string Key;

        static Document()
        {
            Plaintext = "null";
            Ciphertext = "null";
            Key = "null";
        }

        public static bool Encrypt()
        {
            try
            {
                string alph = "јаЅб¬в√гƒд≈е®Є∆ж«з»и…й кЋлћмЌнќоѕп–р—с“т”у‘ф’х÷ц„чЎшўщЏъџы№ьЁэёюя€ .Е,;:{}[]()Ђї0123456789-Ч+=!?@#$%^&*\n";
                char[] output = new char[Plaintext.Length];
                for (int i = 0; Key.Length < Plaintext.Length; i++)
                {
                    Key += Key[i];
                }
                for (int i = 0; i < Plaintext.Length; i++)
                {
                    output[i] = alph[((alph.IndexOf(Plaintext[i]) ) + (alph.IndexOf(Key[i]) )) % alph.Length];
                }
                string temp = new string(output);
                Ciphertext = temp;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool Decrypt()
        {
            try
            {
                string alph = "јаЅб¬в√гƒд≈е®Є∆ж«з»и…й кЋлћмЌнќоѕп–р—с“т”у‘ф’х÷ц„чЎшўщЏъџы№ьЁэёюя€ .Е,;:{}[]()Ђї0123456789-Ч+=!?@#$%^&*\n";
                char[] decode = new char[Ciphertext.Length];
                for (int i = 0; Key.Length < Ciphertext.Length; i++)
                {
                    Key += Key[i];
                }
                for (int i = 0; i < Ciphertext.Length; i++)
                {
                    decode[i] = alph[((alph.IndexOf(Ciphertext[i]) ) + alph.Length - (alph.IndexOf(Key[i]) )) % alph.Length];
                }
                string temp = new string(decode);
                Plaintext = temp;
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
    public static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]

        static void Main()
        {
            

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

               
                Application.Run(new Main());
            
        }

        static public void register(string login, string password)
        {
            var conn = new SqliteConnection("Data Source=database.db");
            conn.Open();
            SqliteCommand comm = new SqliteCommand($"INSERT INTO Users (login, pass) SELECT '{login}', '{password}' EXCEPT SELECT login, pass FROM Users WHERE login='{login}' AND pass='{password}'", conn);

            comm.ExecuteNonQuery();
            conn.Dispose();

        }

        static public long logincheck(string login)
        {
            var conn = new SqliteConnection("Data Source=database.db;Mode=ReadOnly");
            try
            {
                conn.Open();
                SqliteCommand comm = new SqliteCommand("SELECT _id,login FROM Users", conn);
                SqliteDataReader read = comm.ExecuteReader();

                while (read.Read())
                {
                    if ((string)read[1] == login)
                    {
                        long temp = (long)read[0];
                        conn.Dispose();
                        return temp;
                    }
                }

            }
            catch
            {
                conn.Dispose();
                return -2;//внутренн€€ ошибка
            }
            conn.Dispose();
            return -1; //пользователь не найден

        }

        static public string hash(string information)
        {
            var sha = SHA256.Create();
            information = "/ViC/SpSlt" + information + "+Cr802N11a";
            var hashed = sha.ComputeHash(Encoding.UTF8.GetBytes(information));
            return Convert.ToBase64String(hashed);
        }


    }

}
