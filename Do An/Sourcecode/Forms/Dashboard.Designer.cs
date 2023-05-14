namespace Forms
{
    partial class Dashboard
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
            this.button1 = new System.Windows.Forms.Button();
            this.find_player_button = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.standing_listbox = new System.Windows.Forms.ListBox();
            this.topscore_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(77, 310);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 19);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // find_player_button
            // 
            this.find_player_button.Location = new System.Drawing.Point(175, 304);
            this.find_player_button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.find_player_button.Name = "find_player_button";
            this.find_player_button.Size = new System.Drawing.Size(118, 31);
            this.find_player_button.TabIndex = 1;
            this.find_player_button.Text = "Danh sách cầu thủ";
            this.find_player_button.UseVisualStyleBackColor = true;
            this.find_player_button.Click += new System.EventHandler(this.find_player_button_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(368, 310);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(56, 19);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(458, 303);
            this.button4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(56, 19);
            this.button4.TabIndex = 3;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // standing_listbox
            // 
            this.standing_listbox.FormattingEnabled = true;
            this.standing_listbox.Location = new System.Drawing.Point(11, 1);
            this.standing_listbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.standing_listbox.Name = "standing_listbox";
            this.standing_listbox.Size = new System.Drawing.Size(273, 277);
            this.standing_listbox.TabIndex = 4;
            // 
            // topscore_button
            // 
            this.topscore_button.Location = new System.Drawing.Point(489, 11);
            this.topscore_button.Margin = new System.Windows.Forms.Padding(2);
            this.topscore_button.Name = "topscore_button";
            this.topscore_button.Size = new System.Drawing.Size(100, 36);
            this.topscore_button.TabIndex = 5;
            this.topscore_button.Text = "Top score";
            this.topscore_button.UseVisualStyleBackColor = true;
            this.topscore_button.Click += new System.EventHandler(this.topscore_button_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 369);
            this.Controls.Add(this.topscore_button);
            this.Controls.Add(this.standing_listbox);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.find_player_button);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button find_player_button;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ListBox standing_listbox;
        private System.Windows.Forms.Button topscore_button;
    }
}