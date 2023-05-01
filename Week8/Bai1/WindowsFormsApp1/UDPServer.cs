using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class UDPServer : Form
    {
        private UdpClient udpServer;
        public UDPServer()
        {
            InitializeComponent();
        }

        private void ListenButton_Click(object sender, EventArgs e)
        {
            int port = int.Parse(PortTB.Text);
            udpServer = new UdpClient(int.Parse(PortTB.Text));
            udpServer.BeginReceive(new AsyncCallback(ReceiveCallback), null);
            display.AppendText("Port "+ port + " connected" + Environment.NewLine);
        }
        private void ReceiveCallback(IAsyncResult ar)
        {
            IPEndPoint remoteEP = new IPEndPoint(IPAddress.Any, 0);
            byte[] receivedBytes = udpServer.EndReceive(ar, ref remoteEP);
            string receivedString = Encoding.ASCII.GetString(receivedBytes);
            this.Invoke(new Action(() => display.AppendText(remoteEP + ": "+ receivedString + Environment.NewLine)));
            udpServer.BeginReceive(new AsyncCallback(ReceiveCallback), null);
        }


    }
}
