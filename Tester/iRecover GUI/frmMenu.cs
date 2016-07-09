using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using iRecover;

namespace iRecover_GUI
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }


        // Browsers

        private void btnRecoverFFPass_Click(object sender, EventArgs e)
        {
            if(abResult.Visible == false)
            {
                abResult.Visible = true;
            }

            abResult.Text = "Running";
            abResult.Style = Reflection.rAlertBox.Styles.Blue;
            try
            {
                var FFpasses = Browsers.FireFoxPassword();
                SaveToFile("firefox_passes.txt", FFpasses);
                abResult.Text = "Success!";
                abResult.Style = Reflection.rAlertBox.Styles.Green;
            }
            catch
            {
                abResult.Text = "Error!";
                abResult.Style = Reflection.rAlertBox.Styles.Red;
            }
        }

        private void btnRecoverFFCookies_Click(object sender, EventArgs e)
        {
            if (abResult.Visible == false)
            {
                abResult.Visible = true;
            }

            abResult.Text = "Running";
            abResult.Style = Reflection.rAlertBox.Styles.Blue;
            try
            {
                var FFcookies = Browsers.FireFoxCookies();
                SaveToFile("firefox_cookies.txt", FFcookies);
                abResult.Text = "Success!";
                abResult.Style = Reflection.rAlertBox.Styles.Green;
            }
            catch
            {
                abResult.Text = "Error!";
                abResult.Style = Reflection.rAlertBox.Styles.Red;
            }
        }

        private void btnRecoverChrome_Click(object sender, EventArgs e)
        {
            if (abResult.Visible == false)
            {
                abResult.Visible = true;
            }

            abResult.Text = "Running";
            abResult.Style = Reflection.rAlertBox.Styles.Blue;
            try
            {
                var chromePasses = Browsers.ChromePassword();
                SaveToFile("chrome_passes.txt", chromePasses);
                abResult.Text = "Success!";
                abResult.Style = Reflection.rAlertBox.Styles.Green;
            }
            catch
            {
                abResult.Text = "Error!";
                abResult.Style = Reflection.rAlertBox.Styles.Red;
            }
        }

        
        // Tools

        private void btnRecoverFZHosts_Click(object sender, EventArgs e)
        {
            if (abStatusTools.Visible == false)
            {
                abStatusTools.Visible = true;
            }

            abStatusTools.Text = "Running";
            abStatusTools.Style = Reflection.rAlertBox.Styles.Blue;
            try
            {
                var fzHosts = Tools.FileZilla();
                SaveToFile("filezilla_hosts.txt", fzHosts);
                abStatusTools.Text = "Success!";
                abStatusTools.Style = Reflection.rAlertBox.Styles.Green;
            }
            catch
            {
                abStatusTools.Text = "Error!";
                abStatusTools.Style = Reflection.rAlertBox.Styles.Red;
            }
        } 
        
        #region SaveFile

        private void SaveToFile(string name, List<FirefoxPassword> ls)
        {
            File.WriteAllLines(name, ls.ConvertAll(Convert.ToString));
        }

        private void SaveToFile(string name, List<FirefoxCookie> ls)
        {
            File.WriteAllLines(name, ls.ConvertAll(Convert.ToString));
        }

        private void SaveToFile(string name, List<string> ls)
        {
            File.WriteAllLines(name, ls);
        }

        #endregion
    }
}
