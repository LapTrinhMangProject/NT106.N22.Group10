namespace Lab4
{
    partial class Menu
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
            this.bt_Bai1 = new System.Windows.Forms.Button();
            this.bt_Bai3 = new System.Windows.Forms.Button();
            this.bt_Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(291, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bài tập lab 4";
            // 
            // bt_Bai1
            // 
            this.bt_Bai1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Bai1.Location = new System.Drawing.Point(138, 168);
            this.bt_Bai1.Name = "bt_Bai1";
            this.bt_Bai1.Size = new System.Drawing.Size(120, 51);
            this.bt_Bai1.TabIndex = 1;
            this.bt_Bai1.Text = "Bài 1";
            this.bt_Bai1.UseVisualStyleBackColor = true;
            this.bt_Bai1.Click += new System.EventHandler(this.bt_Bai1_Click);
            // 
            // bt_Bai3
            // 
            this.bt_Bai3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Bai3.Location = new System.Drawing.Point(522, 168);
            this.bt_Bai3.Name = "bt_Bai3";
            this.bt_Bai3.Size = new System.Drawing.Size(120, 51);
            this.bt_Bai3.TabIndex = 2;
            this.bt_Bai3.Text = "Bài 3";
            this.bt_Bai3.UseVisualStyleBackColor = true;
            this.bt_Bai3.Click += new System.EventHandler(this.bt_Bai3_Click);
            // 
            // bt_Exit
            // 
            this.bt_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Exit.Location = new System.Drawing.Point(668, 387);
            this.bt_Exit.Name = "bt_Exit";
            this.bt_Exit.Size = new System.Drawing.Size(120, 51);
            this.bt_Exit.TabIndex = 3;
            this.bt_Exit.Text = "Exit";
            this.bt_Exit.UseVisualStyleBackColor = true;
            this.bt_Exit.Click += new System.EventHandler(this.bt_Exit_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_Exit);
            this.Controls.Add(this.bt_Bai3);
            this.Controls.Add(this.bt_Bai1);
            this.Controls.Add(this.label1);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_Bai1;
        private System.Windows.Forms.Button bt_Bai3;
        private System.Windows.Forms.Button bt_Exit;
    }
}

