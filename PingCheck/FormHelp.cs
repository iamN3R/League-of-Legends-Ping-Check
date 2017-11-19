using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PingCheck
{
    public partial class FormHelp : Form
    {
        public FormHelp()
        {
            InitializeComponent();
        }

        private void contactbutton_Click(object sender, EventArgs e)
        {
            string targetURL = "http://www.noel.familie-seifert.com/contact/";
            System.Diagnostics.Process.Start(targetURL);
        }

        private void smYoutube_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string smYt = "http://www.youtube.com/nerlp/";
            System.Diagnostics.Process.Start(smYt);
        }

        private void smReddit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string smRed = "https://www.reddit.com/user/iamn3r/";
            System.Diagnostics.Process.Start(smRed);
        }

        private void smInstagram_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string smInsta = "https://www.instagram.com/justxn3r/";
            System.Diagnostics.Process.Start(smInsta);
        }

        private void smWebside_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string smWeb = "http://www.noel.familie-seifert.com/";
            System.Diagnostics.Process.Start(smWeb);
        }
    }
}
