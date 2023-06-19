namespace Communicate
{
    partial class Form_Verify
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
            this.tb_OTP = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.bt_Verify = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SandyBrown;
            this.label1.Location = new System.Drawing.Point(107, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 51);
            this.label1.TabIndex = 17;
            this.label1.Text = "Nhập mã OTP";
            // 
            // tb_OTP
            // 
            this.tb_OTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_OTP.Location = new System.Drawing.Point(153, 157);
            this.tb_OTP.Margin = new System.Windows.Forms.Padding(2);
            this.tb_OTP.Name = "tb_OTP";
            this.tb_OTP.PasswordChar = '*';
            this.tb_OTP.Size = new System.Drawing.Size(192, 45);
            this.tb_OTP.TabIndex = 18;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Communicate.Properties.Resources.download__5_;
            this.pictureBox4.Location = new System.Drawing.Point(78, 157);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(51, 45);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 23;
            this.pictureBox4.TabStop = false;
            // 
            // bt_Verify
            // 
            this.bt_Verify.BackColor = System.Drawing.Color.SandyBrown;
            this.bt_Verify.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Verify.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_Verify.Location = new System.Drawing.Point(194, 235);
            this.bt_Verify.Margin = new System.Windows.Forms.Padding(2);
            this.bt_Verify.Name = "bt_Verify";
            this.bt_Verify.Size = new System.Drawing.Size(110, 51);
            this.bt_Verify.TabIndex = 24;
            this.bt_Verify.Text = "Xác thực";
            this.bt_Verify.UseVisualStyleBackColor = false;
            this.bt_Verify.Click += new System.EventHandler(this.bt_Verify_Click);
            // 
            // Form_Verify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(488, 336);
            this.Controls.Add(this.bt_Verify);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.tb_OTP);
            this.Controls.Add(this.label1);
            this.Name = "Form_Verify";
            this.Text = "Form_Verify";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_OTP;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button bt_Verify;
    }
}