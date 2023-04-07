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
using System.Threading;

namespace Client
{
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
        }
        IPEndPoint client_ip_port;
        Socket client_socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        bool skip = false;

        private void Form1_Load(object sender, EventArgs e)
        {
            bt_Send.Enabled = false;
        }
        void Establish_Connection()
        {
            Thread thread1 = new Thread(Client_listener);
            thread1.IsBackground = true;
            thread1.Start();
            bt_Connect.Text = "Connected";
            bt_Connect.Enabled = false;
        }
        void Client_listener()
        {
            while (true)
            {
                byte[] bytes_from_sever = new byte[256];
                try
                {
                    client_socket.Receive(bytes_from_sever);
                }
                catch (SocketException)
                {
                    MessageBox.Show("Sever da dong ket noi", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    bt_Connect.Invoke(new MethodInvoker(delegate
                    {
                        bt_Connect.Text = "Connect";
                        bt_Connect.Enabled = true;
                    }));
                    bt_Send.Invoke(new MethodInvoker(delegate
                    {
                        bt_Send.Enabled = false;
                    }));
                    CancellationTokenSource cts = new CancellationTokenSource();
                    cts.Cancel();

                    return;

                }
                string string_converted_from_bytes = Encoding.ASCII.GetString(bytes_from_sever);
                lstChatClient.Invoke(new MethodInvoker(delegate
                {
                    lstChatClient.Items.Add("Message from Sever: " + string_converted_from_bytes);
                }));
            }
        }
        void send_bytes(string Username, string text = null)
        {
            byte[] bytes_converted_from_string = new byte[256];
            bytes_converted_from_string = Encoding.UTF8.GetBytes(Username + ": " + text);
            client_socket.Send(bytes_converted_from_string);
        }

        private void bt_Connect_Click(object sender, EventArgs e)
        {
            if (!skip)
            {
                try
                {
                    client_ip_port = new IPEndPoint(IPAddress.Parse(tb_IPCL.Text), Int32.Parse(tb_PortCL.Text));
                    client_socket.Bind(client_ip_port);
                }
                catch (SocketException)
                {
                    MessageBox.Show("Dia chi ip khong ton tai trong local, vui long kiem tra lai!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                skip = true;
            }
            try
            {
                client_socket.Connect(IPAddress.Parse(tb_IPSV.Text), Int32.Parse(tb_PortSV.Text));
            }
            catch (FormatException)
            {
                MessageBox.Show("IP Server khong dung, vui long kiem tra lai!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            catch (SocketException)
            {
                MessageBox.Show("Server IP khong ton tai, vui long kiem tra lai!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Establish_Connection();
            bt_Send.Enabled = true;
            send_bytes(tb_Username.Text);
        }

        private void bt_Send_Click(object sender, EventArgs e)
        {
            send_bytes(tb_Username.Text, tb_Send.Text);
            lstChatClient.Items.Add(tb_Send.Text);
            tb_Send.Clear();
        }

        private void bt_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
