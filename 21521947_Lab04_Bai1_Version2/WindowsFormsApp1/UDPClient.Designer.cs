namespace WindowsFormsApp1
{
    partial class UDPClient
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
            this.display = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // display
            // 
            this.display.Location = new System.Drawing.Point(12, 132);
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(776, 306);
            this.display.TabIndex = 1;
            this.display.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(544, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(203, 47);
            this.button1.TabIndex = 2;
            this.button1.Text = "connect and send";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // UDPClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.display);
            this.Name = "UDPClient";
            this.Text = "UDPClient";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RichTextBox display;
        private System.Windows.Forms.Button button1;
    }
}