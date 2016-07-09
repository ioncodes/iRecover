using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iRecover
{
    public static class Helper
    {
        public static List<string> FileZillaCredentialsToListString(List<FileZillaCredentials> ls)
        {
            List<string> temp = new List<string>();
            foreach (var item in ls)
            {
                temp.Add("Host: " + item.Host + " Port: " + item.Port + " User: " + item.User + " Password: " + item.Pass);
            }
            return temp;
        }
    }
}
