namespace Lab4
{
    partial class Bai3
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
            this.tb_Address = new System.Windows.Forms.TextBox();
            this.bt_Go = new System.Windows.Forms.Button();
            this.bt_Exit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bt_Download = new System.Windows.Forms.Button();
            this.bt_GotoSource = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_Address
            // 
            this.tb_Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Address.Location = new System.Drawing.Point(12, 22);
            this.tb_Address.Name = "tb_Address";
            this.tb_Address.Size = new System.Drawing.Size(624, 26);
            this.tb_Address.TabIndex = 0;
            // 
            // bt_Go
            // 
            this.bt_Go.Location = new System.Drawing.Point(642, 25);
            this.bt_Go.Name = "bt_Go";
            this.bt_Go.Size = new System.Drawing.Size(75, 23);
            this.bt_Go.TabIndex = 1;
            this.bt_Go.Text = "Go";
            this.bt_Go.UseVisualStyleBackColor = true;
            this.bt_Go.Click += new System.EventHandler(this.bt_Go_Click);
            // 
            // bt_Exit
            // 
            this.bt_Exit.Location = new System.Drawing.Point(723, 25);
            this.bt_Exit.Name = "bt_Exit";
            this.bt_Exit.Size = new System.Drawing.Size(75, 23);
            this.bt_Exit.TabIndex = 2;
            this.bt_Exit.Text = "Exit";
            this.bt_Exit.UseVisualStyleBackColor = true;
            this.bt_Exit.Click += new System.EventHandler(this.bt_Exit_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(786, 321);
            this.panel1.TabIndex = 3;
            // 
            // bt_Download
            // 
            this.bt_Download.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Download.Location = new System.Drawing.Point(642, 406);
            this.bt_Download.Name = "bt_Download";
            this.bt_Download.Size = new System.Drawing.Size(146, 32);
            this.bt_Download.TabIndex = 4;
            this.bt_Download.Text = "Download file";
            this.bt_Download.UseVisualStyleBackColor = true;
            this.bt_Download.Click += new System.EventHandler(this.bt_Download_Click);
            // 
            // bt_GotoSource
            // 
            this.bt_GotoSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_GotoSource.Location = new System.Drawing.Point(472, 406);
            this.bt_GotoSource.Name = "bt_GotoSource";
            this.bt_GotoSource.Size = new System.Drawing.Size(146, 32);
            this.bt_GotoSource.TabIndex = 5;
            this.bt_GotoSource.Text = "Go to source";
            this.bt_GotoSource.UseVisualStyleBackColor = true;
            this.bt_GotoSource.Click += new System.EventHandler(this.bt_GotoSource_Click);
            // 
            // Bai3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_GotoSource);
            this.Controls.Add(this.bt_Download);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bt_Exit);
            this.Controls.Add(this.bt_Go);
            this.Controls.Add(this.tb_Address);
            this.Name = "Bai3";
            this.Text = "Bài 3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_Address;
        private System.Windows.Forms.Button bt_Go;
        private System.Windows.Forms.Button bt_Exit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bt_Download;
        private System.Windows.Forms.Button bt_GotoSource;
    }
}