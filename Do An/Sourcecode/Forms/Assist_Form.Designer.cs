namespace Forms
{
    partial class Assist_Form
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
            this.assist_listbox = new System.Windows.Forms.ListBox();
            this.image_player = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.image_player)).BeginInit();
            this.SuspendLayout();
            // 
            // assist_listbox
            // 
            this.assist_listbox.FormattingEnabled = true;
            this.assist_listbox.ItemHeight = 20;
            this.assist_listbox.Location = new System.Drawing.Point(23, 12);
            this.assist_listbox.Name = "assist_listbox";
            this.assist_listbox.Size = new System.Drawing.Size(226, 244);
            this.assist_listbox.TabIndex = 0;
            this.assist_listbox.SelectedIndexChanged += new System.EventHandler(this.assist_listbox_SelectedIndexChanged);
            this.assist_listbox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.assist_listbox_MouseDoubleClick);
            // 
            // image_player
            // 
            this.image_player.Location = new System.Drawing.Point(23, 263);
            this.image_player.Name = "image_player";
            this.image_player.Size = new System.Drawing.Size(226, 175);
            this.image_player.TabIndex = 1;
            this.image_player.TabStop = false;
            // 
            // Assist_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 450);
            this.Controls.Add(this.image_player);
            this.Controls.Add(this.assist_listbox);
            this.Name = "Assist_Form";
            this.Text = "Assist_Form";
            this.Load += new System.EventHandler(this.Assist_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.image_player)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox assist_listbox;
        private System.Windows.Forms.PictureBox image_player;
    }
}