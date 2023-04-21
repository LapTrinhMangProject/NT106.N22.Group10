namespace Another_API
{
    partial class Weather
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
            this.view_data_weather = new System.Windows.Forms.ListBox();
            this.querry = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(34, 342);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(229, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Nhập giá trị cần tra cứu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // view_data_weather
            // 
            this.view_data_weather.FormattingEnabled = true;
            this.view_data_weather.ItemHeight = 16;
            this.view_data_weather.Location = new System.Drawing.Point(23, 12);
            this.view_data_weather.Name = "view_data_weather";
            this.view_data_weather.Size = new System.Drawing.Size(960, 308);
            this.view_data_weather.TabIndex = 1;
            // 
            // querry
            // 
            this.querry.Location = new System.Drawing.Point(269, 343);
            this.querry.Name = "querry";
            this.querry.Size = new System.Drawing.Size(224, 22);
            this.querry.TabIndex = 2;
            this.querry.TextChanged += new System.EventHandler(this.querry_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(276, 377);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(391, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "giá trị có thể nhận bao gồm tọa độ, khu vực, hoặc địa chỉ IP public";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Weather
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.querry);
            this.Controls.Add(this.view_data_weather);
            this.Controls.Add(this.button1);
            this.Name = "Weather";
            this.Text = "Weather";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox view_data_weather;
        private System.Windows.Forms.TextBox querry;
        private System.Windows.Forms.Label label1;
    }
}

