using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Linq.Expressions;
using System.Net;
using System.Net.Http;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Threading;
using System.Xml.Schema;

namespace Server
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void run_bt_Click(object sender, EventArgs e)
        {
            new Thread(
                () =>
                {
                    TcpListener server;
                    TcpClient client;
                    try
                    {
                        server = new TcpListener(IPAddress.Parse(serverIP_tb.Text), 8080);
                        server.Start();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("IP address is invalid!");
                        return;
                    }

                    while (true)
                    {
                        client = server.AcceptTcpClient();
                        Thread thread1 = new Thread(() => chat_server(client));
                        thread1.IsBackground = true;
                        thread1.Start();

                    }
                    void chat_server(TcpClient multi_clients)
                    {
                        NetworkStream stream_server_client;
                        stream_server_client = multi_clients.GetStream(); 
                        Byte[] bytes_received = new byte[256];
                        string string_bytes = "";
                        string hostname_of_client = "";
                        while (true)
                        {
                            string_bytes = Encoding.UTF8.GetString(bytes_received);
                            if (hostname_of_client != "")
                            {
                                chat_lb.Invoke(new MethodInvoker(delegate
                                {
                                    chat_lb.Items.Add(string_bytes);
                                }));
                            }
                        }

                    }
                }
                )
            { IsBackground = true }.Start();
        }
    }

}
