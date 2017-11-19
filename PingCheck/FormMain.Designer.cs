namespace PingCheck
{
    partial class FormMain
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ausgabe = new System.Windows.Forms.TextBox();
            this.RegionBox = new System.Windows.Forms.ComboBox();
            this.GoogleTest = new System.Windows.Forms.Button();
            this.InternetTest = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.allShowbutton = new System.Windows.Forms.Button();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.HelpButton = new System.Windows.Forms.Button();
            this.AboutButton = new System.Windows.Forms.Button();
            this.InfobtnMain = new System.Windows.Forms.Button();
            this.clearbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 53);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 21);
            this.button1.TabIndex = 0;
            this.button1.Text = "start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(488, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ping Checker";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ausgabe
            // 
            this.ausgabe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ausgabe.Location = new System.Drawing.Point(15, 83);
            this.ausgabe.Multiline = true;
            this.ausgabe.Name = "ausgabe";
            this.ausgabe.ReadOnly = true;
            this.ausgabe.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ausgabe.Size = new System.Drawing.Size(344, 186);
            this.ausgabe.TabIndex = 2;
            // 
            // RegionBox
            // 
            this.RegionBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RegionBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RegionBox.FormattingEnabled = true;
            this.RegionBox.Items.AddRange(new object[] {
            "EUW",
            "EUNE",
            "NA",
            "OCE",
            "LAN",
            "LAS",
            "RUS",
            "TUR",
            "BR"});
            this.RegionBox.Location = new System.Drawing.Point(238, 55);
            this.RegionBox.Name = "RegionBox";
            this.RegionBox.Size = new System.Drawing.Size(121, 21);
            this.RegionBox.TabIndex = 4;
            this.RegionBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // GoogleTest
            // 
            this.GoogleTest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.GoogleTest.Location = new System.Drawing.Point(12, 275);
            this.GoogleTest.Name = "GoogleTest";
            this.GoogleTest.Size = new System.Drawing.Size(75, 23);
            this.GoogleTest.TabIndex = 5;
            this.GoogleTest.Text = "general test";
            this.GoogleTest.UseVisualStyleBackColor = true;
            this.GoogleTest.Click += new System.EventHandler(this.GoogleTest_Click);
            // 
            // InternetTest
            // 
            this.InternetTest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.InternetTest.AutoSize = true;
            this.InternetTest.Location = new System.Drawing.Point(104, 279);
            this.InternetTest.Name = "InternetTest";
            this.InternetTest.Size = new System.Drawing.Size(48, 13);
            this.InternetTest.TabIndex = 6;
            this.InternetTest.Text = "untested";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(186, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(27, 22);
            this.panel1.TabIndex = 7;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // allShowbutton
            // 
            this.allShowbutton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.allShowbutton.Location = new System.Drawing.Point(376, 55);
            this.allShowbutton.Name = "allShowbutton";
            this.allShowbutton.Size = new System.Drawing.Size(115, 21);
            this.allShowbutton.TabIndex = 8;
            this.allShowbutton.Text = "show all Regions";
            this.allShowbutton.UseVisualStyleBackColor = true;
            this.allShowbutton.Click += new System.EventHandler(this.allShowbutton_Click);
            // 
            // SettingsButton
            // 
            this.SettingsButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.SettingsButton.Location = new System.Drawing.Point(375, 106);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(115, 21);
            this.SettingsButton.TabIndex = 9;
            this.SettingsButton.Text = "Settings";
            this.SettingsButton.UseVisualStyleBackColor = true;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // HelpButton
            // 
            this.HelpButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.HelpButton.Location = new System.Drawing.Point(375, 145);
            this.HelpButton.Name = "HelpButton";
            this.HelpButton.Size = new System.Drawing.Size(115, 21);
            this.HelpButton.TabIndex = 10;
            this.HelpButton.Text = "Help";
            this.HelpButton.UseVisualStyleBackColor = true;
            this.HelpButton.Click += new System.EventHandler(this.HelpButton_Click);
            // 
            // AboutButton
            // 
            this.AboutButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.AboutButton.Location = new System.Drawing.Point(375, 184);
            this.AboutButton.Name = "AboutButton";
            this.AboutButton.Size = new System.Drawing.Size(115, 21);
            this.AboutButton.TabIndex = 11;
            this.AboutButton.Text = "About";
            this.AboutButton.UseVisualStyleBackColor = true;
            this.AboutButton.Click += new System.EventHandler(this.AboutButton_Click);
            // 
            // InfobtnMain
            // 
            this.InfobtnMain.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.InfobtnMain.Location = new System.Drawing.Point(376, 223);
            this.InfobtnMain.Name = "InfobtnMain";
            this.InfobtnMain.Size = new System.Drawing.Size(114, 23);
            this.InfobtnMain.TabIndex = 12;
            this.InfobtnMain.Text = "Region Information";
            this.InfobtnMain.UseVisualStyleBackColor = true;
            this.InfobtnMain.Click += new System.EventHandler(this.InfobtnMain_Click);
            // 
            // clearbutton
            // 
            this.clearbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.clearbutton.Location = new System.Drawing.Point(284, 275);
            this.clearbutton.Name = "clearbutton";
            this.clearbutton.Size = new System.Drawing.Size(75, 23);
            this.clearbutton.TabIndex = 13;
            this.clearbutton.Text = "clear";
            this.clearbutton.UseVisualStyleBackColor = true;
            this.clearbutton.Click += new System.EventHandler(this.clearbutton_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 347);
            this.Controls.Add(this.clearbutton);
            this.Controls.Add(this.InfobtnMain);
            this.Controls.Add(this.AboutButton);
            this.Controls.Add(this.HelpButton);
            this.Controls.Add(this.SettingsButton);
            this.Controls.Add(this.allShowbutton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.InternetTest);
            this.Controls.Add(this.GoogleTest);
            this.Controls.Add(this.RegionBox);
            this.Controls.Add(this.ausgabe);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(528, 700);
            this.MinimumSize = new System.Drawing.Size(528, 386);
            this.Name = "FormMain";
            this.Text = "LoL Ping Check";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ausgabe;
        private System.Windows.Forms.ComboBox RegionBox;
        private System.Windows.Forms.Button GoogleTest;
        private System.Windows.Forms.Label InternetTest;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button allShowbutton;
        private System.Windows.Forms.Button SettingsButton;
        private System.Windows.Forms.Button HelpButton;
        private System.Windows.Forms.Button AboutButton;
        private System.Windows.Forms.Button InfobtnMain;
        private System.Windows.Forms.Button clearbutton;
    }
}

