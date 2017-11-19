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
    public partial class FormAbout : Form
    {
        public FormAbout()
        {
            InitializeComponent();
        }

        private void FormAbout_Load(object sender, EventArgs e)
        {
            
        }

        static void FormAboutVersion()
        {
            Console.WriteLine("The version of the currently executing assembly is: {0}",
                typeof(FormAbout).Assembly.GetName().Version);

            Console.WriteLine("The version of mscorlib.dll is: {0}",
                typeof(String).Assembly.GetName().Version);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string CCURL = "http://creativecommons.org/licenses/by-nc-sa/4.0/";
            System.Diagnostics.Process.Start(CCURL);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string downloadURL = "http://www.noel.familie-seifert.com/programs";
            System.Diagnostics.Process.Start(downloadURL);
        }
    }
}
