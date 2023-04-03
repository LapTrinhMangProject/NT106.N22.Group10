namespace Server
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
            this.chat = new System.Windows.Forms.ListBox();
            this.runserver_button = new System.Windows.Forms.Button();
            this.severport_textbox = new System.Windows.Forms.TextBox();
            this.severip_textbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.send_textbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.send_button = new System.Windows.Forms.Button();
            this.status_textbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.List_connection = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // chat
            // 
            this.chat.FormattingEnabled = true;
            this.chat.ItemHeight = 16;
            this.chat.Location = new System.Drawing.Point(12, 20);
            this.chat.Name = "chat";
            this.chat.Size = new System.Drawing.Size(464, 196);
            this.chat.TabIndex = 0;
            this.chat.SelectedIndexChanged += new System.EventHandler(this.chat_SelectedIndexChanged);
            // 
            // runserver_button
            // 
            this.runserver_button.Location = new System.Drawing.Point(485, 63);
            this.runserver_button.Name = "runserver_button";
            this.runserver_button.Size = new System.Drawing.Size(75, 23);
            this.runserver_button.TabIndex = 1;
            this.runserver_button.Text = "Run";
            this.runserver_button.UseVisualStyleBackColor = true;
            this.runserver_button.Click += new System.EventHandler(this.runserver_button_Click);
            // 
            // severport_textbox
            // 
            this.severport_textbox.Location = new System.Drawing.Point(652, 20);
            this.severport_textbox.Name = "severport_textbox";
            this.severport_textbox.ReadOnly = true;
            this.severport_textbox.Size = new System.Drawing.Size(100, 22);
            this.severport_textbox.TabIndex = 2;
            this.severport_textbox.Text = "Port: 8080";
            // 
            // severip_textbox
            // 
            this.severip_textbox.Location = new System.Drawing.Point(546, 20);
            this.severip_textbox.Name = "severip_textbox";
            this.severip_textbox.Size = new System.Drawing.Size(100, 22);
            this.severip_textbox.TabIndex = 3;
            this.severip_textbox.Text = "192.168.93.1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(482, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Sever IP";
            // 
            // send_textbox
            // 
            this.send_textbox.Location = new System.Drawing.Point(51, 234);
            this.send_textbox.Name = "send_textbox";
            this.send_textbox.Size = new System.Drawing.Size(326, 22);
            this.send_textbox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Text";
            // 
            // send_button
            // 
            this.send_button.Location = new System.Drawing.Point(383, 233);
            this.send_button.Name = "send_button";
            this.send_button.Size = new System.Drawing.Size(75, 23);
            this.send_button.TabIndex = 7;
            this.send_button.Text = "Send";
            this.send_button.UseVisualStyleBackColor = true;
            this.send_button.Click += new System.EventHandler(this.send_button_Click);
            // 
            // status_textbox
            // 
            this.status_textbox.Location = new System.Drawing.Point(546, 108);
            this.status_textbox.Name = "status_textbox";
            this.status_textbox.Size = new System.Drawing.Size(242, 22);
            this.status_textbox.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(495, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Status:";
            // 
            // List_connection
            // 
            this.List_connection.FormattingEnabled = true;
            this.List_connection.ItemHeight = 16;
            this.List_connection.Location = new System.Drawing.Point(498, 151);
            this.List_connection.Name = "List_connection";
            this.List_connection.Size = new System.Drawing.Size(290, 116);
            this.List_connection.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 297);
            this.Controls.Add(this.List_connection);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.status_textbox);
            this.Controls.Add(this.send_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.send_textbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.severip_textbox);
            this.Controls.Add(this.severport_textbox);
            this.Controls.Add(this.runserver_button);
            this.Controls.Add(this.chat);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox chat;
        private System.Windows.Forms.Button runserver_button;
        private System.Windows.Forms.TextBox severport_textbox;
        private System.Windows.Forms.TextBox severip_textbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox send_textbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button send_button;
        private System.Windows.Forms.TextBox status_textbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox List_connection;
    }
}

