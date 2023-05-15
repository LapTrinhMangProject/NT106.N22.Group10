namespace Forms
{
    partial class Topscore_form
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
            this.topscore_listbox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.assist_listbox = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.redcard_listbox = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.yellowcard_listbox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // topscore_listbox
            // 
            this.topscore_listbox.FormattingEnabled = true;
            this.topscore_listbox.ItemHeight = 16;
            this.topscore_listbox.Location = new System.Drawing.Point(16, 52);
            this.topscore_listbox.Margin = new System.Windows.Forms.Padding(4);
            this.topscore_listbox.Name = "topscore_listbox";
            this.topscore_listbox.Size = new System.Drawing.Size(199, 484);
            this.topscore_listbox.TabIndex = 0;
            this.topscore_listbox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.topscore_listbox_MouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Goal";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Player";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(316, 32);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Player";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(252, 32);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Assist";
            // 
            // assist_listbox
            // 
            this.assist_listbox.FormattingEnabled = true;
            this.assist_listbox.ItemHeight = 16;
            this.assist_listbox.Location = new System.Drawing.Point(252, 52);
            this.assist_listbox.Margin = new System.Windows.Forms.Padding(4);
            this.assist_listbox.Name = "assist_listbox";
            this.assist_listbox.Size = new System.Drawing.Size(199, 484);
            this.assist_listbox.TabIndex = 3;
            this.assist_listbox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.assist_listbox_MouseDoubleClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(575, 32);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Player";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(497, 32);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Red cards";
            // 
            // redcard_listbox
            // 
            this.redcard_listbox.FormattingEnabled = true;
            this.redcard_listbox.ItemHeight = 16;
            this.redcard_listbox.Location = new System.Drawing.Point(497, 52);
            this.redcard_listbox.Margin = new System.Windows.Forms.Padding(4);
            this.redcard_listbox.Name = "redcard_listbox";
            this.redcard_listbox.Size = new System.Drawing.Size(199, 484);
            this.redcard_listbox.TabIndex = 6;
            this.redcard_listbox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.redcard_listbox_MouseDoubleClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(843, 32);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "Player";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(756, 32);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 16);
            this.label8.TabIndex = 10;
            this.label8.Text = "Yellow Card";
            // 
            // yellowcard_listbox
            // 
            this.yellowcard_listbox.FormattingEnabled = true;
            this.yellowcard_listbox.ItemHeight = 16;
            this.yellowcard_listbox.Location = new System.Drawing.Point(756, 52);
            this.yellowcard_listbox.Margin = new System.Windows.Forms.Padding(4);
            this.yellowcard_listbox.Name = "yellowcard_listbox";
            this.yellowcard_listbox.Size = new System.Drawing.Size(199, 484);
            this.yellowcard_listbox.TabIndex = 9;
            this.yellowcard_listbox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.yellowcard_listbox_MouseDoubleClick);
            // 
            // Topscore_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 554);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.yellowcard_listbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.redcard_listbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.assist_listbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.topscore_listbox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Topscore_form";
            this.Text = "Topscore";
            this.Load += new System.EventHandler(this.Topscore_form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox topscore_listbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox assist_listbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox redcard_listbox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox yellowcard_listbox;
    }
}