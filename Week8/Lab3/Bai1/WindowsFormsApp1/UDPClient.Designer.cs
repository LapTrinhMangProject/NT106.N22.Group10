namespace Bai1
{
    partial class UDPClient
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
            this.display = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.IPremote = new System.Windows.Forms.TextBox();
            this.Port = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // display
            // 
            this.display.Location = new System.Drawing.Point(9, 89);
            this.display.Margin = new System.Windows.Forms.Padding(2);
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(582, 138);
            this.display.TabIndex = 1;
            this.display.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 238);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 28);
            this.button1.TabIndex = 2;
            this.button1.Text = "Send";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // IPremote
            // 
            this.IPremote.Location = new System.Drawing.Point(9, 57);
            this.IPremote.Margin = new System.Windows.Forms.Padding(2);
            this.IPremote.Name = "IPremote";
            this.IPremote.Size = new System.Drawing.Size(371, 20);
            this.IPremote.TabIndex = 3;
            this.IPremote.Text = "127.0.0.1";
            // 
            // Port
            // 
            this.Port.Location = new System.Drawing.Point(481, 57);
            this.Port.Margin = new System.Windows.Forms.Padding(2);
            this.Port.Name = "Port";
            this.Port.Size = new System.Drawing.Size(110, 20);
            this.Port.TabIndex = 4;
            this.Port.Text = "8050";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "IP Remote host";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(478, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Port";
            // 
            // UDPClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 288);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Port);
            this.Controls.Add(this.IPremote);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.display);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UDPClient";
            this.Text = "UDPClient";
            this.Load += new System.EventHandler(this.UDPClient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox display;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox IPremote;
        private System.Windows.Forms.TextBox Port;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}