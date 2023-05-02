namespace telnet_TCP
{
    partial class Form1
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
            this.listViewCommand = new System.Windows.Forms.ListView();
            this.bt_Listen = new System.Windows.Forms.Button();
            this.bt_Stop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewCommand
            // 
            this.listViewCommand.HideSelection = false;
            this.listViewCommand.Location = new System.Drawing.Point(12, 12);
            this.listViewCommand.Name = "listViewCommand";
            this.listViewCommand.Size = new System.Drawing.Size(535, 426);
            this.listViewCommand.TabIndex = 2;
            this.listViewCommand.UseCompatibleStateImageBehavior = false;
            this.listViewCommand.View = System.Windows.Forms.View.List;
            // 
            // bt_Listen
            // 
            this.bt_Listen.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Listen.Location = new System.Drawing.Point(616, 139);
            this.bt_Listen.Name = "bt_Listen";
            this.bt_Listen.Size = new System.Drawing.Size(111, 48);
            this.bt_Listen.TabIndex = 3;
            this.bt_Listen.Text = "Listen";
            this.bt_Listen.UseVisualStyleBackColor = true;
            this.bt_Listen.Click += new System.EventHandler(this.bt_Listen_Click);
            // 
            // bt_Stop
            // 
            this.bt_Stop.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Stop.Location = new System.Drawing.Point(603, 221);
            this.bt_Stop.Name = "bt_Stop";
            this.bt_Stop.Size = new System.Drawing.Size(140, 48);
            this.bt_Stop.TabIndex = 4;
            this.bt_Stop.Text = "Stop listening";
            this.bt_Stop.UseVisualStyleBackColor = true;
            this.bt_Stop.Click += new System.EventHandler(this.bt_Stop_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_Stop);
            this.Controls.Add(this.bt_Listen);
            this.Controls.Add(this.listViewCommand);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewCommand;
        private System.Windows.Forms.Button bt_Listen;
        private System.Windows.Forms.Button bt_Stop;
    }
}

