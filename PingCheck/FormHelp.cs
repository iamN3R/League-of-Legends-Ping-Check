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
    }
}
