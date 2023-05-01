namespace WindowsFormsApp1
{
    partial class Form1
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
            this.udpserver.Location = new System.Drawing.Point(93, 157);
            this.udpserver.Name = "udpserver";
            this.udpserver.Size = new System.Drawing.Size(189, 92);
            this.udpserver.TabIndex = 0;
            this.udpserver.Text = "UDP Server";
            this.udpserver.UseVisualStyleBackColor = true;
            this.udpserver.Click += new System.EventHandler(this.udpserver_Click);
            // 
            // udpclient
            // 
            this.udpclient.Location = new System.Drawing.Point(472, 157);
            this.udpclient.Name = "udpclient";
            this.udpclient.Size = new System.Drawing.Size(189, 92);
            this.udpclient.TabIndex = 1;
            this.udpclient.Text = "UDP Client";
            this.udpclient.UseVisualStyleBackColor = true;
            this.udpclient.Click += new System.EventHandler(this.udpclient_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.udpclient);
            this.Controls.Add(this.udpserver);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button udpserver;
        private System.Windows.Forms.Button udpclient;
    }
}

