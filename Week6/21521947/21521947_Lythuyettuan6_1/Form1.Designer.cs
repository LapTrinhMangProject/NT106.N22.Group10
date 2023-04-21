namespace _21521947_Lythuyettuan6_1
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
            this.geturl = new System.Windows.Forms.Button();
            this.displayurl = new System.Windows.Forms.ListBox();
            this.pasteURL = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // geturl
            // 
            this.geturl.Location = new System.Drawing.Point(57, 48);
            this.geturl.Name = "geturl";
            this.geturl.Size = new System.Drawing.Size(178, 52);
            this.geturl.TabIndex = 1;
            this.geturl.Text = "button1";
            this.geturl.UseVisualStyleBackColor = true;
            this.geturl.Click += new System.EventHandler(this.geturl_Click);
            // 
            // displayurl
            // 
            this.displayurl.FormattingEnabled = true;
            this.displayurl.ItemHeight = 16;
            this.displayurl.Location = new System.Drawing.Point(12, 129);
            this.displayurl.Name = "displayurl";
            this.displayurl.Size = new System.Drawing.Size(776, 308);
            this.displayurl.TabIndex = 3;
            // 
            // pasteURL
            // 
            this.pasteURL.Location = new System.Drawing.Point(336, 53);
            this.pasteURL.Name = "pasteURL";
            this.pasteURL.Size = new System.Drawing.Size(379, 22);
            this.pasteURL.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pasteURL);
            this.Controls.Add(this.displayurl);
            this.Controls.Add(this.geturl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button geturl;
        private System.Windows.Forms.ListBox displayurl;
        private System.Windows.Forms.TextBox pasteURL;
    }
}

