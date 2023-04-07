
namespace Client
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
            this.clientIP_tb = new System.Windows.Forms.TextBox();
            this.clientPort_tb = new System.Windows.Forms.TextBox();
            this.serverIP_tb = new System.Windows.Forms.TextBox();
            this.serverPort_tb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chat_lb = new System.Windows.Forms.ListBox();
            this.chat_tb = new System.Windows.Forms.TextBox();
            this.send_bt = new System.Windows.Forms.Button();
            this.connect_bt = new System.Windows.Forms.Button();
            this.hostname_tb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // clientIP_tb
            // 
            this.clientIP_tb.Location = new System.Drawing.Point(134, 26);
            this.clientIP_tb.Name = "clientIP_tb";
            this.clientIP_tb.Size = new System.Drawing.Size(227, 22);
            this.clientIP_tb.TabIndex = 0;
            this.clientIP_tb.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // clientPort_tb
            // 
            this.clientPort_tb.Location = new System.Drawing.Point(455, 26);
            this.clientPort_tb.Name = "clientPort_tb";
            this.clientPort_tb.Size = new System.Drawing.Size(72, 22);
            this.clientPort_tb.TabIndex = 1;
            this.clientPort_tb.TextChanged += new System.EventHandler(this.clientPort_tb_TextChanged);
            // 
            // serverIP_tb
            // 
            this.serverIP_tb.Location = new System.Drawing.Point(134, 94);
            this.serverIP_tb.Name = "serverIP_tb";
            this.serverIP_tb.Size = new System.Drawing.Size(227, 22);
            this.serverIP_tb.TabIndex = 2;
            this.serverIP_tb.TextChanged += new System.EventHandler(this.serverIP_tb_TextChanged);
            // 
            // serverPort_tb
            // 
            this.serverPort_tb.Location = new System.Drawing.Point(455, 99);
            this.serverPort_tb.Name = "serverPort_tb";
            this.serverPort_tb.Size = new System.Drawing.Size(72, 22);
            this.serverPort_tb.TabIndex = 3;
            this.serverPort_tb.TextChanged += new System.EventHandler(this.serverPort_tb_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Client IP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(377, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Client port";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Server IP";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(370, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Server port";
            // 
            // chat_lb
            // 
            this.chat_lb.FormattingEnabled = true;
            this.chat_lb.ItemHeight = 16;
            this.chat_lb.Location = new System.Drawing.Point(56, 166);
            this.chat_lb.Name = "chat_lb";
            this.chat_lb.Size = new System.Drawing.Size(471, 212);
            this.chat_lb.TabIndex = 8;
            // 
            // chat_tb
            // 
            this.chat_tb.Location = new System.Drawing.Point(56, 395);
            this.chat_tb.Name = "chat_tb";
            this.chat_tb.Size = new System.Drawing.Size(471, 22);
            this.chat_tb.TabIndex = 9;
            // 
            // send_bt
            // 
            this.send_bt.Location = new System.Drawing.Point(555, 394);
            this.send_bt.Name = "send_bt";
            this.send_bt.Size = new System.Drawing.Size(75, 23);
            this.send_bt.TabIndex = 10;
            this.send_bt.Text = "SEND";
            this.send_bt.UseVisualStyleBackColor = true;
            this.send_bt.Click += new System.EventHandler(this.send_bt_Click);
            // 
            // connect_bt
            // 
            this.connect_bt.Location = new System.Drawing.Point(555, 355);
            this.connect_bt.Name = "connect_bt";
            this.connect_bt.Size = new System.Drawing.Size(75, 23);
            this.connect_bt.TabIndex = 11;
            this.connect_bt.Text = "Connect";
            this.connect_bt.UseVisualStyleBackColor = true;
            this.connect_bt.Click += new System.EventHandler(this.connect_bt_Click);
            // 
            // hostname_tb
            // 
            this.hostname_tb.Location = new System.Drawing.Point(134, 55);
            this.hostname_tb.Name = "hostname_tb";
            this.hostname_tb.Size = new System.Drawing.Size(143, 22);
            this.hostname_tb.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Hostname";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 441);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.hostname_tb);
            this.Controls.Add(this.connect_bt);
            this.Controls.Add(this.send_bt);
            this.Controls.Add(this.chat_tb);
            this.Controls.Add(this.chat_lb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.serverPort_tb);
            this.Controls.Add(this.serverIP_tb);
            this.Controls.Add(this.clientPort_tb);
            this.Controls.Add(this.clientIP_tb);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox clientIP_tb;
        private System.Windows.Forms.TextBox clientPort_tb;
        private System.Windows.Forms.TextBox serverIP_tb;
        private System.Windows.Forms.TextBox serverPort_tb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox chat_lb;
        private System.Windows.Forms.TextBox chat_tb;
        private System.Windows.Forms.Button send_bt;
        private System.Windows.Forms.Button connect_bt;
        private System.Windows.Forms.TextBox hostname_tb;
        private System.Windows.Forms.Label label5;
    }
}

