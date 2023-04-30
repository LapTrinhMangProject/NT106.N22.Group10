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
        private void UDPServer_Load(object sender, EventArgs e)
        {
            udpServer = new UdpClient(8080);
            udpServer.BeginReceive(new AsyncCallback(ReceiveCallback), null);
        }
        private void ReceiveCallback(IAsyncResult ar)
        {
            IPEndPoint remoteEP = new IPEndPoint(IPAddress.Any, 0);
            byte[] receivedBytes = udpServer.EndReceive(ar, ref remoteEP);
            string receivedString = Encoding.ASCII.GetString(receivedBytes);
            this.Invoke(new Action(() => display.AppendText(receivedString + Environment.NewLine)));
            udpServer.BeginReceive(new AsyncCallback(ReceiveCallback), null);
        }
    }
}
