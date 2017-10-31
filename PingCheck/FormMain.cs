using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.Threading;

namespace PingCheck
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            //RegionBox.SelectedIndex = 0;
            RegionBox.SelectedItem = Properties.Settings.Default.StandardRegion;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "start")
            {
                button1.Text = "stop";
            }
            else
            {
                button1.Text = "start";
            }
            while (button1.Text == "stop")
            {
                var pingObjekt = new System.Net.NetworkInformation.Ping();
                var pingantwort = pingObjekt.Send(chosehost(), 2000);
                var pingtime = pingantwort.RoundtripTime;
                var pingstatus = pingantwort.Status;
                maleFarbWert(pingantwort);
                ausgabe.Text = pingtime.ToString() + " ms\t" + pingstatus + Environment.NewLine + ausgabe.Text;
                Application.DoEvents();
                Thread.Sleep(500);
            }
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        void maleFarbWert(PingReply reply)
        {
            if (reply.Status == IPStatus.Success)
            {           
                if (reply.RoundtripTime <= 30)
                {       
                    panel1.BackColor = Color.Green;
                }       
                else if (reply.RoundtripTime <= 65)
                {       
                    panel1.BackColor = Color.LightGreen;
                }       
                else if (reply.RoundtripTime <= 150)
                {       
                    panel1.BackColor = Color.Orange;
                }
                else
                {
                    panel1.BackColor = Color.RosyBrown;
                }
            }
            else
            {
                panel1.BackColor = Color.Red;
            }
        } 
        private string chosehost()
        {
            var wahl = RegionBox.SelectedItem;
            switch (wahl)
            {
                case "NA":return "104.160.131.3";
                case "EUW": return "104.160.141.3";
                case "EUNE": return "104.160.142.3";
                case "OCE": return "104.160.156.1";
                case "LAN": return "104.160.136.3";
                case "JPN": return "104.160.154.199";
                default: return "";
            }
        }

        private void GoogleTest_Click(object sender, EventArgs e)
        {
            new Ping();
            var PingTest = new Ping();
            var GooglePing = PingTest.Send("www.google.com", 1000);
            if (GooglePing.Status == IPStatus.Success)
            {
                InternetTest.Text = "available " + GooglePing.RoundtripTime + " ms";
      //          maleFarbWert(GooglePing);
            }
            else
            {
                InternetTest.Text = "unavailable";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void allShowbutton_Click(object sender, EventArgs e)
        {
            var allRegions = new LoLPingCheckShowAll();
            allRegions.Show();

        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            var settings = new FormSettings();

            settings.CheckBoxChangedEvent += Settings_CheckBoxChangedEvent;
            
            settings.Show();
        }

        private void Settings_CheckBoxChangedEvent(object sender, EventArgs e)
        {
            var cb = (CheckBox)sender;
            if (cb.Checked)
            {
                GoogleTest.Enabled = true;
                InternetTest.Visible = true;
            }
            else
            {
                GoogleTest.Enabled = false;
                InternetTest.Visible = false;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void HelpButton_Click(object sender, EventArgs e)
        {
            var help = new FormHelp();
            help.Show();
        }
    }
}
