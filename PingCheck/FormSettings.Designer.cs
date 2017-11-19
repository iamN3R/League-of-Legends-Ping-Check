namespace PingCheck
{
    partial class FormSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSettings));
            this.cbWinStart = new System.Windows.Forms.CheckBox();
            this.cbColorshow = new System.Windows.Forms.CheckBox();
            this.cbGeneraltest = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.StandardRegion = new System.Windows.Forms.Label();
            this.winStatlabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbWinStart
            // 
            this.cbWinStart.AutoSize = true;
            this.cbWinStart.Location = new System.Drawing.Point(15, 23);
            this.cbWinStart.Name = "cbWinStart";
            this.cbWinStart.Size = new System.Drawing.Size(115, 17);
            this.cbWinStart.TabIndex = 0;
            this.cbWinStart.Text = "start with Windows";
            this.cbWinStart.UseVisualStyleBackColor = true;
            this.cbWinStart.CheckedChanged += new System.EventHandler(this.cbWinStart_CheckedChanged);
            // 
            // cbColorshow
            // 
            this.cbColorshow.AutoSize = true;
            this.cbColorshow.Checked = true;
            this.cbColorshow.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbColorshow.Location = new System.Drawing.Point(15, 65);
            this.cbColorshow.Name = "cbColorshow";
            this.cbColorshow.Size = new System.Drawing.Size(132, 17);
            this.cbColorshow.TabIndex = 1;
            this.cbColorshow.Text = "show colored indicator";
            this.cbColorshow.UseVisualStyleBackColor = true;
            this.cbColorshow.CheckedChanged += new System.EventHandler(this.cbColorshow_CheckedChanged);
            // 
            // cbGeneraltest
            // 
            this.cbGeneraltest.AutoSize = true;
            this.cbGeneraltest.Checked = true;
            this.cbGeneraltest.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbGeneraltest.Location = new System.Drawing.Point(15, 107);
            this.cbGeneraltest.Name = "cbGeneraltest";
            this.cbGeneraltest.Size = new System.Drawing.Size(112, 17);
            this.cbGeneraltest.TabIndex = 2;
            this.cbGeneraltest.Text = "show gerneral test";
            this.cbGeneraltest.UseVisualStyleBackColor = true;
            this.cbGeneraltest.CheckedChanged += new System.EventHandler(this.cbGeneraltest_CheckedChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.Window;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "EUW",
            "EUNE",
            "NA",
            "OCE",
            "LAN",
            "NOT AVAILABLE YET",
            "LAS",
            "BR",
            "RUS",
            "TUR"});
            this.comboBox1.Location = new System.Drawing.Point(115, 146);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(132, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // StandardRegion
            // 
            this.StandardRegion.AutoSize = true;
            this.StandardRegion.Location = new System.Drawing.Point(12, 149);
            this.StandardRegion.Name = "StandardRegion";
            this.StandardRegion.Size = new System.Drawing.Size(87, 13);
            this.StandardRegion.TabIndex = 4;
            this.StandardRegion.Text = "Standard Region";
            // 
            // winStatlabel
            // 
            this.winStatlabel.AutoSize = true;
            this.winStatlabel.Location = new System.Drawing.Point(212, 24);
            this.winStatlabel.Name = "winStatlabel";
            this.winStatlabel.Size = new System.Drawing.Size(37, 13);
            this.winStatlabel.TabIndex = 5;
            this.winStatlabel.Text = "          ";
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 199);
            this.Controls.Add(this.winStatlabel);
            this.Controls.Add(this.StandardRegion);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.cbGeneraltest);
            this.Controls.Add(this.cbColorshow);
            this.Controls.Add(this.cbWinStart);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(288, 238);
            this.MinimumSize = new System.Drawing.Size(288, 238);
            this.Name = "FormSettings";
            this.Text = "LoL Ping Check - Settings";
            this.Load += new System.EventHandler(this.FormSettings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbWinStart;
        private System.Windows.Forms.CheckBox cbColorshow;
        private System.Windows.Forms.CheckBox cbGeneraltest;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label StandardRegion;
        private System.Windows.Forms.Label winStatlabel;
    }
}