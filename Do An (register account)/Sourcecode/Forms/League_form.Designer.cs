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
            this.selecte_leagues_combobox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // selecte_leagues_combobox
            // 
            this.selecte_leagues_combobox.FormattingEnabled = true;
            this.selecte_leagues_combobox.Location = new System.Drawing.Point(32, 88);
            this.selecte_leagues_combobox.Name = "selecte_leagues_combobox";
            this.selecte_leagues_combobox.Size = new System.Drawing.Size(161, 21);
            this.selecte_leagues_combobox.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(63, 129);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 40);
            this.button1.TabIndex = 4;
            this.button1.Text = "Load";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // League_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(226, 225);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.selecte_leagues_combobox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "League_form";
            this.Text = "Leagues";
            this.Load += new System.EventHandler(this.League_form_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox selecte_leagues_combobox;
        private System.Windows.Forms.Button button1;
    }
}

