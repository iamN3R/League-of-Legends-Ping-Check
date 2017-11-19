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
            setGoogleTest(Properties.Settings.Default.Generaltest);
            setColor(Properties.Settings.Default.ColorInd);
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
                case "LAS": return "104.160.153.35";
                case "TUR": return "162.249.79.82";
                case "BR": return "8.23.25.28";
                case "RUS": return "162.249.72.35";
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
            settings.CheckBoxChangedEventColor += Settings_CheckBoxChangedEventColor;
            
            settings.Show();
        }

        private void Settings_CheckBoxChangedEventColor(object sender, EventArgs e)
        {
            var cb = (CheckBox)sender;
            if (cb.Checked)
            {
                panel1.Visible = true;
            }
            else
            {
                panel1.Visible = false;
            }
        }

        private void Settings_CheckBoxChangedEvent(object sender, EventArgs e)
        {
            var cb = (CheckBox)sender;
            if (cb.Checked)
            {
                setGoogleTest(true);
            }
            else
            {
                setGoogleTest(false);
            }
        }

        void setGoogleTest(bool aktiv)
        {
            GoogleTest.Enabled = aktiv;
            InternetTest.Visible = aktiv;

        }

        void setColor(bool aktiv)
        {
            panel1.Visible = aktiv;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void HelpButton_Click(object sender, EventArgs e)
        {
            var help = new FormHelp();
            help.Show();
        }

        private void AboutButton_Click(object sender, EventArgs e)
        {
            var about = new FormAbout();
            about.Show();
        }

        private void InfobtnMain_Click(object sender, EventArgs e)
        {
            var info = new FormInformation();
            info.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void clearbutton_Click(object sender, EventArgs e)
        {
            ausgabe.Text = "";
        }
    }
}
