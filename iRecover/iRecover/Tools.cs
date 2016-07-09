using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Text;

namespace iRecover
{
    public static class Tools
    {
        public static List<FileZillaCredentials> FileZillaAll()
        {
            var rs = ReadFile(FZSettings.FileZillaRecentServersFile);
            var sm = ReadFile(FZSettings.FileZillaSiteManagerFile);
            var all = new List<FileZillaCredentials>(rs.Count + sm.Count);
            all.AddRange(rs);
            all.AddRange(sm);
            return all;
        }

        public static List<FileZillaCredentials> FileZillaRecentServers()
        {
            return ReadFile(FZSettings.FileZillaRecentServersFile);
        }

        public static List<FileZillaCredentials> FileZillaSiteManager()
        {
            return ReadFile(FZSettings.FileZillaSiteManagerFile);
        }

        private static List<FileZillaCredentials> ReadFile(string filename)
        {
            List<FileZillaCredentials> _list = new List<FileZillaCredentials>();

                if (File.Exists(filename))
                {
                    XmlTextReader xmlTReader = new XmlTextReader(filename);
                    XmlDocument xmlDoc = new XmlDocument();
                    xmlDoc.Load(xmlTReader);

                    foreach (XmlNode xmlNode in xmlDoc.DocumentElement.ChildNodes[0].ChildNodes)
                    {
                        FileZillaCredentials fzc = new FileZillaCredentials();
                        foreach (XmlNode xmlNodeChild in xmlNode.ChildNodes)
                        {
                            if (xmlNodeChild.Name == "Host")
                                fzc.Host = xmlNodeChild.InnerText;
                            if (xmlNodeChild.Name == "Port")
                                fzc.Port = xmlNodeChild.InnerText;
                            if (xmlNodeChild.Name == "User")
                                fzc.User = xmlNodeChild.InnerText;
                            if (xmlNodeChild.Name == "Pass")
                                fzc.Pass = Encoding.UTF8.GetString(Convert.FromBase64String(xmlNodeChild.InnerText));
                        }
                        _list.Add(fzc);
                    }
                }

                return _list;
        }
    }
}

