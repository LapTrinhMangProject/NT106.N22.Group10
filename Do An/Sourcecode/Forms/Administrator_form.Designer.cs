namespace Forms
{
    partial class Administrator_form
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
            this.active_leagues_listbox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.add_league_button = new System.Windows.Forms.Button();
            this.list_league_api_support = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.countrycode_combobox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.find_textbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // active_leagues_listbox
            // 
            this.active_leagues_listbox.FormattingEnabled = true;
            this.active_leagues_listbox.ItemHeight = 16;
            this.active_leagues_listbox.Location = new System.Drawing.Point(16, 15);
            this.active_leagues_listbox.Margin = new System.Windows.Forms.Padding(4);
            this.active_leagues_listbox.Name = "active_leagues_listbox";
            this.active_leagues_listbox.Size = new System.Drawing.Size(275, 164);
            this.active_leagues_listbox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 183);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Giải đấu hiện hành";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(429, 327);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(213, 43);
            this.button2.TabIndex = 4;
            this.button2.Text = "Xóa giải đấu";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // add_league_button
            // 
            this.add_league_button.Location = new System.Drawing.Point(429, 276);
            this.add_league_button.Margin = new System.Windows.Forms.Padding(4);
            this.add_league_button.Name = "add_league_button";
            this.add_league_button.Size = new System.Drawing.Size(213, 43);
            this.add_league_button.TabIndex = 5;
            this.add_league_button.Text = "Thêm một giải đấu mới";
            this.add_league_button.UseVisualStyleBackColor = true;
            this.add_league_button.Click += new System.EventHandler(this.add_league_button_Click);
            // 
            // list_league_api_support
            // 
            this.list_league_api_support.FormattingEnabled = true;
            this.list_league_api_support.ItemHeight = 16;
            this.list_league_api_support.Location = new System.Drawing.Point(367, 15);
            this.list_league_api_support.Margin = new System.Windows.Forms.Padding(4);
            this.list_league_api_support.Name = "list_league_api_support";
            this.list_league_api_support.Size = new System.Drawing.Size(275, 164);
            this.list_league_api_support.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(443, 183);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Giải đấu có thể thêm vào";
            // 
            // countrycode_combobox
            // 
            this.countrycode_combobox.FormattingEnabled = true;
            this.countrycode_combobox.Location = new System.Drawing.Point(533, 232);
            this.countrycode_combobox.Name = "countrycode_combobox";
            this.countrycode_combobox.Size = new System.Drawing.Size(110, 24);
            this.countrycode_combobox.TabIndex = 8;
            this.countrycode_combobox.SelectedIndexChanged += new System.EventHandler(this.countrycode_combobox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(565, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Khu vực";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(361, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Tìm";
            // 
            // find_textbox
            // 
            this.find_textbox.Location = new System.Drawing.Point(397, 232);
            this.find_textbox.Name = "find_textbox";
            this.find_textbox.Size = new System.Drawing.Size(130, 22);
            this.find_textbox.TabIndex = 11;
            this.find_textbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Administrator_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 395);
            this.Controls.Add(this.find_textbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.countrycode_combobox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.list_league_api_support);
            this.Controls.Add(this.add_league_button);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.active_leagues_listbox);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Administrator_form";
            this.Text = "Administrator";
            this.Load += new System.EventHandler(this.Administrator_form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox active_leagues_listbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button add_league_button;
        private System.Windows.Forms.ListBox list_league_api_support;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox countrycode_combobox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox find_textbox;
    }
}