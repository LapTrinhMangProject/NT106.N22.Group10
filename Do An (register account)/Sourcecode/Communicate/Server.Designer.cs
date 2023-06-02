namespace Communicate
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
            this.status_listbox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // status_listbox
            // 
            this.status_listbox.FormattingEnabled = true;
            this.status_listbox.Location = new System.Drawing.Point(12, 12);
            this.status_listbox.Name = "status_listbox";
            this.status_listbox.Size = new System.Drawing.Size(323, 134);
            this.status_listbox.TabIndex = 0;
            this.status_listbox.SelectedIndexChanged += new System.EventHandler(this.status_listbox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(132, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Trạng thái kết nối";
            // 
            // Server_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 182);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.status_listbox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Server_form";
            this.Text = "Server";
            this.Load += new System.EventHandler(this.Server_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox status_listbox;
        private System.Windows.Forms.Label label1;
    }
}