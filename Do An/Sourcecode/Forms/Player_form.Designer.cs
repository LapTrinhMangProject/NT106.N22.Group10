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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.find_player_button = new System.Windows.Forms.Button();
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
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(548, 363);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 3;
            // 
            // find_player_button
            // 
            this.find_player_button.Location = new System.Drawing.Point(654, 363);
            this.find_player_button.Name = "find_player_button";
            this.find_player_button.Size = new System.Drawing.Size(80, 23);
            this.find_player_button.TabIndex = 4;
            this.find_player_button.Text = "Tìm ";
            this.find_player_button.UseVisualStyleBackColor = true;
            // 
            // Player_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.find_player_button);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.list_player_listbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Player_form";
            this.Text = "Player_form";
            this.Load += new System.EventHandler(this.Player_form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox list_player_listbox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button find_player_button;
    }
}