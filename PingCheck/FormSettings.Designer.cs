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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbWinStart
            // 
            this.cbWinStart.AutoSize = true;
            this.cbWinStart.Location = new System.Drawing.Point(12, 31);
            this.cbWinStart.Name = "cbWinStart";
            this.cbWinStart.Size = new System.Drawing.Size(115, 17);
            this.cbWinStart.TabIndex = 0;
            this.cbWinStart.Text = "start with Windows";
            this.cbWinStart.UseVisualStyleBackColor = true;
            // 
            // cbColorshow
            // 
            this.cbColorshow.AutoSize = true;
            this.cbColorshow.Location = new System.Drawing.Point(12, 73);
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
            this.cbGeneraltest.Location = new System.Drawing.Point(12, 115);
            this.cbGeneraltest.Name = "cbGeneraltest";
            this.cbGeneraltest.Size = new System.Drawing.Size(112, 17);
            this.cbGeneraltest.TabIndex = 2;
            this.cbGeneraltest.Text = "show gerneral test";
            this.cbGeneraltest.UseVisualStyleBackColor = true;
            this.cbGeneraltest.CheckedChanged += new System.EventHandler(this.cbGeneraltest_CheckedChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "EUW",
            "EUNE",
            "NA",
            "OCE",
            "LAN",
            "JPN",
            "NOT AVAILABLE YET",
            "LAS",
            "KR",
            "BR",
            "RUS",
            "TUR"});
            this.comboBox1.Location = new System.Drawing.Point(102, 154);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(132, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // StandardRegion
            // 
            this.StandardRegion.AutoSize = true;
            this.StandardRegion.Location = new System.Drawing.Point(9, 157);
            this.StandardRegion.Name = "StandardRegion";
            this.StandardRegion.Size = new System.Drawing.Size(87, 13);
            this.StandardRegion.TabIndex = 4;
            this.StandardRegion.Text = "Standard Region";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(165, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "NOT AVAILABLE YET";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(165, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "NOT AVAILABLE YET";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(165, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "NOT AVAILABLE YET";
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 347);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StandardRegion);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.cbGeneraltest);
            this.Controls.Add(this.cbColorshow);
            this.Controls.Add(this.cbWinStart);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormSettings";
            this.Text = "LoL Ping Check - Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbWinStart;
        private System.Windows.Forms.CheckBox cbColorshow;
        private System.Windows.Forms.CheckBox cbGeneraltest;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label StandardRegion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}