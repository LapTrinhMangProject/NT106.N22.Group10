namespace Lab3
{
    partial class Lab3_form
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
            this.bai4_button = new System.Windows.Forms.Button();
            this.bai1_button = new System.Windows.Forms.Button();
            this.bai3_button = new System.Windows.Forms.Button();
            this.bai2_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bai4_button
            // 
            this.bai4_button.Location = new System.Drawing.Point(172, 141);
            this.bai4_button.Name = "bai4_button";
            this.bai4_button.Size = new System.Drawing.Size(75, 23);
            this.bai4_button.TabIndex = 0;
            this.bai4_button.Text = "Bài 4";
            this.bai4_button.UseVisualStyleBackColor = true;
            this.bai4_button.Click += new System.EventHandler(this.bai4_button_Click);
            // 
            // bai1_button
            // 
            this.bai1_button.Location = new System.Drawing.Point(12, 42);
            this.bai1_button.Name = "bai1_button";
            this.bai1_button.Size = new System.Drawing.Size(75, 23);
            this.bai1_button.TabIndex = 1;
            this.bai1_button.Text = "Bài 1";
            this.bai1_button.UseVisualStyleBackColor = true;
            this.bai1_button.Click += new System.EventHandler(this.bai1_button_Click);
            // 
            // bai3_button
            // 
            this.bai3_button.Location = new System.Drawing.Point(172, 42);
            this.bai3_button.Name = "bai3_button";
            this.bai3_button.Size = new System.Drawing.Size(75, 23);
            this.bai3_button.TabIndex = 2;
            this.bai3_button.Text = "Bài 3";
            this.bai3_button.UseVisualStyleBackColor = true;
            this.bai3_button.Click += new System.EventHandler(this.bai3_button_Click);
            // 
            // bai2_button
            // 
            this.bai2_button.Location = new System.Drawing.Point(12, 141);
            this.bai2_button.Name = "bai2_button";
            this.bai2_button.Size = new System.Drawing.Size(75, 23);
            this.bai2_button.TabIndex = 3;
            this.bai2_button.Text = "Bài 2";
            this.bai2_button.UseVisualStyleBackColor = true;
            this.bai2_button.Click += new System.EventHandler(this.bai2_button_Click);
            // 
            // Lab3_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 197);
            this.Controls.Add(this.bai2_button);
            this.Controls.Add(this.bai3_button);
            this.Controls.Add(this.bai1_button);
            this.Controls.Add(this.bai4_button);
            this.Name = "Lab3_form";
            this.Text = "Lab3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bai4_button;
        private System.Windows.Forms.Button bai1_button;
        private System.Windows.Forms.Button bai3_button;
        private System.Windows.Forms.Button bai2_button;
    }
}

