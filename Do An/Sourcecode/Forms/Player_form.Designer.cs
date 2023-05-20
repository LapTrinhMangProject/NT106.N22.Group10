namespace Forms
{
    partial class Player_form
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
            this.list_player_listbox = new System.Windows.Forms.ListBox();
            this.find_textbox = new System.Windows.Forms.TextBox();
            this.find_player_label = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.infor_player_listbox = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.statistic_1_listbox = new System.Windows.Forms.ListBox();
            this.statistic2_list_box = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(651, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(641, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Danh sách cầu thủ ";
            // 
            // list_player_listbox
            // 
            this.list_player_listbox.FormattingEnabled = true;
            this.list_player_listbox.ItemHeight = 16;
            this.list_player_listbox.Location = new System.Drawing.Point(602, 37);
            this.list_player_listbox.Name = "list_player_listbox";
            this.list_player_listbox.Size = new System.Drawing.Size(186, 308);
            this.list_player_listbox.TabIndex = 2;
            this.list_player_listbox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.list_player_listbox_MouseDoubleClick);
            // 
            // find_textbox
            // 
            this.find_textbox.Location = new System.Drawing.Point(602, 377);
            this.find_textbox.Name = "find_textbox";
            this.find_textbox.Size = new System.Drawing.Size(186, 22);
            this.find_textbox.TabIndex = 3;
            this.find_textbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // find_player_label
            // 
            this.find_player_label.AutoSize = true;
            this.find_player_label.Location = new System.Drawing.Point(611, 358);
            this.find_player_label.Name = "find_player_label";
            this.find_player_label.Size = new System.Drawing.Size(78, 16);
            this.find_player_label.TabIndex = 4;
            this.find_player_label.Text = "Tìm cầu thủ ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(244, 180);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Hình đại diện";
            // 
            // infor_player_listbox
            // 
            this.infor_player_listbox.FormattingEnabled = true;
            this.infor_player_listbox.ItemHeight = 16;
            this.infor_player_listbox.Location = new System.Drawing.Point(280, 47);
            this.infor_player_listbox.Name = "infor_player_listbox";
            this.infor_player_listbox.Size = new System.Drawing.Size(316, 180);
            this.infor_player_listbox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(384, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Thông tin cơ bản";
            // 
            // statistic_1_listbox
            // 
            this.statistic_1_listbox.FormattingEnabled = true;
            this.statistic_1_listbox.ItemHeight = 16;
            this.statistic_1_listbox.Location = new System.Drawing.Point(12, 258);
            this.statistic_1_listbox.Name = "statistic_1_listbox";
            this.statistic_1_listbox.Size = new System.Drawing.Size(244, 180);
            this.statistic_1_listbox.TabIndex = 9;
            // 
            // statistic2_list_box
            // 
            this.statistic2_list_box.FormattingEnabled = true;
            this.statistic2_list_box.ItemHeight = 16;
            this.statistic2_list_box.Location = new System.Drawing.Point(358, 258);
            this.statistic2_list_box.Name = "statistic2_list_box";
            this.statistic2_list_box.Size = new System.Drawing.Size(238, 180);
            this.statistic2_list_box.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(258, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Thông tin chi tiết";
            // 
            // Player_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.statistic2_list_box);
            this.Controls.Add(this.statistic_1_listbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.infor_player_listbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.find_player_label);
            this.Controls.Add(this.find_textbox);
            this.Controls.Add(this.list_player_listbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Player_form";
            this.Text = "Player_form";
            this.Load += new System.EventHandler(this.Player_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox list_player_listbox;
        private System.Windows.Forms.TextBox find_textbox;
        private System.Windows.Forms.Label find_player_label;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox infor_player_listbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox statistic_1_listbox;
        private System.Windows.Forms.ListBox statistic2_list_box;
        private System.Windows.Forms.Label label5;
    }
}