namespace Client
{
    partial class Client_form
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
            this.components = new System.ComponentModel.Container();
            this.port_textbox = new System.Windows.Forms.TextBox();
            this.IP_textbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.connect_buton = new System.Windows.Forms.Button();
            this.chat_listbox = new System.Windows.Forms.ListBox();
            this.send_textbox = new System.Windows.Forms.TextBox();
            this.send_button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.hostname_textbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // port_textbox
            // 
            this.port_textbox.Location = new System.Drawing.Point(512, 14);
            this.port_textbox.Margin = new System.Windows.Forms.Padding(2);
            this.port_textbox.Name = "port_textbox";
            this.port_textbox.ReadOnly = true;
            this.port_textbox.Size = new System.Drawing.Size(30, 20);
            this.port_textbox.TabIndex = 0;
            this.port_textbox.Text = "8080";
            // 
            // IP_textbox
            // 
            this.IP_textbox.Location = new System.Drawing.Point(506, 37);
            this.IP_textbox.Margin = new System.Windows.Forms.Padding(2);
            this.IP_textbox.Name = "IP_textbox";
            this.IP_textbox.Size = new System.Drawing.Size(86, 20);
            this.IP_textbox.TabIndex = 1;
            this.IP_textbox.Text = "192.168.1.9";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(450, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Server port:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(458, 37);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Server";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // connect_buton
            // 
            this.connect_buton.Location = new System.Drawing.Point(452, 59);
            this.connect_buton.Margin = new System.Windows.Forms.Padding(2);
            this.connect_buton.Name = "connect_buton";
            this.connect_buton.Size = new System.Drawing.Size(141, 19);
            this.connect_buton.TabIndex = 4;
            this.connect_buton.Text = "Connect";
            this.connect_buton.UseVisualStyleBackColor = true;
            this.connect_buton.Click += new System.EventHandler(this.connect_buton_Click);
            // 
            // chat_listbox
            // 
            this.chat_listbox.FormattingEnabled = true;
            this.chat_listbox.Location = new System.Drawing.Point(9, 14);
            this.chat_listbox.Margin = new System.Windows.Forms.Padding(2);
            this.chat_listbox.Name = "chat_listbox";
            this.chat_listbox.Size = new System.Drawing.Size(438, 160);
            this.chat_listbox.TabIndex = 5;
            // 
            // send_textbox
            // 
            this.send_textbox.Location = new System.Drawing.Point(58, 187);
            this.send_textbox.Margin = new System.Windows.Forms.Padding(2);
            this.send_textbox.Name = "send_textbox";
            this.send_textbox.Size = new System.Drawing.Size(335, 20);
            this.send_textbox.TabIndex = 6;
            // 
            // send_button
            // 
            this.send_button.Location = new System.Drawing.Point(396, 187);
            this.send_button.Margin = new System.Windows.Forms.Padding(2);
            this.send_button.Name = "send_button";
            this.send_button.Size = new System.Drawing.Size(56, 34);
            this.send_button.TabIndex = 7;
            this.send_button.Text = "Send";
            this.send_button.UseVisualStyleBackColor = true;
            this.send_button.Click += new System.EventHandler(this.send_button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 187);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Text";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(455, 190);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "HostName";
            // 
            // hostname_textbox
            // 
            this.hostname_textbox.Location = new System.Drawing.Point(516, 187);
            this.hostname_textbox.Margin = new System.Windows.Forms.Padding(2);
            this.hostname_textbox.Name = "hostname_textbox";
            this.hostname_textbox.Size = new System.Drawing.Size(76, 20);
            this.hostname_textbox.TabIndex = 14;
            // 
            // Client_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 232);
            this.Controls.Add(this.hostname_textbox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.send_button);
            this.Controls.Add(this.send_textbox);
            this.Controls.Add(this.chat_listbox);
            this.Controls.Add(this.connect_buton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IP_textbox);
            this.Controls.Add(this.port_textbox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Client_form";
            this.Text = "Client";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox port_textbox;
        private System.Windows.Forms.TextBox IP_textbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button connect_buton;
        private System.Windows.Forms.ListBox chat_listbox;
        private System.Windows.Forms.TextBox send_textbox;
        private System.Windows.Forms.Button send_button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox hostname_textbox;
    }
}

