namespace GetAPI
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
            this.lv_Todos = new System.Windows.Forms.ListView();
            this.bt_GetAPI = new System.Windows.Forms.Button();
            this.bt_Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lv_Todos
            // 
            this.lv_Todos.HideSelection = false;
            this.lv_Todos.Location = new System.Drawing.Point(12, 126);
            this.lv_Todos.Name = "lv_Todos";
            this.lv_Todos.Size = new System.Drawing.Size(776, 312);
            this.lv_Todos.TabIndex = 0;
            this.lv_Todos.UseCompatibleStateImageBehavior = false;
            this.lv_Todos.View = System.Windows.Forms.View.List;
            // 
            // bt_GetAPI
            // 
            this.bt_GetAPI.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_GetAPI.Location = new System.Drawing.Point(12, 52);
            this.bt_GetAPI.Name = "bt_GetAPI";
            this.bt_GetAPI.Size = new System.Drawing.Size(139, 56);
            this.bt_GetAPI.TabIndex = 1;
            this.bt_GetAPI.Text = "Get API";
            this.bt_GetAPI.UseVisualStyleBackColor = true;
            this.bt_GetAPI.Click += new System.EventHandler(this.bt_GetAPI_Click);
            // 
            // bt_Exit
            // 
            this.bt_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Exit.Location = new System.Drawing.Point(649, 52);
            this.bt_Exit.Name = "bt_Exit";
            this.bt_Exit.Size = new System.Drawing.Size(139, 56);
            this.bt_Exit.TabIndex = 2;
            this.bt_Exit.Text = "Exit";
            this.bt_Exit.UseVisualStyleBackColor = true;
            this.bt_Exit.Click += new System.EventHandler(this.bt_Exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_Exit);
            this.Controls.Add(this.bt_GetAPI);
            this.Controls.Add(this.lv_Todos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lv_Todos;
        private System.Windows.Forms.Button bt_GetAPI;
        private System.Windows.Forms.Button bt_Exit;
    }
}

