namespace Communicate
{
    partial class Form_ResetPass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_ResetPass));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tb_RestPass = new System.Windows.Forms.TextBox();
            this.tb_RestPass1 = new System.Windows.Forms.TextBox();
            this.bt_Confirm = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(137, 49);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(204, 118);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // tb_RestPass
            // 
            this.tb_RestPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_RestPass.Location = new System.Drawing.Point(125, 188);
            this.tb_RestPass.Margin = new System.Windows.Forms.Padding(2);
            this.tb_RestPass.Name = "tb_RestPass";
            this.tb_RestPass.PasswordChar = '*';
            this.tb_RestPass.Size = new System.Drawing.Size(232, 38);
            this.tb_RestPass.TabIndex = 17;
            // 
            // tb_RestPass1
            // 
            this.tb_RestPass1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_RestPass1.Location = new System.Drawing.Point(125, 251);
            this.tb_RestPass1.Margin = new System.Windows.Forms.Padding(2);
            this.tb_RestPass1.Name = "tb_RestPass1";
            this.tb_RestPass1.PasswordChar = '*';
            this.tb_RestPass1.Size = new System.Drawing.Size(232, 38);
            this.tb_RestPass1.TabIndex = 18;
            // 
            // bt_Confirm
            // 
            this.bt_Confirm.BackColor = System.Drawing.Color.SandyBrown;
            this.bt_Confirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Confirm.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_Confirm.Location = new System.Drawing.Point(188, 300);
            this.bt_Confirm.Margin = new System.Windows.Forms.Padding(2);
            this.bt_Confirm.Name = "bt_Confirm";
            this.bt_Confirm.Size = new System.Drawing.Size(110, 51);
            this.bt_Confirm.TabIndex = 24;
            this.bt_Confirm.Text = "Xác thực";
            this.bt_Confirm.UseVisualStyleBackColor = false;
            this.bt_Confirm.Click += new System.EventHandler(this.bt_Confirm_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(65, 188);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(46, 37);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 25;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(65, 250);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(46, 39);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 26;
            this.pictureBox5.TabStop = false;
            // 
            // Form_ResetPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(486, 362);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.bt_Confirm);
            this.Controls.Add(this.tb_RestPass1);
            this.Controls.Add(this.tb_RestPass);
            this.Controls.Add(this.pictureBox2);
            this.Name = "Form_ResetPass";
            this.Text = "Form_ResetPass";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox tb_RestPass;
        private System.Windows.Forms.TextBox tb_RestPass1;
        private System.Windows.Forms.Button bt_Confirm;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
    }
}