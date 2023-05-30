using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace Lab4_Bai6
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            webBrowser1.ScriptErrorsSuppressed = true; // Ignore script error

            webBrowser1.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(webBrowser1_DocumentCompleted);
            webBrowser1.ProgressChanged += new WebBrowserProgressChangedEventHandler(webBrowser1_ProgressChanged);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string url = txtUrl.Text; // Get the url from the textbox
            webBrowser1.Navigate(url); // Display the contents out of the webbrowser
        }
        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            // Reset the progress bar
            progressBar1.Value = 0;
        }
        private void webBrowser1_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
        {
            // Update the progress bar with the current progress
            if (e.MaximumProgress > 0)
            {
                int progress = (int)(e.CurrentProgress * 100 / e.MaximumProgress);
                progressBar1.Minimum = 0;
                progressBar1.Maximum = 100;
                progressBar1.Value = Math.Min(progress, progressBar1.Maximum);
            }
        }
    }
}
