using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SuperSimpleTcp;


namespace Server
{
    public partial class TCPClient : Form
    {
        public TCPClient()
        {
            InitializeComponent();
        }
        SimpleTcpClient client;


        private void btnSend_Click(object sender, EventArgs e)
        {
            if (client.IsConnected)
            {
                if(!string.IsNullOrEmpty(txtMessage.Text))
                {
                    client.Send(txtMessage.Text);
                    txtInfo.Text += $"Me: {txtMessage.Text}{Environment.NewLine}";
                    txtMessage.Text = string.Empty;
                }
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                client.Connect();
                btnSend.Enabled = true;
                btnConnect.Enabled = false;
            }
            catch(Exception ex)
            { 
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void TCPClient_Load(object sender, EventArgs e)
        {
            client = new SimpleTcpClient(txtIP.Text);
            client.Events.Connected += Events_Connected;
            client.Events.DataReceived += Events_DataReceived;
            client.Events.Disconnected += Events_Disconnected;
            btnSend.Enabled = false;
        }

        private void Events_Disconnected(object sender, ConnectionEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                txtInfo.Text += $"Server disconnected.{Environment.NewLine}";
            });
        }

        private void Events_DataReceived(object sender, DataReceivedEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                txtInfo.Text += $"Server: {Encoding.UTF8.GetString(e.Data.ToArray())}{Environment.NewLine}";
            });
        }

        private void Events_Connected(object sender, ConnectionEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                txtInfo.Text += $"Server connected.{Environment.NewLine}";
            });
        }
    }
}
