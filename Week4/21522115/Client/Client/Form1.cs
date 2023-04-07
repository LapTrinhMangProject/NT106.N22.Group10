using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Threading;

namespace Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        IPEndPoint client_IP_port;
        Socket client_socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        bool skip = false;
        private void Form1_Load(object sender, EventArgs e)
        {
            send_bt.Enabled = false;
        }
        void Establish_Connection()
        {
            new Thread(
                () =>
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
                            MessageBox.Show("Sever closed", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            connect_bt.Invoke(new MethodInvoker(delegate
                            {
                                connect_bt.Text = "Connect";
                                connect_bt.Enabled = true;
                            }));
                            send_bt.Invoke(new MethodInvoker(delegate
                            {
                                send_bt.Enabled = false;
                            }));
                            CancellationTokenSource cts = new CancellationTokenSource();
                            cts.Cancel();

                            return;

                        }
                        string string_converted_from_bytes = Encoding.ASCII.GetString(bytes_from_sever);
                        chat_lb.Invoke(new MethodInvoker(delegate
                        {
                            chat_lb.Items.Add("Message from Sever: " + string_converted_from_bytes);
                        }));
                    }
                } ) { IsBackground = true }.Start();
            connect_bt.Text = "Connected";
            connect_bt.Enabled = false;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            IPAddress ipAddress;
            if (IPAddress.TryParse(clientIP_tb.Text, out ipAddress))
            {
                // The string was successfully parsed
            }
            else
            {
                // The string could not be parsed as an IP address
                MessageBox.Show("Invalid IP address string: " + clientIP_tb.Text, "Error");
            }
        }

        private void serverIP_tb_TextChanged(object sender, EventArgs e)
        {
            IPAddress ipAddress;
            if (IPAddress.TryParse(serverIP_tb.Text, out ipAddress))
            {
                // The string was successfully parsed
                
            }
            else
            {
                // The string could not be parsed as an IP address
                MessageBox.Show("Invalid IP address string: " + serverIP_tb.Text, "Error");
            }
        }

        private void clientPort_tb_TextChanged(object sender, EventArgs e)
        {
            int result;
            if (!int.TryParse(clientPort_tb.Text, out result))
            {
                MessageBox.Show("Invalid port number: " + clientPort_tb.Text, "Error");
            }
        }

        private void serverPort_tb_TextChanged(object sender, EventArgs e)
        {
            int result;
            if (!int.TryParse(serverPort_tb.Text, out result))
            {
                MessageBox.Show("Invalid port number: " + serverPort_tb.Text, "Error");
            }
        }
        void send_bytes(string hostname, string text = null)
        {
            byte[] bytes_received = new byte[256];
            bytes_received = Encoding.UTF8.GetBytes(hostname + ": " + text);
            client_socket.Send(bytes_received);
        }

        private void connect_bt_Click(object sender, EventArgs e)
        {
            if (!skip)
            {
                try
                {
                    client_IP_port = new IPEndPoint(IPAddress.Parse(clientIP_tb.Text), Int32.Parse(clientPort_tb.Text));
                    client_socket.Bind(client_IP_port);
                }
                catch (SocketException)
                {
                    MessageBox.Show("IP address is invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                skip = true;
            }
            try
            {
                client_socket.Connect(IPAddress.Parse(serverIP_tb.Text), Int32.Parse(serverPort_tb.Text));
            }
            catch (FormatException)
            {
                MessageBox.Show("Server IP is invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            catch (SocketException)
            {
                MessageBox.Show("Server IP khong ton tai", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Establish_Connection();
            send_bt.Enabled = true;
            send_bytes(hostname_tb.Text);
        }

        private void send_bt_Click(object sender, EventArgs e)
        {
            send_bytes(hostname_tb.Text, chat_tb.Text);
            chat_lb.Items.Add(chat_tb.Text + ": " + chat_tb.Text);
        }
    }
}
