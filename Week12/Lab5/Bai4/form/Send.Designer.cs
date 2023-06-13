namespace form
{
    partial class SendForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nameTextbox = new System.Windows.Forms.TextBox();
            this.subjectTextbox = new System.Windows.Forms.TextBox();
            this.bodyRichTextbox = new System.Windows.Forms.RichTextBox();
            this.fromTextbox = new System.Windows.Forms.TextBox();
            this.sendButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.toTextbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.htmlCheckbox = new System.Windows.Forms.CheckBox();
            this.browserButton = new System.Windows.Forms.Button();
            this.attachmentTextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Subject";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Body";
            // 
            // nameTextbox
            // 
            this.nameTextbox.Location = new System.Drawing.Point(78, 67);
            this.nameTextbox.Name = "nameTextbox";
            this.nameTextbox.Size = new System.Drawing.Size(133, 20);
            this.nameTextbox.TabIndex = 4;
            // 
            // subjectTextbox
            // 
            this.subjectTextbox.Location = new System.Drawing.Point(78, 153);
            this.subjectTextbox.Name = "subjectTextbox";
            this.subjectTextbox.Size = new System.Drawing.Size(133, 20);
            this.subjectTextbox.TabIndex = 5;
            // 
            // bodyRichTextbox
            // 
            this.bodyRichTextbox.Location = new System.Drawing.Point(16, 217);
            this.bodyRichTextbox.Name = "bodyRichTextbox";
            this.bodyRichTextbox.Size = new System.Drawing.Size(419, 224);
            this.bodyRichTextbox.TabIndex = 6;
            this.bodyRichTextbox.Text = "";
            // 
            // fromTextbox
            // 
            this.fromTextbox.Location = new System.Drawing.Point(78, 21);
            this.fromTextbox.Name = "fromTextbox";
            this.fromTextbox.Size = new System.Drawing.Size(133, 20);
            this.fromTextbox.TabIndex = 7;
            // 
            // sendButton
            // 
            this.sendButton.Location = new System.Drawing.Point(326, 520);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(109, 48);
            this.sendButton.TabIndex = 8;
            this.sendButton.Text = "Gửi";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 473);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Attachment";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // toTextbox
            // 
            this.toTextbox.Location = new System.Drawing.Point(78, 108);
            this.toTextbox.Name = "toTextbox";
            this.toTextbox.Size = new System.Drawing.Size(133, 20);
            this.toTextbox.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "To";
            // 
            // htmlCheckbox
            // 
            this.htmlCheckbox.AutoSize = true;
            this.htmlCheckbox.Location = new System.Drawing.Point(93, 188);
            this.htmlCheckbox.Name = "htmlCheckbox";
            this.htmlCheckbox.Size = new System.Drawing.Size(56, 17);
            this.htmlCheckbox.TabIndex = 14;
            this.htmlCheckbox.Text = "HTML";
            this.htmlCheckbox.UseVisualStyleBackColor = true;
            // 
            // browserButton
            // 
            this.browserButton.Location = new System.Drawing.Point(326, 460);
            this.browserButton.Name = "browserButton";
            this.browserButton.Size = new System.Drawing.Size(99, 39);
            this.browserButton.TabIndex = 15;
            this.browserButton.Text = "Browser";
            this.browserButton.UseVisualStyleBackColor = true;
            this.browserButton.Click += new System.EventHandler(this.browserButton_Click);
            // 
            // attachmentTextbox
            // 
            this.attachmentTextbox.Location = new System.Drawing.Point(93, 470);
            this.attachmentTextbox.Name = "attachmentTextbox";
            this.attachmentTextbox.Size = new System.Drawing.Size(227, 20);
            this.attachmentTextbox.TabIndex = 16;
            // 
            // SendForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 597);
            this.Controls.Add(this.attachmentTextbox);
            this.Controls.Add(this.browserButton);
            this.Controls.Add(this.htmlCheckbox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.toTextbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.fromTextbox);
            this.Controls.Add(this.bodyRichTextbox);
            this.Controls.Add(this.subjectTextbox);
            this.Controls.Add(this.nameTextbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SendForm";
            this.Text = "Send";
            this.Load += new System.EventHandler(this.SendForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nameTextbox;
        private System.Windows.Forms.TextBox subjectTextbox;
        private System.Windows.Forms.RichTextBox bodyRichTextbox;
        private System.Windows.Forms.TextBox fromTextbox;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox toTextbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox htmlCheckbox;
        private System.Windows.Forms.Button browserButton;
        private System.Windows.Forms.TextBox attachmentTextbox;
    }
}