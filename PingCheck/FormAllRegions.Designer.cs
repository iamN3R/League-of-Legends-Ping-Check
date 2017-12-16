namespace PingCheck
{
    partial class LoLPingCheckShowAll
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoLPingCheckShowAll));
            this.allEUW = new System.Windows.Forms.CheckBox();
            this.allEUNE = new System.Windows.Forms.CheckBox();
            this.allNA = new System.Windows.Forms.CheckBox();
            this.allOCE = new System.Windows.Forms.CheckBox();
            this.allLAN = new System.Windows.Forms.CheckBox();
            this.allLAS = new System.Windows.Forms.CheckBox();
            this.allRUS = new System.Windows.Forms.CheckBox();
            this.allTUR = new System.Windows.Forms.CheckBox();
            this.allEUWfarbe = new System.Windows.Forms.Panel();
            this.allEUNEfarbe = new System.Windows.Forms.Panel();
            this.allNAfarbe = new System.Windows.Forms.Panel();
            this.allOCEfarbe = new System.Windows.Forms.Panel();
            this.allLANfarbe = new System.Windows.Forms.Panel();
            this.allLASfarbe = new System.Windows.Forms.Panel();
            this.allRUSfarbe = new System.Windows.Forms.Panel();
            this.allTURfarbe = new System.Windows.Forms.Panel();
            this.allEUWlabel = new System.Windows.Forms.Label();
            this.allEUNElabel = new System.Windows.Forms.Label();
            this.allNAlabel = new System.Windows.Forms.Label();
            this.allOCElabel = new System.Windows.Forms.Label();
            this.allLANlabel = new System.Windows.Forms.Label();
            this.allLASlabel = new System.Windows.Forms.Label();
            this.allRUSlabel = new System.Windows.Forms.Label();
            this.allTURlabel = new System.Windows.Forms.Label();
            this.bgwOCE = new System.ComponentModel.BackgroundWorker();
            this.bgwEUW = new System.ComponentModel.BackgroundWorker();
            this.bgwEUNE = new System.ComponentModel.BackgroundWorker();
            this.bgwNA = new System.ComponentModel.BackgroundWorker();
            this.bgwLAN = new System.ComponentModel.BackgroundWorker();
            this.InfoBtnAllRegions = new System.Windows.Forms.Button();
            this.bgwLAS = new System.ComponentModel.BackgroundWorker();
            this.bgwBR = new System.ComponentModel.BackgroundWorker();
            this.allBR = new System.Windows.Forms.CheckBox();
            this.allBRlabel = new System.Windows.Forms.Label();
            this.allBRfarbe = new System.Windows.Forms.Panel();
            this.bgwRUS = new System.ComponentModel.BackgroundWorker();
            this.bgwTUR = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // allEUW
            // 
            this.allEUW.AutoSize = true;
            this.allEUW.Checked = true;
            this.allEUW.CheckState = System.Windows.Forms.CheckState.Checked;
            this.allEUW.Location = new System.Drawing.Point(12, 12);
            this.allEUW.Name = "allEUW";
            this.allEUW.Size = new System.Drawing.Size(52, 17);
            this.allEUW.TabIndex = 0;
            this.allEUW.Text = "EUW";
            this.allEUW.UseVisualStyleBackColor = true;
            this.allEUW.CheckedChanged += new System.EventHandler(this.allEUW_CheckedChanged);
            // 
            // allEUNE
            // 
            this.allEUNE.AutoSize = true;
            this.allEUNE.Checked = true;
            this.allEUNE.CheckState = System.Windows.Forms.CheckState.Checked;
            this.allEUNE.Location = new System.Drawing.Point(12, 35);
            this.allEUNE.Name = "allEUNE";
            this.allEUNE.Size = new System.Drawing.Size(56, 17);
            this.allEUNE.TabIndex = 1;
            this.allEUNE.Text = "EUNE";
            this.allEUNE.UseVisualStyleBackColor = true;
            // 
            // allNA
            // 
            this.allNA.AutoSize = true;
            this.allNA.Checked = true;
            this.allNA.CheckState = System.Windows.Forms.CheckState.Checked;
            this.allNA.Location = new System.Drawing.Point(12, 58);
            this.allNA.Name = "allNA";
            this.allNA.Size = new System.Drawing.Size(41, 17);
            this.allNA.TabIndex = 2;
            this.allNA.Text = "NA";
            this.allNA.UseVisualStyleBackColor = true;
            // 
            // allOCE
            // 
            this.allOCE.AutoSize = true;
            this.allOCE.Checked = true;
            this.allOCE.CheckState = System.Windows.Forms.CheckState.Checked;
            this.allOCE.Location = new System.Drawing.Point(12, 81);
            this.allOCE.Name = "allOCE";
            this.allOCE.Size = new System.Drawing.Size(48, 17);
            this.allOCE.TabIndex = 3;
            this.allOCE.Text = "OCE";
            this.allOCE.UseVisualStyleBackColor = true;
            // 
            // allLAN
            // 
            this.allLAN.AutoSize = true;
            this.allLAN.Checked = true;
            this.allLAN.CheckState = System.Windows.Forms.CheckState.Checked;
            this.allLAN.Location = new System.Drawing.Point(12, 103);
            this.allLAN.Name = "allLAN";
            this.allLAN.Size = new System.Drawing.Size(47, 17);
            this.allLAN.TabIndex = 5;
            this.allLAN.Text = "LAN";
            this.allLAN.UseVisualStyleBackColor = true;
            // 
            // allLAS
            // 
            this.allLAS.AutoSize = true;
            this.allLAS.Checked = true;
            this.allLAS.CheckState = System.Windows.Forms.CheckState.Checked;
            this.allLAS.Location = new System.Drawing.Point(12, 126);
            this.allLAS.Name = "allLAS";
            this.allLAS.Size = new System.Drawing.Size(46, 17);
            this.allLAS.TabIndex = 6;
            this.allLAS.Text = "LAS";
            this.allLAS.UseVisualStyleBackColor = true;
            this.allLAS.CheckedChanged += new System.EventHandler(this.allLAS_CheckedChanged);
            // 
            // allRUS
            // 
            this.allRUS.AutoSize = true;
            this.allRUS.Checked = true;
            this.allRUS.CheckState = System.Windows.Forms.CheckState.Checked;
            this.allRUS.Location = new System.Drawing.Point(12, 149);
            this.allRUS.Name = "allRUS";
            this.allRUS.Size = new System.Drawing.Size(49, 17);
            this.allRUS.TabIndex = 7;
            this.allRUS.Text = "RUS";
            this.allRUS.UseVisualStyleBackColor = true;
            // 
            // allTUR
            // 
            this.allTUR.AutoSize = true;
            this.allTUR.Checked = true;
            this.allTUR.CheckState = System.Windows.Forms.CheckState.Checked;
            this.allTUR.Location = new System.Drawing.Point(12, 172);
            this.allTUR.Name = "allTUR";
            this.allTUR.Size = new System.Drawing.Size(49, 17);
            this.allTUR.TabIndex = 8;
            this.allTUR.Text = "TUR";
            this.allTUR.UseVisualStyleBackColor = true;
            // 
            // allEUWfarbe
            // 
            this.allEUWfarbe.Location = new System.Drawing.Point(263, 12);
            this.allEUWfarbe.Name = "allEUWfarbe";
            this.allEUWfarbe.Size = new System.Drawing.Size(17, 17);
            this.allEUWfarbe.TabIndex = 9;
            // 
            // allEUNEfarbe
            // 
            this.allEUNEfarbe.Location = new System.Drawing.Point(263, 35);
            this.allEUNEfarbe.Name = "allEUNEfarbe";
            this.allEUNEfarbe.Size = new System.Drawing.Size(17, 17);
            this.allEUNEfarbe.TabIndex = 10;
            // 
            // allNAfarbe
            // 
            this.allNAfarbe.Location = new System.Drawing.Point(263, 58);
            this.allNAfarbe.Name = "allNAfarbe";
            this.allNAfarbe.Size = new System.Drawing.Size(17, 17);
            this.allNAfarbe.TabIndex = 11;
            // 
            // allOCEfarbe
            // 
            this.allOCEfarbe.Location = new System.Drawing.Point(263, 81);
            this.allOCEfarbe.Name = "allOCEfarbe";
            this.allOCEfarbe.Size = new System.Drawing.Size(17, 17);
            this.allOCEfarbe.TabIndex = 12;
            // 
            // allLANfarbe
            // 
            this.allLANfarbe.Location = new System.Drawing.Point(263, 103);
            this.allLANfarbe.Name = "allLANfarbe";
            this.allLANfarbe.Size = new System.Drawing.Size(17, 17);
            this.allLANfarbe.TabIndex = 14;
            // 
            // allLASfarbe
            // 
            this.allLASfarbe.Location = new System.Drawing.Point(263, 126);
            this.allLASfarbe.Name = "allLASfarbe";
            this.allLASfarbe.Size = new System.Drawing.Size(17, 17);
            this.allLASfarbe.TabIndex = 15;
            // 
            // allRUSfarbe
            // 
            this.allRUSfarbe.Location = new System.Drawing.Point(263, 149);
            this.allRUSfarbe.Name = "allRUSfarbe";
            this.allRUSfarbe.Size = new System.Drawing.Size(17, 17);
            this.allRUSfarbe.TabIndex = 16;
            // 
            // allTURfarbe
            // 
            this.allTURfarbe.Location = new System.Drawing.Point(263, 172);
            this.allTURfarbe.Name = "allTURfarbe";
            this.allTURfarbe.Size = new System.Drawing.Size(17, 17);
            this.allTURfarbe.TabIndex = 17;
            // 
            // allEUWlabel
            // 
            this.allEUWlabel.Location = new System.Drawing.Point(70, 12);
            this.allEUWlabel.Name = "allEUWlabel";
            this.allEUWlabel.Size = new System.Drawing.Size(187, 17);
            this.allEUWlabel.TabIndex = 18;
            this.allEUWlabel.Text = "pingtest starting...";
            this.allEUWlabel.Click += new System.EventHandler(this.allEUWlabel_Click);
            // 
            // allEUNElabel
            // 
            this.allEUNElabel.Location = new System.Drawing.Point(70, 35);
            this.allEUNElabel.Name = "allEUNElabel";
            this.allEUNElabel.Size = new System.Drawing.Size(187, 17);
            this.allEUNElabel.TabIndex = 19;
            this.allEUNElabel.Text = "pingtest starting...";
            // 
            // allNAlabel
            // 
            this.allNAlabel.Location = new System.Drawing.Point(70, 58);
            this.allNAlabel.Name = "allNAlabel";
            this.allNAlabel.Size = new System.Drawing.Size(187, 17);
            this.allNAlabel.TabIndex = 20;
            this.allNAlabel.Text = "pingtest starting...";
            // 
            // allOCElabel
            // 
            this.allOCElabel.Location = new System.Drawing.Point(70, 81);
            this.allOCElabel.Name = "allOCElabel";
            this.allOCElabel.Size = new System.Drawing.Size(187, 17);
            this.allOCElabel.TabIndex = 21;
            this.allOCElabel.Text = "pingtest starting...";
            // 
            // allLANlabel
            // 
            this.allLANlabel.Location = new System.Drawing.Point(70, 104);
            this.allLANlabel.Name = "allLANlabel";
            this.allLANlabel.Size = new System.Drawing.Size(187, 17);
            this.allLANlabel.TabIndex = 23;
            this.allLANlabel.Text = "pingtest starting...";
            // 
            // allLASlabel
            // 
            this.allLASlabel.Location = new System.Drawing.Point(70, 126);
            this.allLASlabel.Name = "allLASlabel";
            this.allLASlabel.Size = new System.Drawing.Size(187, 17);
            this.allLASlabel.TabIndex = 24;
            this.allLASlabel.Text = "pingtest starting...";
            // 
            // allRUSlabel
            // 
            this.allRUSlabel.Location = new System.Drawing.Point(70, 149);
            this.allRUSlabel.Name = "allRUSlabel";
            this.allRUSlabel.Size = new System.Drawing.Size(187, 17);
            this.allRUSlabel.TabIndex = 25;
            this.allRUSlabel.Text = "pingtest starting...";
            // 
            // allTURlabel
            // 
            this.allTURlabel.Location = new System.Drawing.Point(70, 172);
            this.allTURlabel.Name = "allTURlabel";
            this.allTURlabel.Size = new System.Drawing.Size(187, 17);
            this.allTURlabel.TabIndex = 26;
            this.allTURlabel.Text = "pingtest starting...";
            // 
            // bgwOCE
            // 
            this.bgwOCE.WorkerReportsProgress = true;
            this.bgwOCE.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwOCE_DoWork);
            this.bgwOCE.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgwOCE_ProgressChanged);
            // 
            // bgwEUW
            // 
            this.bgwEUW.WorkerReportsProgress = true;
            this.bgwEUW.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwEUW_DoWork);
            this.bgwEUW.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgwEUW_ProgressChanged);
            // 
            // bgwEUNE
            // 
            this.bgwEUNE.WorkerReportsProgress = true;
            this.bgwEUNE.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwEUNE_DoWork);
            this.bgwEUNE.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgwEUNE_ProgressChanged);
            // 
            // bgwNA
            // 
            this.bgwNA.WorkerReportsProgress = true;
            this.bgwNA.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwNA_DoWork);
            this.bgwNA.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgwNA_ProgressChanged);
            // 
            // bgwLAN
            // 
            this.bgwLAN.WorkerReportsProgress = true;
            this.bgwLAN.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwLAN_DoWork);
            this.bgwLAN.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgwLAN_ProgressChanged);
            // 
            // InfoBtnAllRegions
            // 
            this.InfoBtnAllRegions.Location = new System.Drawing.Point(12, 215);
            this.InfoBtnAllRegions.Name = "InfoBtnAllRegions";
            this.InfoBtnAllRegions.Size = new System.Drawing.Size(268, 21);
            this.InfoBtnAllRegions.TabIndex = 27;
            this.InfoBtnAllRegions.Text = "Region Information";
            this.InfoBtnAllRegions.UseVisualStyleBackColor = true;
            // 
            // bgwLAS
            // 
            this.bgwLAS.WorkerReportsProgress = true;
            this.bgwLAS.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwLAS_DoWork);
            this.bgwLAS.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgwLAS_ProgressChanged);
            // 
            // bgwBR
            // 
            this.bgwBR.WorkerReportsProgress = true;
            this.bgwBR.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwBR_DoWork);
            this.bgwBR.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BgwBR_ProgressChanged);
            // 
            // allBR
            // 
            this.allBR.AutoSize = true;
            this.allBR.Checked = true;
            this.allBR.CheckState = System.Windows.Forms.CheckState.Checked;
            this.allBR.Location = new System.Drawing.Point(12, 192);
            this.allBR.Name = "allBR";
            this.allBR.Size = new System.Drawing.Size(41, 17);
            this.allBR.TabIndex = 8;
            this.allBR.Text = "BR";
            this.allBR.UseVisualStyleBackColor = true;
            // 
            // allBRlabel
            // 
            this.allBRlabel.Location = new System.Drawing.Point(70, 192);
            this.allBRlabel.Name = "allBRlabel";
            this.allBRlabel.Size = new System.Drawing.Size(187, 17);
            this.allBRlabel.TabIndex = 26;
            this.allBRlabel.Text = "pingtest starting...";
            // 
            // allBRfarbe
            // 
            this.allBRfarbe.Location = new System.Drawing.Point(263, 192);
            this.allBRfarbe.Name = "allBRfarbe";
            this.allBRfarbe.Size = new System.Drawing.Size(17, 17);
            this.allBRfarbe.TabIndex = 17;
            // 
            // bgwRUS
            // 
            this.bgwRUS.WorkerReportsProgress = true;
            this.bgwRUS.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwRUS_DoWork);
            this.bgwRUS.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BgwRUS_ProgressChanged);
            // 
            // bgwTUR
            // 
            this.bgwTUR.WorkerReportsProgress = true;
            this.bgwTUR.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwTUR_DoWork);
            this.bgwTUR.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BgwTUR_ProgressChanged);
            // 
            // LoLPingCheckShowAll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 248);
            this.Controls.Add(this.InfoBtnAllRegions);
            this.Controls.Add(this.allBRlabel);
            this.Controls.Add(this.allTURlabel);
            this.Controls.Add(this.allRUSlabel);
            this.Controls.Add(this.allLASlabel);
            this.Controls.Add(this.allLANlabel);
            this.Controls.Add(this.allOCElabel);
            this.Controls.Add(this.allNAlabel);
            this.Controls.Add(this.allEUNElabel);
            this.Controls.Add(this.allEUWlabel);
            this.Controls.Add(this.allBRfarbe);
            this.Controls.Add(this.allTURfarbe);
            this.Controls.Add(this.allRUSfarbe);
            this.Controls.Add(this.allLASfarbe);
            this.Controls.Add(this.allLANfarbe);
            this.Controls.Add(this.allOCEfarbe);
            this.Controls.Add(this.allNAfarbe);
            this.Controls.Add(this.allEUNEfarbe);
            this.Controls.Add(this.allEUWfarbe);
            this.Controls.Add(this.allBR);
            this.Controls.Add(this.allTUR);
            this.Controls.Add(this.allRUS);
            this.Controls.Add(this.allLAS);
            this.Controls.Add(this.allLAN);
            this.Controls.Add(this.allOCE);
            this.Controls.Add(this.allNA);
            this.Controls.Add(this.allEUNE);
            this.Controls.Add(this.allEUW);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(321, 260);
            this.Name = "LoLPingCheckShowAll";
            this.Text = "LoL Ping Check - all regions";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.LoLPingCheckShowAll_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox allEUW;
        private System.Windows.Forms.CheckBox allEUNE;
        private System.Windows.Forms.CheckBox allNA;
        private System.Windows.Forms.CheckBox allOCE;
        private System.Windows.Forms.CheckBox allLAN;
        private System.Windows.Forms.CheckBox allLAS;
        private System.Windows.Forms.CheckBox allRUS;
        private System.Windows.Forms.CheckBox allTUR;
        private System.Windows.Forms.Panel allEUWfarbe;
        private System.Windows.Forms.Panel allEUNEfarbe;
        private System.Windows.Forms.Panel allNAfarbe;
        private System.Windows.Forms.Panel allOCEfarbe;
        private System.Windows.Forms.Panel allLANfarbe;
        private System.Windows.Forms.Panel allLASfarbe;
        private System.Windows.Forms.Panel allRUSfarbe;
        private System.Windows.Forms.Panel allTURfarbe;
        private System.Windows.Forms.Label allEUWlabel;
        private System.Windows.Forms.Label allEUNElabel;
        private System.Windows.Forms.Label allNAlabel;
        private System.Windows.Forms.Label allOCElabel;
        private System.Windows.Forms.Label allLANlabel;
        private System.Windows.Forms.Label allLASlabel;
        private System.Windows.Forms.Label allRUSlabel;
        private System.Windows.Forms.Label allTURlabel;
        private System.ComponentModel.BackgroundWorker bgwOCE;
        private System.ComponentModel.BackgroundWorker bgwEUW;
        private System.ComponentModel.BackgroundWorker bgwEUNE;
        private System.ComponentModel.BackgroundWorker bgwNA;
        private System.ComponentModel.BackgroundWorker bgwLAN;
        private System.Windows.Forms.Button InfoBtnAllRegions;
        private System.ComponentModel.BackgroundWorker bgwLAS;
        private System.ComponentModel.BackgroundWorker bgwBR;
        private System.Windows.Forms.CheckBox allBR;
        private System.Windows.Forms.Label allBRlabel;
        private System.Windows.Forms.Panel allBRfarbe;
        private System.ComponentModel.BackgroundWorker bgwRUS;
        private System.ComponentModel.BackgroundWorker bgwTUR;
    }
}