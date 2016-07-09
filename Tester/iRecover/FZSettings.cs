using System;
using System.IO;

namespace iRecover
{
    class FZSettings
    {
            private const string FileZillaFolderName = "FileZilla";
            private const string FileZillaRecentServersFileName = "recentservers.xml";
            private const string FileZillaSiteManagerFileName = "sitemanager.xml";

            public static string FileZillaFolder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) +
                Path.DirectorySeparatorChar + FileZillaFolderName + Path.DirectorySeparatorChar;
            public static string FileZillaRecentServersFile = FileZillaFolder + FileZillaRecentServersFileName;
            public static string FileZillaSiteManagerFile = FileZillaFolder + FileZillaSiteManagerFileName;
        
    }
}
