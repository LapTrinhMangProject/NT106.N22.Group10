
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
            this.serverIP_tb = new System.Windows.Forms.TextBox();
            this.serverPort_tb = new System.Windows.Forms.TextBox();
            this.chat_lb = new System.Windows.Forms.ListBox();
            this.run_bt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // serverIP_tb
            // 
            this.serverIP_tb.Location = new System.Drawing.Point(106, 47);
            this.serverIP_tb.Name = "serverIP_tb";
            this.serverIP_tb.Size = new System.Drawing.Size(275, 22);
            this.serverIP_tb.TabIndex = 0;
            // 
            // serverPort_tb
            // 
            this.serverPort_tb.Location = new System.Drawing.Point(498, 47);
            this.serverPort_tb.Name = "serverPort_tb";
            this.serverPort_tb.Size = new System.Drawing.Size(88, 22);
            this.serverPort_tb.TabIndex = 1;
            // 
            // chat_lb
            // 
            this.chat_lb.FormattingEnabled = true;
            this.chat_lb.ItemHeight = 16;
            this.chat_lb.Location = new System.Drawing.Point(106, 95);
            this.chat_lb.Name = "chat_lb";
            this.chat_lb.Size = new System.Drawing.Size(480, 180);
            this.chat_lb.TabIndex = 2;
            // 
            // run_bt
            // 
            this.run_bt.Location = new System.Drawing.Point(511, 294);
            this.run_bt.Name = "run_bt";
            this.run_bt.Size = new System.Drawing.Size(75, 23);
            this.run_bt.TabIndex = 3;
            this.run_bt.Text = "Run";
            this.run_bt.UseVisualStyleBackColor = true;
            this.run_bt.Click += new System.EventHandler(this.run_bt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Server IP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(418, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Sever port";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 352);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.run_bt);
            this.Controls.Add(this.chat_lb);
            this.Controls.Add(this.serverPort_tb);
            this.Controls.Add(this.serverIP_tb);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox serverIP_tb;
        private System.Windows.Forms.TextBox serverPort_tb;
        private System.Windows.Forms.ListBox chat_lb;
        private System.Windows.Forms.Button run_bt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

