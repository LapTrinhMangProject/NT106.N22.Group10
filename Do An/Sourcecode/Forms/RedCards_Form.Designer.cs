namespace Forms
{
    partial class RedCards_Form
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
            this.redcards_listbox = new System.Windows.Forms.ListBox();
            this.image_player = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.image_player)).BeginInit();
            this.SuspendLayout();
            // 
            // redcards_listbox
            // 
            this.redcards_listbox.FormattingEnabled = true;
            this.redcards_listbox.ItemHeight = 20;
            this.redcards_listbox.Location = new System.Drawing.Point(23, 25);
            this.redcards_listbox.Name = "redcards_listbox";
            this.redcards_listbox.Size = new System.Drawing.Size(234, 244);
            this.redcards_listbox.TabIndex = 0;
            // 
            // image_player
            // 
            this.image_player.Location = new System.Drawing.Point(23, 276);
            this.image_player.Name = "image_player";
            this.image_player.Size = new System.Drawing.Size(234, 162);
            this.image_player.TabIndex = 1;
            this.image_player.TabStop = false;
            // 
            // RedCards_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 450);
            this.Controls.Add(this.image_player);
            this.Controls.Add(this.redcards_listbox);
            this.Name = "RedCards_Form";
            this.Text = "RedCards_Form";
            this.Load += new System.EventHandler(this.RedCards_Form_Load);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.RedCards_Form_MouseDoubleClick);
            ((System.ComponentModel.ISupportInitialize)(this.image_player)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox redcards_listbox;
        private System.Windows.Forms.PictureBox image_player;
    }
}