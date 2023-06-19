namespace Bài_3
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
            this.txt_email = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_recent = new System.Windows.Forms.TextBox();
            this.bt_POP = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.listView_message = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(77, 27);
            this.txt_email.Margin = new System.Windows.Forms.Padding(2);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(208, 20);
            this.txt_email.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Email:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Password:";
            // 
            // txt_password
            // 
            this.txt_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.Location = new System.Drawing.Point(77, 70);
            this.txt_password.Margin = new System.Windows.Forms.Padding(2);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.Size = new System.Drawing.Size(208, 20);
            this.txt_password.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 118);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Total:";
            // 
            // txt_total
            // 
            this.txt_total.Location = new System.Drawing.Point(50, 115);
            this.txt_total.Margin = new System.Windows.Forms.Padding(2);
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(67, 20);
            this.txt_total.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(142, 118);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Recent:";
            // 
            // txt_recent
            // 
            this.txt_recent.Location = new System.Drawing.Point(191, 115);
            this.txt_recent.Margin = new System.Windows.Forms.Padding(2);
            this.txt_recent.Name = "txt_recent";
            this.txt_recent.Size = new System.Drawing.Size(48, 20);
            this.txt_recent.TabIndex = 22;
            // 
            // bt_POP
            // 
            this.bt_POP.Location = new System.Drawing.Point(384, 30);
            this.bt_POP.Margin = new System.Windows.Forms.Padding(2);
            this.bt_POP.Name = "bt_POP";
            this.bt_POP.Size = new System.Drawing.Size(56, 19);
            this.bt_POP.TabIndex = 23;
            this.bt_POP.Text = "POP";
            this.bt_POP.UseVisualStyleBackColor = true;
            this.bt_POP.Click += new System.EventHandler(this.bt_POP_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(384, 73);
            this.btn_clear.Margin = new System.Windows.Forms.Padding(2);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(56, 19);
            this.btn_clear.TabIndex = 24;
            this.btn_clear.Text = "CLEAR";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // listView_message
            // 
            this.listView_message.HideSelection = false;
            this.listView_message.Location = new System.Drawing.Point(13, 150);
            this.listView_message.Margin = new System.Windows.Forms.Padding(2);
            this.listView_message.Name = "listView_message";
            this.listView_message.Size = new System.Drawing.Size(553, 238);
            this.listView_message.TabIndex = 25;
            this.listView_message.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 399);
            this.Controls.Add(this.listView_message);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.bt_POP);
            this.Controls.Add(this.txt_recent);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_total);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_email);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_recent;
        private System.Windows.Forms.Button bt_POP;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.ListView listView_message;
    }
}

