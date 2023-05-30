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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.username_textbox = new System.Windows.Forms.TextBox();
            this.pass_textbox = new System.Windows.Forms.TextBox();
            this.login_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đăng nhập";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tài khoản";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 93);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mật khẩu";
            // 
            // username_textbox
            // 
            this.username_textbox.Location = new System.Drawing.Point(99, 50);
            this.username_textbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.username_textbox.Name = "username_textbox";
            this.username_textbox.Size = new System.Drawing.Size(114, 20);
            this.username_textbox.TabIndex = 3;
            // 
            // pass_textbox
            // 
            this.pass_textbox.Location = new System.Drawing.Point(99, 88);
            this.pass_textbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pass_textbox.Name = "pass_textbox";
            this.pass_textbox.PasswordChar = '*';
            this.pass_textbox.Size = new System.Drawing.Size(114, 20);
            this.pass_textbox.TabIndex = 4;
            this.pass_textbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pass_textbox_KeyDown);
            // 
            // login_button
            // 
            this.login_button.Location = new System.Drawing.Point(99, 124);
            this.login_button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(89, 28);
            this.login_button.TabIndex = 5;
            this.login_button.Text = "Đăng nhập";
            this.login_button.UseVisualStyleBackColor = true;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 183);
            this.Controls.Add(this.login_button);
            this.Controls.Add(this.pass_textbox);
            this.Controls.Add(this.username_textbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Client";
            this.Text = "Client";
            this.Load += new System.EventHandler(this.Client_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox username_textbox;
        private System.Windows.Forms.TextBox pass_textbox;
        private System.Windows.Forms.Button login_button;
    }
}