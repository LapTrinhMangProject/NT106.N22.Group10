using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Bai1
{
    public partial class UDPClient : Form
    {
        private UdpClient udpClient;

        public UDPClient()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            udpClient = new UdpClient();
            byte[] sendBytes = Encoding.ASCII.GetBytes(display.Text);
            string ip = IPremote.Text;
            int port = int.Parse(Port.Text);
            udpClient.Send(sendBytes, sendBytes.Length, ip, port);
            udpClient.Close();
        }

        private void UDPClient_Load(object sender, EventArgs e)
        {

        }
    }
}
