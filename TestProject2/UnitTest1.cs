using NUnit.Framework;
using System;
using System.IO;
using VIC;
using Microsoft.Data.Sqlite;

namespace TestProject2
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            var conn = new SqliteConnection("Data Source=database.db");
            conn.Open();
            SqliteCommand comm = new SqliteCommand("CREATE TABLE IF NOT EXISTS Users (_id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE, login TEXT NOT NULL, pass TEXT NOT NULL)", conn);
            comm.ExecuteNonQuery();
            comm.CommandText = "CREATE TABLE IF NOT EXISTS Documents (_id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE, text TEXT NOT NULL, uid INTEGER NOT NULL)";
            comm.ExecuteNonQuery();
            conn.Dispose();
        }

        [Test]
        public void Test1()
        {
            var conn = new SqliteConnection("Data Source=database.db");
            conn.Open();
            SqliteCommand comm = new SqliteCommand("DELETE FROM Users", conn);
            comm.ExecuteNonQuery();
            comm.CommandText = "DELETE FROM Documents";
            comm.ExecuteNonQuery();
            conn.Dispose();
            Assert.AreEqual(false, User.verify());
        }

        [Test]
        public void Test2()
        {
            var conn = new SqliteConnection("Data Source=database.db");
            conn.Open();
            SqliteCommand comm = new SqliteCommand("DELETE FROM Users", conn);
            comm.ExecuteNonQuery();
            comm.CommandText = "DELETE FROM Documents";
            comm.ExecuteNonQuery();
            conn.Dispose();

            Program.register("test","test");
            User.Login = "test";
            User.Password = "test";
            
            Assert.AreEqual(true, User.verify());
        }

        [Test]
        public void Test3()
        {
            var conn = new SqliteConnection("Data Source=database.db");
            conn.Open();
            SqliteCommand comm = new SqliteCommand("DELETE FROM Users", conn);
            comm.ExecuteNonQuery();
            comm.CommandText = "DELETE FROM Documents";
            comm.ExecuteNonQuery();
            conn.Dispose();

            Assert.AreEqual(-1, Program.logincheck("test"));
        }

        [Test]
        public void Test4()
        {
            var conn = new SqliteConnection("Data Source=database.db");
            conn.Open();
            SqliteCommand comm = new SqliteCommand("DELETE FROM Users", conn);
            comm.ExecuteNonQuery();
            comm.CommandText = "DELETE FROM Documents";
            comm.ExecuteNonQuery();
            conn.Dispose();
            Program.register("test", "test");

            Assert.AreNotEqual(-1,Program.logincheck("test"));
        }

        [Test]
        public void Test5()
        {
            var conn = new SqliteConnection("Data Source=database.db");
            conn.Open();
            SqliteCommand comm = new SqliteCommand("DELETE FROM Users", conn);
            comm.ExecuteNonQuery();
            comm.CommandText = "DELETE FROM Documents";
            comm.ExecuteNonQuery();
            conn.Dispose();
            Program.register("test", "test");

            Assert.AreNotEqual(-2, Program.logincheck("test"));
        }

        [Test]
        public void Test6()
        {
            Document.Plaintext = "null";
            Document.Key = "null";
            Document.Ciphertext = "null";
            Assert.AreEqual(false, Document.Encrypt());
        }
        [Test]
        public void Test7()
        {
            Document.Plaintext = " а–л у  Ћары ук–ал корјллы";
            Document.Key = "т≈ст";
            Assert.AreEqual(true, Document.Encrypt());
        }

        [Test]
        public void Test8()
        {
            Document.Plaintext = Document.Plaintext.Remove(0);
            Document.Key = Document.Key.Remove(0);
            Document.Ciphertext = Document.Ciphertext.Remove(0);
            Assert.AreEqual(true, Document.Decrypt());
        }

        [Test]
        public void Test9()
        {
            Document.Ciphertext = "1-0489i1pjmrp1-08ri-1fmj[-120ui3r5-1nf-[1ohj-49rhj1[orfn=[qnjv-[owefsjhg-1jr31rt-=19thf1= 1=r5ki 1/n/n/n/nn\\n\n\"";
            Assert.AreEqual(false, Document.Decrypt());
        }

        [Test]
        public void Test10()
        {
            Document.Plaintext = " а–л у  Ћары ук–ал корјллы\n да";
            Document.Key = "т≈ст";
            Document.Encrypt();
            Document.Decrypt();

            Assert.AreEqual(Document.Plaintext, " а–л у  Ћары ук–ал корјллы\n да");
        }
    }
}