using System.Windows.Controls;

namespace Communicate
{
    partial class Client
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
            this.username_textbox = new System.Windows.Forms.TextBox();
            this.pass_textbox = new System.Windows.Forms.TextBox();
            this.login_button = new System.Windows.Forms.Button();
            this.bt_Dangky = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // username_textbox
            // 
            this.username_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_textbox.Location = new System.Drawing.Point(152, 215);
            this.username_textbox.Margin = new System.Windows.Forms.Padding(2);
            this.username_textbox.Name = "username_textbox";
            this.username_textbox.Size = new System.Drawing.Size(160, 30);
            this.username_textbox.TabIndex = 3;
            // 
            // pass_textbox
            // 
            this.pass_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass_textbox.Location = new System.Drawing.Point(152, 283);
            this.pass_textbox.Margin = new System.Windows.Forms.Padding(2);
            this.pass_textbox.Name = "pass_textbox";
            this.pass_textbox.PasswordChar = '*';
            this.pass_textbox.Size = new System.Drawing.Size(160, 30);
            this.pass_textbox.TabIndex = 4;
            this.pass_textbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pass_textbox_KeyDown);
            // 
            // login_button
            // 
            this.login_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_button.Location = new System.Drawing.Point(194, 329);
            this.login_button.Margin = new System.Windows.Forms.Padding(2);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(118, 46);
            this.login_button.TabIndex = 5;
            this.login_button.Text = "Đăng nhập";
            this.login_button.UseVisualStyleBackColor = true;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // bt_Dangky
            // 
            this.bt_Dangky.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Dangky.Location = new System.Drawing.Point(43, 329);
            this.bt_Dangky.Margin = new System.Windows.Forms.Padding(2);
            this.bt_Dangky.Name = "bt_Dangky";
            this.bt_Dangky.Size = new System.Drawing.Size(119, 46);
            this.bt_Dangky.TabIndex = 6;
            this.bt_Dangky.Text = "Đăng ký";
            this.bt_Dangky.UseVisualStyleBackColor = true;
            this.bt_Dangky.Click += new System.EventHandler(this.bt_Dangky_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Communicate.Properties.Resources._0af3c9613761d2d2394d99312aeba397;
            this.pictureBox1.Location = new System.Drawing.Point(43, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(283, 178);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Communicate.Properties.Resources.user_icon_150670;
            this.pictureBox3.Location = new System.Drawing.Point(91, 199);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(45, 46);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Communicate.Properties.Resources.Icons8_Windows_8_Security_Password_2__1_;
            this.pictureBox2.Location = new System.Drawing.Point(91, 267);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(45, 46);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 395);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bt_Dangky);
            this.Controls.Add(this.login_button);
            this.Controls.Add(this.pass_textbox);
            this.Controls.Add(this.username_textbox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Client";
            this.Text = "Client";
            this.Load += new System.EventHandler(this.Client_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox username_textbox;
        private System.Windows.Forms.TextBox pass_textbox;
        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.Button bt_Dangky;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}