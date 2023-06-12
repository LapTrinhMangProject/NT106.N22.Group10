namespace Forms
{
    partial class LibraryVideo
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
            this.listNameListbox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listNameListbox
            // 
            this.listNameListbox.FormattingEnabled = true;
            this.listNameListbox.Location = new System.Drawing.Point(12, 12);
            this.listNameListbox.Name = "listNameListbox";
            this.listNameListbox.Size = new System.Drawing.Size(562, 264);
            this.listNameListbox.TabIndex = 0;
            // 
            // LibraryVideo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 632);
            this.Controls.Add(this.listNameListbox);
            this.Name = "LibraryVideo";
            this.Text = "LibraryVideo";
            this.Load += new System.EventHandler(this.LibraryVideo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listNameListbox;
    }
}