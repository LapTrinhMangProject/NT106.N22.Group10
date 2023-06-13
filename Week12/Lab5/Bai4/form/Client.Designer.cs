namespace form
{
    partial class ClientForm
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.number = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.from = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.subject = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.datetime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sendmailButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.number,
            this.from,
            this.subject,
            this.datetime});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 163);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1408, 627);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.listView1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDown);
            // 
            // number
            // 
            this.number.Text = "#";
            // 
            // from
            // 
            this.from.Text = "from";
            this.from.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.from.Width = 400;
            // 
            // subject
            // 
            this.subject.Text = "Subject";
            this.subject.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.subject.Width = 400;
            // 
            // datetime
            // 
            this.datetime.Text = "Datetime";
            this.datetime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.datetime.Width = 210;
            // 
            // sendmailButton
            // 
            this.sendmailButton.Location = new System.Drawing.Point(12, 105);
            this.sendmailButton.Name = "sendmailButton";
            this.sendmailButton.Size = new System.Drawing.Size(157, 52);
            this.sendmailButton.TabIndex = 1;
            this.sendmailButton.Text = "Gửi mail";
            this.sendmailButton.UseVisualStyleBackColor = true;
            this.sendmailButton.Click += new System.EventHandler(this.sendmailButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(245, 105);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 52);
            this.button1.TabIndex = 2;
            this.button1.Text = "Đăng xuất";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1432, 802);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.sendmailButton);
            this.Controls.Add(this.listView1);
            this.Name = "ClientForm";
            this.Text = "Client";
            this.Load += new System.EventHandler(this.Client_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader number;
        private System.Windows.Forms.ColumnHeader from;
        private System.Windows.Forms.ColumnHeader subject;
        private System.Windows.Forms.ColumnHeader datetime;
        private System.Windows.Forms.Button sendmailButton;
        private System.Windows.Forms.Button button1;
    }
}