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

        public FileZillaCredentials(string host, string port, string username, string password)
        {
            Host = host;
            Port = port;
            User = username;
            Pass = password;
        }

        public string Host { get; set; }
        public string Port { get; set; }
        public string User { get; set; }
        public string Pass { get; set; }
    }
}

