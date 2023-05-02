namespace Server
{
    partial class Server_form
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
            this.status_textbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.List_connection = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // chat
            // 
            this.chat.FormattingEnabled = true;
            this.chat.Location = new System.Drawing.Point(9, 16);
            this.chat.Margin = new System.Windows.Forms.Padding(2);
            this.chat.Name = "chat";
            this.chat.Size = new System.Drawing.Size(351, 212);
            this.chat.TabIndex = 0;
            this.chat.SelectedIndexChanged += new System.EventHandler(this.chat_SelectedIndexChanged);
            // 
            // runserver_button
            // 
            this.runserver_button.Location = new System.Drawing.Point(428, 46);
            this.runserver_button.Margin = new System.Windows.Forms.Padding(2);
            this.runserver_button.Name = "runserver_button";
            this.runserver_button.Size = new System.Drawing.Size(56, 19);
            this.runserver_button.TabIndex = 1;
            this.runserver_button.Text = "Run";
            this.runserver_button.UseVisualStyleBackColor = true;
            this.runserver_button.Click += new System.EventHandler(this.runserver_button_Click);
            // 
            // severport_textbox
            // 
            this.severport_textbox.Location = new System.Drawing.Point(489, 16);
            this.severport_textbox.Margin = new System.Windows.Forms.Padding(2);
            this.severport_textbox.Name = "severport_textbox";
            this.severport_textbox.ReadOnly = true;
            this.severport_textbox.Size = new System.Drawing.Size(76, 20);
            this.severport_textbox.TabIndex = 2;
            this.severport_textbox.Text = "Port: 8080";
            // 
            // severip_textbox
            // 
            this.severip_textbox.Location = new System.Drawing.Point(410, 16);
            this.severip_textbox.Margin = new System.Windows.Forms.Padding(2);
            this.severip_textbox.Name = "severip_textbox";
            this.severip_textbox.Size = new System.Drawing.Size(76, 20);
            this.severip_textbox.TabIndex = 3;
            this.severip_textbox.Text = "192.168.1.9";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(362, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Sever IP";
            // 
            // status_textbox
            // 
            this.status_textbox.Location = new System.Drawing.Point(404, 85);
            this.status_textbox.Margin = new System.Windows.Forms.Padding(2);
            this.status_textbox.Name = "status_textbox";
            this.status_textbox.Size = new System.Drawing.Size(182, 20);
            this.status_textbox.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(364, 88);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Status:";
            // 
            // List_connection
            // 
            this.List_connection.FormattingEnabled = true;
            this.List_connection.Location = new System.Drawing.Point(364, 110);
            this.List_connection.Margin = new System.Windows.Forms.Padding(2);
            this.List_connection.Name = "List_connection";
            this.List_connection.Size = new System.Drawing.Size(228, 121);
            this.List_connection.TabIndex = 10;
            this.List_connection.SelectedIndexChanged += new System.EventHandler(this.List_connection_SelectedIndexChanged);
            // 
            // Server_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 241);
            this.Controls.Add(this.List_connection);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.status_textbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.severip_textbox);
            this.Controls.Add(this.severport_textbox);
            this.Controls.Add(this.runserver_button);
            this.Controls.Add(this.chat);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Server_form";
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
        private System.Windows.Forms.TextBox status_textbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox List_connection;
    }
}

