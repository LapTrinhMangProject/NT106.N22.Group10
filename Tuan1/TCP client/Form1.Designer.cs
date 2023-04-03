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
            this.label4 = new System.Windows.Forms.Label();
            this.Ipclient_textbox = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SuspendLayout();
            // 
            // port_textbox
            // 
            this.port_textbox.Location = new System.Drawing.Point(682, 17);
            this.port_textbox.Name = "port_textbox";
            this.port_textbox.ReadOnly = true;
            this.port_textbox.Size = new System.Drawing.Size(39, 22);
            this.port_textbox.TabIndex = 0;
            this.port_textbox.Text = "8080";
            // 
            // IP_textbox
            // 
            this.IP_textbox.Location = new System.Drawing.Point(663, 62);
            this.IP_textbox.Name = "IP_textbox";
            this.IP_textbox.Size = new System.Drawing.Size(113, 22);
            this.IP_textbox.TabIndex = 1;
            this.IP_textbox.Text = "192.168.93.1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(600, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Server port:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(610, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Server";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // connect_buton
            // 
            this.connect_buton.Location = new System.Drawing.Point(603, 90);
            this.connect_buton.Name = "connect_buton";
            this.connect_buton.Size = new System.Drawing.Size(188, 23);
            this.connect_buton.TabIndex = 4;
            this.connect_buton.Text = "Connect";
            this.connect_buton.UseVisualStyleBackColor = true;
            this.connect_buton.Click += new System.EventHandler(this.connect_buton_Click);
            // 
            // chat_listbox
            // 
            this.chat_listbox.FormattingEnabled = true;
            this.chat_listbox.ItemHeight = 16;
            this.chat_listbox.Location = new System.Drawing.Point(12, 17);
            this.chat_listbox.Name = "chat_listbox";
            this.chat_listbox.Size = new System.Drawing.Size(582, 196);
            this.chat_listbox.TabIndex = 5;
            // 
            // send_textbox
            // 
            this.send_textbox.Location = new System.Drawing.Point(77, 230);
            this.send_textbox.Name = "send_textbox";
            this.send_textbox.Size = new System.Drawing.Size(445, 22);
            this.send_textbox.TabIndex = 6;
            // 
            // send_button
            // 
            this.send_button.Location = new System.Drawing.Point(528, 230);
            this.send_button.Name = "send_button";
            this.send_button.Size = new System.Drawing.Size(75, 23);
            this.send_button.TabIndex = 7;
            this.send_button.Text = "Send";
            this.send_button.UseVisualStyleBackColor = true;
            this.send_button.Click += new System.EventHandler(this.send_button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Text";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(600, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ip Client:";
            // 
            // Ipclient_textbox
            // 
            this.Ipclient_textbox.Location = new System.Drawing.Point(663, 194);
            this.Ipclient_textbox.Name = "Ipclient_textbox";
            this.Ipclient_textbox.Size = new System.Drawing.Size(131, 22);
            this.Ipclient_textbox.TabIndex = 10;
            this.Ipclient_textbox.Text = "192.168.93.1";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 286);
            this.Controls.Add(this.Ipclient_textbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.send_button);
            this.Controls.Add(this.send_textbox);
            this.Controls.Add(this.chat_listbox);
            this.Controls.Add(this.connect_buton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IP_textbox);
            this.Controls.Add(this.port_textbox);
            this.Name = "Form1";
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Ipclient_textbox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

