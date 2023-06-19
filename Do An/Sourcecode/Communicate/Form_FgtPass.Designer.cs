namespace Communicate
{
    partial class Form_FgtPass
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tb_Email = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bt_Send = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Communicate.Properties.Resources.download__4_;
            this.pictureBox2.Location = new System.Drawing.Point(137, 57);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(248, 126);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // tb_Email
            // 
            this.tb_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Email.Location = new System.Drawing.Point(121, 213);
            this.tb_Email.Name = "tb_Email";
            this.tb_Email.Size = new System.Drawing.Size(289, 38);
            this.tb_Email.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Communicate.Properties.Resources.download__4_;
            this.pictureBox1.Location = new System.Drawing.Point(46, 202);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 49);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // bt_Send
            // 
            this.bt_Send.BackColor = System.Drawing.Color.SandyBrown;
            this.bt_Send.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Send.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_Send.Location = new System.Drawing.Point(207, 285);
            this.bt_Send.Margin = new System.Windows.Forms.Padding(2);
            this.bt_Send.Name = "bt_Send";
            this.bt_Send.Size = new System.Drawing.Size(110, 51);
            this.bt_Send.TabIndex = 11;
            this.bt_Send.Text = "Gửi Email";
            this.bt_Send.UseVisualStyleBackColor = false;
            this.bt_Send.Click += new System.EventHandler(this.bt_Send_Click);
            // 
            // Form_FgtPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(516, 365);
            this.Controls.Add(this.bt_Send);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tb_Email);
            this.Controls.Add(this.pictureBox2);
            this.Name = "Form_FgtPass";
            this.Text = "Form_FgtPass";
            this.Load += new System.EventHandler(this.Form_FgtPass_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox tb_Email;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bt_Send;
    }
}