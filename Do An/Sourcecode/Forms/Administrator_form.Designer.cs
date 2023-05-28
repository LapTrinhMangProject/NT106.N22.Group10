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
            this.SuspendLayout();
            // 
            // active_leagues_listbox
            // 
            this.active_leagues_listbox.FormattingEnabled = true;
            this.active_leagues_listbox.Location = new System.Drawing.Point(12, 12);
            this.active_leagues_listbox.Name = "active_leagues_listbox";
            this.active_leagues_listbox.Size = new System.Drawing.Size(207, 134);
            this.active_leagues_listbox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Giải đấu hiện hành";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(305, 208);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(160, 35);
            this.button2.TabIndex = 4;
            this.button2.Text = "Xóa giải đấu";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // add_league_button
            // 
            this.add_league_button.Location = new System.Drawing.Point(305, 167);
            this.add_league_button.Name = "add_league_button";
            this.add_league_button.Size = new System.Drawing.Size(160, 35);
            this.add_league_button.TabIndex = 5;
            this.add_league_button.Text = "Thêm một giải đấu mới";
            this.add_league_button.UseVisualStyleBackColor = true;
            this.add_league_button.Click += new System.EventHandler(this.add_league_button_Click);
            // 
            // Administrator_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 321);
            this.Controls.Add(this.add_league_button);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.active_leagues_listbox);
            this.Margin = new System.Windows.Forms.Padding(2);
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
    }
}