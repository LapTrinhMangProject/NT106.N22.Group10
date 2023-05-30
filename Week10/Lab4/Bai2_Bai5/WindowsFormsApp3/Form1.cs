using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;

using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string args = textBox1.Text ; // textBox1 contains the URI of the resource to retrieve.
            if (args == null || args.Length == 0)
            {
                MessageBox.Show("Please specify the URI of the resource to retrieve.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit the method early, since there is no URI to retrieve.
            }
            string args1 = textBox2.Text;
            if (args1 == null || args1.Length == 0)
            {
                MessageBox.Show("Please specify the absolute path to download the HTML file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit the method early, since there is no absoulute path to download.
            }
            using (WebClient client = new WebClient())
            {

                // Add a user agent header in case the
                // requested URI contains a query.

                client.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)");

                using (Stream data = client.OpenRead(args))
                using (StreamReader reader = new StreamReader(data))
                {
                    string s = reader.ReadToEnd();
                    richTextBox1.AppendText(s);
                }
                string localPath = textBox2.Text;
                client.DownloadFile(args, localPath);
            }
        }
    }
 }

