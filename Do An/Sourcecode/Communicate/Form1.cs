using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Communicate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static Client client;

        private void client_button_Click(object sender, EventArgs e)
        {
            client.Show();
        }

        private void server_button_Click(object sender, EventArgs e)
        {
            new Server_form().Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Client._ipAddress.Add(IPAddress.Parse("20.24.132.202"));
            Client._ipAddress.Add(IPAddress.Parse("42.116.94.154"));
            client = new Client();
        }
        static public void ReloadClientForm()
        {
            client = new Client();
        }
    }
}
