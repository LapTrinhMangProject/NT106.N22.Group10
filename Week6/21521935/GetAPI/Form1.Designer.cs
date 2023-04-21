namespace GetAPI
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
            this.GetAPI = new System.Windows.Forms.Button();
            this.thongtintask = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // GetAPI
            // 
            this.GetAPI.Location = new System.Drawing.Point(27, 290);
            this.GetAPI.Name = "GetAPI";
            this.GetAPI.Size = new System.Drawing.Size(75, 23);
            this.GetAPI.TabIndex = 0;
            this.GetAPI.Text = "GetAPI";
            this.GetAPI.UseVisualStyleBackColor = true;
            this.GetAPI.Click += new System.EventHandler(this.GetAPI_Click);
            // 
            // thongtintask
            // 
            this.thongtintask.FormattingEnabled = true;
            this.thongtintask.ItemHeight = 16;
            this.thongtintask.Location = new System.Drawing.Point(12, 5);
            this.thongtintask.Name = "thongtintask";
            this.thongtintask.Size = new System.Drawing.Size(776, 276);
            this.thongtintask.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.thongtintask);
            this.Controls.Add(this.GetAPI);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button GetAPI;
        private System.Windows.Forms.ListBox thongtintask;
    }
}

