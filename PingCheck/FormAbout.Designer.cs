namespace PingCheck
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.labelVersion = new System.Windows.Forms.Label();
            this.labelFrameWork = new System.Windows.Forms.Label();
            this.labelReleaseDate = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.CC_NS = new System.Windows.Forms.RichTextBox();
            this.Versiontext = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelVersion
            // 
            this.labelVersion.AutoSize = true;
            this.labelVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVersion.Location = new System.Drawing.Point(26, 32);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(63, 20);
            this.labelVersion.TabIndex = 0;
            this.labelVersion.Text = "Version";
            // 
            // labelFrameWork
            // 
            this.labelFrameWork.AutoSize = true;
            this.labelFrameWork.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFrameWork.Location = new System.Drawing.Point(26, 74);
            this.labelFrameWork.Name = "labelFrameWork";
            this.labelFrameWork.Size = new System.Drawing.Size(185, 20);
            this.labelFrameWork.TabIndex = 0;
            this.labelFrameWork.Text = ".NET Framework Version";
            // 
            // labelReleaseDate
            // 
            this.labelReleaseDate.AutoSize = true;
            this.labelReleaseDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReleaseDate.Location = new System.Drawing.Point(26, 116);
            this.labelReleaseDate.Name = "labelReleaseDate";
            this.labelReleaseDate.Size = new System.Drawing.Size(257, 20);
            this.labelReleaseDate.TabIndex = 0;
            this.labelReleaseDate.Text = "Release date of the current version";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(30, 154);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(470, 55);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "check out all the versions";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // CC_NS
            // 
            this.CC_NS.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CC_NS.Location = new System.Drawing.Point(30, 235);
            this.CC_NS.Name = "CC_NS";
            this.CC_NS.ReadOnly = true;
            this.CC_NS.Size = new System.Drawing.Size(470, 62);
            this.CC_NS.TabIndex = 2;
            this.CC_NS.Text = resources.GetString("CC_NS.Text");
            // 
            // Versiontext
            // 
            this.Versiontext.AutoSize = true;
            this.Versiontext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Versiontext.Location = new System.Drawing.Point(315, 32);
            this.Versiontext.Name = "Versiontext";
            this.Versiontext.Size = new System.Drawing.Size(44, 20);
            this.Versiontext.TabIndex = 0;
            this.Versiontext.Text = "1.0.2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(315, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "4.6.1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(315, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "19th november 2017";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(412, 303);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(88, 32);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 347);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CC_NS);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelReleaseDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelFrameWork);
            this.Controls.Add(this.Versiontext);
            this.Controls.Add(this.labelVersion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(528, 386);
            this.MinimumSize = new System.Drawing.Size(528, 386);
            this.Name = "FormAbout";
            this.Text = "LoL Ping Check - About";
            this.Load += new System.EventHandler(this.FormAbout_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.Label labelFrameWork;
        private System.Windows.Forms.Label labelReleaseDate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.RichTextBox CC_NS;
        private System.Windows.Forms.Label Versiontext;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}