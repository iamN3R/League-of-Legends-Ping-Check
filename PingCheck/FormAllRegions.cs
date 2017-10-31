using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Net.NetworkInformation;
using System.Diagnostics;

namespace PingCheck
{
    public partial class LoLPingCheckShowAll : Form
    {
        public LoLPingCheckShowAll()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Diese Methode wird beim Öffnen des Fensters ausgeführt
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoLPingCheckShowAll_Load(object sender, EventArgs e)
        {
            bgwOCE.RunWorkerAsync();
            bgwJPN.RunWorkerAsync();
            bgwEUW.RunWorkerAsync();
            bgwEUNE.RunWorkerAsync();
            bgwNA.RunWorkerAsync();
            bgwLAN.RunWorkerAsync();
        }

        private void spezialTick(string regionName, CheckBox cb, Label label)
        {
            if (cb.Checked == true)
            {
                label.Text = RegionPing(regionName);
            }
            else
            {
                label.Text = "paused";
            }
        }

        private string spezialTick2(string regionName, CheckBox cb, Label label)
        {
            if (cb.Checked == true)
            {
                return RegionPing(regionName);
            }
            else
            {
                return "paused";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            spezialTick("EUW", allEUW, allEUWlabel);
            //if(allEUW.Checked == true)
            //{
            //    allEUWlabel.Text = RegionPing("EUW");
            //}
            //else
            //{
            //    allEUWlabel.Text = "paused";
            //}
        }

        private string RegionPing(string RegionName)
        {
            var giveserveripclass = new LoLServer();
            var pingallEUW = new System.Net.NetworkInformation.Ping();
            var region = giveserveripclass.giveserverip(RegionName);
            
            var pingallEUWantwort = pingallEUW.Send(region, 2000);

            var pingallEUWtime = pingallEUWantwort.RoundtripTime;
            var pingallEUWstatus = pingallEUWantwort.Status;
            return pingallEUWtime.ToString() + " ms\t " + pingallEUWstatus;
            
        }

        private PingReply RegionPing2(string RegionName)
        {
            var giveserveripclass = new LoLServer();
            var pingallEUW = new System.Net.NetworkInformation.Ping();
            var region = giveserveripclass.giveserverip(RegionName);

            var pingallEUWantwort = pingallEUW.Send(region, 2000);
            return pingallEUWantwort;
        }

        private void allEUWlabel_Click(object sender, EventArgs e)
        {
           
        }



        void allgemeinerDowork(CheckBox cb, string region, Label label, BackgroundWorker bgw)
        {
            do
            {
                if (cb.Checked)
                {
                    var pingResultat = RegionPing2(region);

                    var text = pingResultat.RoundtripTime.ToString() + " ms\t " + pingResultat.Status;

                    bgw.ReportProgress((int) pingResultat.RoundtripTime, text);
                }
                Thread.Sleep(250);
            }
            while (true);
        }

        void allgemeinerProgressChanged(ProgressChangedEventArgs e, Label label, Panel panel)
        {
            label.Text = e.UserState as string;
            if (e.ProgressPercentage == 0)
            {
                panel.BackColor = Color.Red;
            }
            else if (e.ProgressPercentage < 30)
            {
                panel.BackColor = Color.LightGreen;
            }
            else if (e.ProgressPercentage < 65)
            {
                panel.BackColor = Color.Green;
            }
            else if (e.ProgressPercentage < 150)
            {
                panel.BackColor = Color.Yellow;
            }
            else
            {
                panel.BackColor = Color.Red;
            }
        }

        private void bgwOCE_DoWork(object sender, DoWorkEventArgs e)
        {
            allgemeinerDowork(allOCE, "OCE", allOCElabel, bgwOCE);
        }
        
        private void bgwOCE_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            allgemeinerProgressChanged(e, allOCElabel, allOCEfarbe);
        }

        private void bgwJPN_DoWork(object sender, DoWorkEventArgs e)
        {
            allgemeinerDowork(allJPN, "JPN", allJPNlabel, bgwJPN);
        }

        private void bgwJPN_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            allgemeinerProgressChanged(e, allJPNlabel, allJPNfarbe);
        }

        private void bgwEUW_DoWork(object sender, DoWorkEventArgs e)
        {
            allgemeinerDowork(allEUW, "EUW", allEUWlabel, bgwEUW);
        }

        private void bgwEUW_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            allgemeinerProgressChanged(e, allEUWlabel, allEUWfarbe);
        }

        private void bgwEUNE_DoWork(object sender, DoWorkEventArgs e)
        {
            allgemeinerDowork(allEUNE, "EUNE", allEUNElabel, bgwEUNE);
        }

        private void bgwEUNE_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            allgemeinerProgressChanged(e, allEUNElabel, allEUNEfarbe);
        }

        private void bgwNA_DoWork(object sender, DoWorkEventArgs e)
        {
            allgemeinerDowork(allNA, "NA", allNAlabel, bgwNA);
        }

        private void bgwNA_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            allgemeinerProgressChanged(e, allNAlabel, allNAfarbe);
        }

        private void bgwLAN_DoWork(object sender, DoWorkEventArgs e)
        {
            allgemeinerDowork(allLAN, "LAN", allLANlabel, bgwLAN);
        }

        private void bgwLAN_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            allgemeinerProgressChanged(e, allLANlabel, allLANfarbe);
        }
    }
}
