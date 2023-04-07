using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TCPServer serverForm = new TCPServer();
            serverForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TCPClient clientForm = new TCPClient();
            clientForm.Show();
        }
    }
}
