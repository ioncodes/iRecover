# iRecover
Password Recovery Library written in .NET

## iRecover GUI
Browsers:
- Firefox Passwords & Cookies
- Google Chrome Passwords

Tools:
- FileZilla old & new


## iRecover Library
There are 3 classes: Browsers, Tools, Helper

Browsers:
FireFoxPassword() returns List<FirefoxPassword>;
FireFoxCookie() returns List<FirefoxCookie>;
ChromePassword() returns List<string>;

Tools:
FileZillaAll() [new & old compatible] returns List<FileZillaCredentials>;
FileZillaRecentServers() [old] returns List<FileZillaCredentials>;
FileZillaSiteManager() [new] returns List<FileZillaCredentials>;

*** Check Helper for List<FileZillaCredentials>

Helper:
FileZillaCredentialsToListString(List<FileZillaCredentials> ls) returns List<string>;


# Disclaimer
I'm not responsible for what you will use this! It's only for educational purposes!
