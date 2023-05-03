namespace Bai1
{
    partial class UDPServer
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
            this.ListenButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.PortTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // display
            // 
            this.display.Location = new System.Drawing.Point(11, 103);
            this.display.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(583, 252);
            this.display.TabIndex = 0;
            this.display.Text = "";
            // 
            // ListenButton
            // 
            this.ListenButton.Location = new System.Drawing.Point(444, 46);
            this.ListenButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ListenButton.Name = "ListenButton";
            this.ListenButton.Size = new System.Drawing.Size(137, 32);
            this.ListenButton.TabIndex = 2;
            this.ListenButton.Text = "Listen";
            this.ListenButton.UseVisualStyleBackColor = true;
            this.ListenButton.Click += new System.EventHandler(this.ListenButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Port";
            // 
            // PortTB
            // 
            this.PortTB.Location = new System.Drawing.Point(11, 73);
            this.PortTB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PortTB.Name = "PortTB";
            this.PortTB.Size = new System.Drawing.Size(102, 20);
            this.PortTB.TabIndex = 4;
            this.PortTB.Text = "8050";
            // 
            // UDPServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 361);
            this.Controls.Add(this.PortTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ListenButton);
            this.Controls.Add(this.display);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UDPServer";
            this.Text = "UDPServer";
            this.Load += new System.EventHandler(this.UDPServer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox display;
        private System.Windows.Forms.Button ListenButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PortTB;
    }
}