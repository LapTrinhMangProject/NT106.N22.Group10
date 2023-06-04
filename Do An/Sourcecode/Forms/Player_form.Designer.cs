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
            this.label1.Location = new System.Drawing.Point(488, 133);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(449, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Danh sách cầu thủ ";
            // 
            // list_player_listbox
            // 
            this.list_player_listbox.FormattingEnabled = true;
            this.list_player_listbox.Location = new System.Drawing.Point(452, 30);
            this.list_player_listbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.list_player_listbox.Name = "list_player_listbox";
            this.list_player_listbox.Size = new System.Drawing.Size(140, 251);
            this.list_player_listbox.TabIndex = 2;
            this.list_player_listbox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.list_player_listbox_MouseDoubleClick);
            // 
            // find_textbox
            // 
            this.find_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.find_textbox.Location = new System.Drawing.Point(452, 306);
            this.find_textbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.find_textbox.Name = "find_textbox";
            this.find_textbox.Size = new System.Drawing.Size(140, 26);
            this.find_textbox.TabIndex = 3;
            this.find_textbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // find_player_label
            // 
            this.find_player_label.AutoSize = true;
            this.find_player_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.find_player_label.Location = new System.Drawing.Point(452, 287);
            this.find_player_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.find_player_label.Name = "find_player_label";
            this.find_player_label.Size = new System.Drawing.Size(86, 17);
            this.find_player_label.TabIndex = 4;
            this.find_player_label.Text = "Tìm cầu thủ ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(9, 38);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(183, 146);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(57, 19);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Hình đại diện";
            // 
            // infor_player_listbox
            // 
            this.infor_player_listbox.FormattingEnabled = true;
            this.infor_player_listbox.Location = new System.Drawing.Point(210, 38);
            this.infor_player_listbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.infor_player_listbox.Name = "infor_player_listbox";
            this.infor_player_listbox.Size = new System.Drawing.Size(238, 147);
            this.infor_player_listbox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(277, 19);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Thông tin cơ bản";
            // 
            // statistic_1_listbox
            // 
            this.statistic_1_listbox.FormattingEnabled = true;
            this.statistic_1_listbox.Location = new System.Drawing.Point(9, 210);
            this.statistic_1_listbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.statistic_1_listbox.Name = "statistic_1_listbox";
            this.statistic_1_listbox.Size = new System.Drawing.Size(184, 147);
            this.statistic_1_listbox.TabIndex = 9;
            // 
            // statistic2_list_box
            // 
            this.statistic2_list_box.FormattingEnabled = true;
            this.statistic2_list_box.Location = new System.Drawing.Point(268, 210);
            this.statistic2_list_box.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.statistic2_list_box.Name = "statistic2_list_box";
            this.statistic2_list_box.Size = new System.Drawing.Size(180, 147);
            this.statistic2_list_box.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(176, 191);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Thông tin chi tiết";
            // 
            // Player_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(600, 366);
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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