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
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ausgabe
            // 
            resources.ApplyResources(this.ausgabe, "ausgabe");
            this.ausgabe.Name = "ausgabe";
            this.ausgabe.ReadOnly = true;
            // 
            // RegionBox
            // 
            resources.ApplyResources(this.RegionBox, "RegionBox");
            this.RegionBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RegionBox.FormattingEnabled = true;
            this.RegionBox.Items.AddRange(new object[] {
            resources.GetString("RegionBox.Items"),
            resources.GetString("RegionBox.Items1"),
            resources.GetString("RegionBox.Items2"),
            resources.GetString("RegionBox.Items3"),
            resources.GetString("RegionBox.Items4"),
            resources.GetString("RegionBox.Items5"),
            resources.GetString("RegionBox.Items6"),
            resources.GetString("RegionBox.Items7"),
            resources.GetString("RegionBox.Items8")});
            this.RegionBox.Name = "RegionBox";
            this.RegionBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // GoogleTest
            // 
            resources.ApplyResources(this.GoogleTest, "GoogleTest");
            this.GoogleTest.Name = "GoogleTest";
            this.GoogleTest.UseVisualStyleBackColor = true;
            this.GoogleTest.Click += new System.EventHandler(this.GoogleTest_Click);
            // 
            // InternetTest
            // 
            resources.ApplyResources(this.InternetTest, "InternetTest");
            this.InternetTest.Name = "InternetTest";
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // allShowbutton
            // 
            resources.ApplyResources(this.allShowbutton, "allShowbutton");
            this.allShowbutton.Name = "allShowbutton";
            this.allShowbutton.UseVisualStyleBackColor = true;
            this.allShowbutton.Click += new System.EventHandler(this.allShowbutton_Click);
            // 
            // SettingsButton
            // 
            resources.ApplyResources(this.SettingsButton, "SettingsButton");
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.UseVisualStyleBackColor = true;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // HelpButton
            // 
            resources.ApplyResources(this.HelpButton, "HelpButton");
            this.HelpButton.Name = "HelpButton";
            this.HelpButton.UseVisualStyleBackColor = true;
            this.HelpButton.Click += new System.EventHandler(this.HelpButton_Click);
            // 
            // AboutButton
            // 
            resources.ApplyResources(this.AboutButton, "AboutButton");
            this.AboutButton.Name = "AboutButton";
            this.AboutButton.UseVisualStyleBackColor = true;
            this.AboutButton.Click += new System.EventHandler(this.AboutButton_Click);
            // 
            // InfobtnMain
            // 
            resources.ApplyResources(this.InfobtnMain, "InfobtnMain");
            this.InfobtnMain.Name = "InfobtnMain";
            this.InfobtnMain.UseVisualStyleBackColor = true;
            this.InfobtnMain.Click += new System.EventHandler(this.InfobtnMain_Click);
            // 
            // clearbutton
            // 
            resources.ApplyResources(this.clearbutton, "clearbutton");
            this.clearbutton.Name = "clearbutton";
            this.clearbutton.UseVisualStyleBackColor = true;
            this.clearbutton.Click += new System.EventHandler(this.clearbutton_Click);
            // 
            // FormMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
            this.Name = "FormMain";
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

