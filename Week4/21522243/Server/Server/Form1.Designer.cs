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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_PortSV = new System.Windows.Forms.TextBox();
            this.tb_IPSV = new System.Windows.Forms.TextBox();
            this.bt_Start = new System.Windows.Forms.Button();
            this.lstChatServer = new System.Windows.Forms.ListBox();
            this.bt_Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Port Server:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(63, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "IP Server:";
            // 
            // tb_PortSV
            // 
            this.tb_PortSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_PortSV.Location = new System.Drawing.Point(161, 80);
            this.tb_PortSV.Name = "tb_PortSV";
            this.tb_PortSV.Size = new System.Drawing.Size(68, 26);
            this.tb_PortSV.TabIndex = 4;
            // 
            // tb_IPSV
            // 
            this.tb_IPSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_IPSV.Location = new System.Drawing.Point(161, 36);
            this.tb_IPSV.Name = "tb_IPSV";
            this.tb_IPSV.Size = new System.Drawing.Size(149, 26);
            this.tb_IPSV.TabIndex = 5;
            // 
            // bt_Start
            // 
            this.bt_Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Start.Location = new System.Drawing.Point(440, 29);
            this.bt_Start.Name = "bt_Start";
            this.bt_Start.Size = new System.Drawing.Size(123, 40);
            this.bt_Start.TabIndex = 6;
            this.bt_Start.Text = "Start Listening";
            this.bt_Start.UseVisualStyleBackColor = true;
            this.bt_Start.Click += new System.EventHandler(this.bt_Start_Click);
            // 
            // lstChatServer
            // 
            this.lstChatServer.FormattingEnabled = true;
            this.lstChatServer.Location = new System.Drawing.Point(67, 141);
            this.lstChatServer.Name = "lstChatServer";
            this.lstChatServer.Size = new System.Drawing.Size(450, 277);
            this.lstChatServer.TabIndex = 7;
            // 
            // bt_Exit
            // 
            this.bt_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Exit.Location = new System.Drawing.Point(440, 80);
            this.bt_Exit.Name = "bt_Exit";
            this.bt_Exit.Size = new System.Drawing.Size(123, 38);
            this.bt_Exit.TabIndex = 17;
            this.bt_Exit.Text = "Exit";
            this.bt_Exit.UseVisualStyleBackColor = true;
            this.bt_Exit.Click += new System.EventHandler(this.bt_Exit_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_Exit);
            this.Controls.Add(this.lstChatServer);
            this.Controls.Add(this.bt_Start);
            this.Controls.Add(this.tb_IPSV);
            this.Controls.Add(this.tb_PortSV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Server";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_PortSV;
        private System.Windows.Forms.TextBox tb_IPSV;
        private System.Windows.Forms.Button bt_Start;
        private System.Windows.Forms.ListBox lstChatServer;
        private System.Windows.Forms.Button bt_Exit;
    }
}

