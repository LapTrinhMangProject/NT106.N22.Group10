namespace Forms
{
    partial class League_form
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
            this.list_name_leagues = new System.Windows.Forms.ListBox();
            this.name_find_textbox = new System.Windows.Forms.TextBox();
            this.find_leagues_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // list_name_leagues
            // 
            this.list_name_leagues.FormattingEnabled = true;
            this.list_name_leagues.ItemHeight = 16;
            this.list_name_leagues.Location = new System.Drawing.Point(20, 15);
            this.list_name_leagues.Name = "list_name_leagues";
            this.list_name_leagues.Size = new System.Drawing.Size(736, 308);
            this.list_name_leagues.TabIndex = 0;
            // 
            // name_find_textbox
            // 
            this.name_find_textbox.Location = new System.Drawing.Point(289, 355);
            this.name_find_textbox.Name = "name_find_textbox";
            this.name_find_textbox.Size = new System.Drawing.Size(240, 22);
            this.name_find_textbox.TabIndex = 1;
            // 
            // find_leagues_button
            // 
            this.find_leagues_button.Location = new System.Drawing.Point(535, 353);
            this.find_leagues_button.Name = "find_leagues_button";
            this.find_leagues_button.Size = new System.Drawing.Size(117, 35);
            this.find_leagues_button.TabIndex = 2;
            this.find_leagues_button.Text = "Find";
            this.find_leagues_button.UseVisualStyleBackColor = true;
            this.find_leagues_button.Click += new System.EventHandler(this.find_leagues_button_Click);
            // 
            // League_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.find_leagues_button);
            this.Controls.Add(this.name_find_textbox);
            this.Controls.Add(this.list_name_leagues);
            this.Name = "League_form";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox list_name_leagues;
        private System.Windows.Forms.TextBox name_find_textbox;
        private System.Windows.Forms.Button find_leagues_button;
    }
}

