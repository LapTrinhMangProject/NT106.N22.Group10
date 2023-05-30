using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            WebRequest request = WebRequest.Create("https://reqres.in/api/users?page=1");   
            WebResponse response = request.GetResponse();
            Stream stream = response.GetResponseStream();
            StreamReader reader = new StreamReader(stream); 
            string data = reader.ReadToEnd();
            FileStream file = new FileStream("test.txt",FileMode.Create,FileAccess.Write);
            StreamWriter writer = new StreamWriter(file);
            writer.Write(data);
            writer.Flush();
            writer.Close();
            file.Close();
            MessageBox.Show("Done");
        }
    }
}
