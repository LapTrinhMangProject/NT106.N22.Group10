
namespace async_api
{
    partial class Form3
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
            this.rich_tb = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Search = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rich_tb
            // 
            this.rich_tb.Location = new System.Drawing.Point(29, 93);
            this.rich_tb.Name = "rich_tb";
            this.rich_tb.Size = new System.Drawing.Size(500, 247);
            this.rich_tb.TabIndex = 0;
            this.rich_tb.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Danh sách các videos thịnh thành trên youtube";
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(442, 61);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(75, 23);
            this.Search.TabIndex = 2;
            this.Search.Text = "Tìm kiếm";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 343);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(332, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Lưu ý phải cài đặt Google.apis.youtube.v3 package";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 383);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rich_tb);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rich_tb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Label label2;
    }
}