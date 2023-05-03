using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai2
{
    public partial class Bai2_form : Form
    {
        private Socket listenerSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        private bool isListening = false;
        public Bai2_form()
        {
            InitializeComponent();
        }

        private void bt_Listen_Click(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            Thread serverThread = new Thread(new ThreadStart(StartUnsafeThread));
            serverThread.Start();
            bt_Listen.Enabled = false;
        }
        void StartUnsafeThread()
        {
            int bytesReceived = 0;
            byte[] recv = new byte[1];
            Socket clientSocket;
            IPEndPoint IPServer = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8060);
            listenerSocket.Bind(IPServer);
            listenerSocket.Listen(1);
            clientSocket = listenerSocket.Accept();
            isListening = true;
            MessageBox.Show("Telnet is running on 127.0.0.1:8060", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            while (isListening)
            {
                if (!clientSocket.Connected)
                    break;
                string text = "";
                do
                {
                    bytesReceived = clientSocket.Receive(recv);
                    text += Encoding.ASCII.GetString(recv);
                } while ( bytesReceived > 0 && text[text.Length - 1] != '\n');
                listViewCommand.Items.Add(new ListViewItem(text));
            }
        }

        private void bt_Stop_Click(object sender, EventArgs e) // server vẫn nhận một thông điệp trước khi hoàn toàn ngừng listen (em không rõ lí do lắm, mong cô thông cảm ạ!)
        {
            isListening = false;
            listenerSocket.Close();
            listViewCommand.Items.Add(new ListViewItem("Telnet stopped"));
            bt_Stop.Enabled = false;
        }

        private void Bai2_form_Load(object sender, EventArgs e)
        {

        }
    }
}
