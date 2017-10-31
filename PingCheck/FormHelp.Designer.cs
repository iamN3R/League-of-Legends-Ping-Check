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
            this.contactbutton = new System.Windows.Forms.Button();
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
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 347);
            this.Controls.Add(this.contactbutton);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button contactbutton;
    }
}