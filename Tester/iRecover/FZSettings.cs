using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iRecover
{
    class FZSettings
    {
            private const String FileZillaFolderName = "FileZilla";
            private const String FileZillaRecentServersFileName = "recentservers.xml";
            private const String FileZillaSiteManagerFileName = "sitemanager.xml";

            public static String FileZillaFolder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) +
                Path.DirectorySeparatorChar + FileZillaFolderName + Path.DirectorySeparatorChar;
            public static String FileZillaRecentServersFile = FileZillaFolder + FileZillaRecentServersFileName;
            public static String FileZillaSiteManagerFile = FileZillaFolder + FileZillaSiteManagerFileName;
        
    }
}
