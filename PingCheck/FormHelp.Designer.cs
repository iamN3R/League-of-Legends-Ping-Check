namespace PingCheck
{
    partial class FormHelp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHelp));
            this.contactbutton = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.socialmedia = new System.Windows.Forms.Label();
            this.smYoutube = new System.Windows.Forms.LinkLabel();
            this.smReddit = new System.Windows.Forms.LinkLabel();
            this.smInstagram = new System.Windows.Forms.LinkLabel();
            this.smWebside = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // contactbutton
            // 
            this.contactbutton.Location = new System.Drawing.Point(12, 12);
            this.contactbutton.Name = "contactbutton";
            this.contactbutton.Size = new System.Drawing.Size(117, 49);
            this.contactbutton.TabIndex = 0;
            this.contactbutton.Text = "contact";
            this.contactbutton.UseVisualStyleBackColor = true;
            this.contactbutton.Click += new System.EventHandler(this.contactbutton_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.richTextBox1.Location = new System.Drawing.Point(12, 67);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(488, 118);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // socialmedia
            // 
            this.socialmedia.AutoSize = true;
            this.socialmedia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.socialmedia.Location = new System.Drawing.Point(12, 197);
            this.socialmedia.Name = "socialmedia";
            this.socialmedia.Size = new System.Drawing.Size(96, 20);
            this.socialmedia.TabIndex = 2;
            this.socialmedia.Text = "social media";
            // 
            // smYoutube
            // 
            this.smYoutube.AutoSize = true;
            this.smYoutube.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.smYoutube.LinkColor = System.Drawing.Color.Black;
            this.smYoutube.Location = new System.Drawing.Point(16, 221);
            this.smYoutube.Name = "smYoutube";
            this.smYoutube.Size = new System.Drawing.Size(47, 13);
            this.smYoutube.TabIndex = 3;
            this.smYoutube.TabStop = true;
            this.smYoutube.Text = "Youtube";
            this.smYoutube.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.smYoutube_LinkClicked);
            // 
            // smReddit
            // 
            this.smReddit.AutoSize = true;
            this.smReddit.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.smReddit.LinkColor = System.Drawing.Color.Black;
            this.smReddit.Location = new System.Drawing.Point(16, 243);
            this.smReddit.Name = "smReddit";
            this.smReddit.Size = new System.Drawing.Size(38, 13);
            this.smReddit.TabIndex = 4;
            this.smReddit.TabStop = true;
            this.smReddit.Text = "Reddit";
            this.smReddit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.smReddit_LinkClicked);
            // 
            // smInstagram
            // 
            this.smInstagram.AutoSize = true;
            this.smInstagram.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.smInstagram.LinkColor = System.Drawing.Color.Black;
            this.smInstagram.Location = new System.Drawing.Point(16, 265);
            this.smInstagram.Name = "smInstagram";
            this.smInstagram.Size = new System.Drawing.Size(53, 13);
            this.smInstagram.TabIndex = 5;
            this.smInstagram.TabStop = true;
            this.smInstagram.Text = "Instagram";
            this.smInstagram.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.smInstagram_LinkClicked);
            // 
            // smWebside
            // 
            this.smWebside.AutoSize = true;
            this.smWebside.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.smWebside.LinkColor = System.Drawing.Color.Black;
            this.smWebside.Location = new System.Drawing.Point(16, 290);
            this.smWebside.Name = "smWebside";
            this.smWebside.Size = new System.Drawing.Size(135, 13);
            this.smWebside.TabIndex = 6;
            this.smWebside.TabStop = true;
            this.smWebside.Text = "my Webside (it\'s in german)";
            this.smWebside.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.smWebside_LinkClicked);
            // 
            // FormHelp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 347);
            this.Controls.Add(this.smWebside);
            this.Controls.Add(this.smInstagram);
            this.Controls.Add(this.smReddit);
            this.Controls.Add(this.smYoutube);
            this.Controls.Add(this.socialmedia);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.contactbutton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(528, 386);
            this.MinimumSize = new System.Drawing.Size(528, 386);
            this.Name = "FormHelp";
            this.Text = "LoL Ping Check - Help";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button contactbutton;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label socialmedia;
        private System.Windows.Forms.LinkLabel smYoutube;
        private System.Windows.Forms.LinkLabel smReddit;
        private System.Windows.Forms.LinkLabel smInstagram;
        private System.Windows.Forms.LinkLabel smWebside;
    }
}