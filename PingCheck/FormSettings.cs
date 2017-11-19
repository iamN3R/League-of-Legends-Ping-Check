using Microsoft.Win32;
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
        private RegistryKey baseRegistryKey;
        private string subKey;

        public FormSettings()
        {
            InitializeComponent();
            cbGeneraltest.Checked = Properties.Settings.Default.Generaltest;
            cbColorshow.Checked = Properties.Settings.Default.ColorInd;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var ausgewRegion = comboBox1.SelectedItem as string;
            Properties.Settings.Default.StandardRegion = ausgewRegion;
            cbGeneraltest.Checked = Properties.Settings.Default.Generaltest;
            Properties.Settings.Default.Save();
        }

        private void cbColorshow_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxChangedEventColor != null)
            CheckBoxChangedEventColor(cbColorshow, e);
            Properties.Settings.Default.ColorInd = cbColorshow.Checked;
            Properties.Settings.Default.Save();
        }

        private void cbGeneraltest_CheckedChanged(object sender, EventArgs e)
        {
            if(CheckBoxChangedEvent != null)
            CheckBoxChangedEvent(cbGeneraltest, e);
            Properties.Settings.Default.Generaltest = cbGeneraltest.Checked;
            Properties.Settings.Default.Save();
        }

        public event EventHandler CheckBoxChangedEvent;

        public event EventHandler CheckBoxChangedEventColor;

        private void RegisterInStartUp(bool isChecked)
        {
            RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

            if (isChecked)
            {
                registryKey.SetValue("LoL Ping Check", Application.ExecutablePath);
            }
            else
            {
                registryKey.DeleteValue("LoL Ping Check");
            }
        }

        private void cbWinStart_CheckedChanged(object sender, EventArgs e)
        {
            RegisterInStartUp(cbWinStart.Checked);
            if (cbWinStart.Checked)
            {
                winStatlabel.Text = "on";
                Properties.Settings.Default.Winstatlabel = "on";
                Properties.Settings.Default.Save();
            }
            else
            {
                winStatlabel.Text = "off";
                Properties.Settings.Default.Winstatlabel = "off";
                Properties.Settings.Default.Save();
            }
        }

        public string Read(string KeyName)
        {
            RegistryKey rk = baseRegistryKey;
            RegistryKey sk1 = rk.OpenSubKey(subKey);
            if(sk1 == null)
            {
                return null;
            }
            else
            {
                try
                {
                    return (string)sk1.GetValue(KeyName.ToUpper());
                }
                catch (Exception e)
                {
                   ShowErrorMessage(e, "Reading registry " + KeyName.ToUpper());
                    return null;
                }
            }

        }


        private void ShowErrorMessage(Exception e, string v)
        {
            throw new NotImplementedException();
        }

        private void FormSettings_Load(object sender, EventArgs e)
        {
        //    if(Properties.Settings.Default.Winstatlabel == "on")
        if(ISWinStartOn())
            {
                cbWinStart.Checked = true;
                winStatlabel.Text = "on";
            }
            else
            {
                cbWinStart.Checked = false;
                winStatlabel.Text = "off";
            }
        }

        private bool ISWinStartOn()
        {
            var reg = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Default);
            var key = reg.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run");
            var regValue = key.GetValue("LoL Ping Check") as string;
            if (regValue != null)
            {
                return regValue == Application.ExecutablePath;
            }
            else return false;            
        }
    }

}
