namespace Communicate
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
            this.server_button = new System.Windows.Forms.Button();
            this.client_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // server_button
            // 
            this.server_button.Location = new System.Drawing.Point(224, 183);
            this.server_button.Name = "server_button";
            this.server_button.Size = new System.Drawing.Size(90, 38);
            this.server_button.TabIndex = 0;
            this.server_button.Text = "Server";
            this.server_button.UseVisualStyleBackColor = true;
            this.server_button.Click += new System.EventHandler(this.server_button_Click);
            // 
            // client_button
            // 
            this.client_button.Location = new System.Drawing.Point(394, 183);
            this.client_button.Name = "client_button";
            this.client_button.Size = new System.Drawing.Size(90, 38);
            this.client_button.TabIndex = 1;
            this.client_button.Text = "Client";
            this.client_button.UseVisualStyleBackColor = true;
            this.client_button.Click += new System.EventHandler(this.client_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.client_button);
            this.Controls.Add(this.server_button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button server_button;
        private System.Windows.Forms.Button client_button;
    }
}

