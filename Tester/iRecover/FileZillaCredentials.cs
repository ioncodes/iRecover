using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iRecover
{
    public class FileZillaCredentials
    {
        public FileZillaCredentials()
        {
            Host = "not found";
            Port = "not found";
            User = "not found";
            Pass = "not found";
        }

        public FileZillaCredentials(String host, String port, String username, String password)
        {
            Host = host;
            Port = port;
            User = username;
            Pass = password;
        }

        public String Host { get; set; }
        public String Port { get; set; }
        public String User { get; set; }
        public String Pass { get; set; }
    }
}

