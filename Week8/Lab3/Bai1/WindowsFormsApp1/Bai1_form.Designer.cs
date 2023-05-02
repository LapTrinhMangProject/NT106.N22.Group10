namespace Bai1
{
    partial class Bai1_form
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
            this.udpserver = new System.Windows.Forms.Button();
            this.udpclient = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // udpserver
            // 
            this.udpserver.Location = new System.Drawing.Point(70, 128);
            this.udpserver.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.udpserver.Name = "udpserver";
            this.udpserver.Size = new System.Drawing.Size(142, 75);
            this.udpserver.TabIndex = 0;
            this.udpserver.Text = "UDP Server";
            this.udpserver.UseVisualStyleBackColor = true;
            this.udpserver.Click += new System.EventHandler(this.udpserver_Click);
            // 
            // udpclient
            // 
            this.udpclient.Location = new System.Drawing.Point(354, 128);
            this.udpclient.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.udpclient.Name = "udpclient";
            this.udpclient.Size = new System.Drawing.Size(142, 75);
            this.udpclient.TabIndex = 1;
            this.udpclient.Text = "UDP Client";
            this.udpclient.UseVisualStyleBackColor = true;
            this.udpclient.Click += new System.EventHandler(this.udpclient_Click);
            // 
            // Bai1_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.udpclient);
            this.Controls.Add(this.udpserver);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Bai1_form";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Bai1_form_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button udpserver;
        private System.Windows.Forms.Button udpclient;
    }
}

