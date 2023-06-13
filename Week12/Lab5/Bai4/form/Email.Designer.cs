namespace form
{
    partial class EmailForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.body = new System.Windows.Forms.WebBrowser();
            this.replyButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.body);
            this.groupBox1.Location = new System.Drawing.Point(13, 125);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(1137, 663);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // body
            // 
            this.body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.body.Location = new System.Drawing.Point(4, 19);
            this.body.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.body.MinimumSize = new System.Drawing.Size(27, 25);
            this.body.Name = "body";
            this.body.Size = new System.Drawing.Size(1129, 640);
            this.body.TabIndex = 0;
            this.body.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.body_DocumentCompleted);
            // 
            // replyButton
            // 
            this.replyButton.Location = new System.Drawing.Point(952, 54);
            this.replyButton.Name = "replyButton";
            this.replyButton.Size = new System.Drawing.Size(171, 64);
            this.replyButton.TabIndex = 1;
            this.replyButton.Text = "Trả lời email";
            this.replyButton.UseVisualStyleBackColor = true;
            this.replyButton.Click += new System.EventHandler(this.replyButton_Click);
            // 
            // EmailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 791);
            this.Controls.Add(this.replyButton);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "EmailForm";
            this.Text = "email";
            this.Load += new System.EventHandler(this.email_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.WebBrowser body;
        private System.Windows.Forms.Button replyButton;
    }
}