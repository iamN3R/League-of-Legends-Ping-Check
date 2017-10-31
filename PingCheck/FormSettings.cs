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
    public partial class FormSettings : Form
    {
        public FormSettings()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var ausgewRegion = comboBox1.SelectedItem as string;
            Properties.Settings.Default.StandardRegion = ausgewRegion;
            Properties.Settings.Default.Save();
        }

        private void cbColorshow_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void cbGeneraltest_CheckedChanged(object sender, EventArgs e)
        {
            //if(cbGeneraltest.Checked == false)
            //{
                CheckBoxChangedEvent(cbGeneraltest, e);
            //}
        }

        public event EventHandler CheckBoxChangedEvent;
    }
}
