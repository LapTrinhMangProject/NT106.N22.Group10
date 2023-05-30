namespace Lab4
{
    partial class Bai1
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
            this.tb_link = new System.Windows.Forms.TextBox();
            this.bt_Get = new System.Windows.Forms.Button();
            this.bt_Exit = new System.Windows.Forms.Button();
            this.rb_Content = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // tb_link
            // 
            this.tb_link.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_link.Location = new System.Drawing.Point(67, 41);
            this.tb_link.Multiline = true;
            this.tb_link.Name = "tb_link";
            this.tb_link.Size = new System.Drawing.Size(552, 40);
            this.tb_link.TabIndex = 1;
            // 
            // bt_Get
            // 
            this.bt_Get.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Get.Location = new System.Drawing.Point(625, 27);
            this.bt_Get.Name = "bt_Get";
            this.bt_Get.Size = new System.Drawing.Size(126, 38);
            this.bt_Get.TabIndex = 2;
            this.bt_Get.Text = "GET";
            this.bt_Get.UseVisualStyleBackColor = true;
            this.bt_Get.Click += new System.EventHandler(this.bt_Get_Click);
            // 
            // bt_Exit
            // 
            this.bt_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Exit.Location = new System.Drawing.Point(625, 71);
            this.bt_Exit.Name = "bt_Exit";
            this.bt_Exit.Size = new System.Drawing.Size(126, 42);
            this.bt_Exit.TabIndex = 4;
            this.bt_Exit.Text = "EXIT";
            this.bt_Exit.UseVisualStyleBackColor = true;
            this.bt_Exit.Click += new System.EventHandler(this.bt_Exit_Click);
            // 
            // rb_Content
            // 
            this.rb_Content.Location = new System.Drawing.Point(67, 119);
            this.rb_Content.Name = "rb_Content";
            this.rb_Content.Size = new System.Drawing.Size(684, 319);
            this.rb_Content.TabIndex = 5;
            this.rb_Content.Text = "";
            // 
            // Bai1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rb_Content);
            this.Controls.Add(this.bt_Exit);
            this.Controls.Add(this.bt_Get);
            this.Controls.Add(this.tb_link);
            this.Name = "Bai1";
            this.Text = "Bài 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_link;
        private System.Windows.Forms.Button bt_Get;
        private System.Windows.Forms.Button bt_Exit;
        private System.Windows.Forms.RichTextBox rb_Content;
    }
}