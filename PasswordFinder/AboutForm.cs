using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace PasswordFinder
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();

            if (File.Exists("LICENSE"))
            {
                StreamReader LicenseReader = new StreamReader("LICENSE");
                licenseBox.Text = LicenseReader.ReadToEnd();
            }
            licenseBox.ReadOnly = true;
            return;

        }

        private void AboutForm_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void GitPage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            GitPage.LinkVisited = true;
            Process.Start("https://github.com/Re-Coma");
        }
    }
}
