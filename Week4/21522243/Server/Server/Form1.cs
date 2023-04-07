using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void Server_Listener()
        {
            TcpListener server;
            TcpClient establish_connection_to_client;
            try
            {
                server = new TcpListener(IPAddress.Parse(tb_IPSV.Text), Int32.Parse(tb_PortSV.Text));
                server.Start();
            }
            catch (Exception)
            {
                MessageBox.Show("Dia chi ip khong hop le hoac khong ton tai hoac da ton tai", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            while (true)
            {

                establish_connection_to_client = server.AcceptTcpClient();
                Thread thread1 = new Thread(() => chat_server(establish_connection_to_client));
                thread1.Start();

            }
            void chat_server(TcpClient establish_connection_to_client_multi)
            {
                NetworkStream getStream_from_connection;
                TcpClient connection = establish_connection_to_client;
                getStream_from_connection = connection.GetStream();
                Byte[] bytes_received = new byte[256];
                string string_converted_from_bytes = null;
                string hostname = null;
                while (true)
                {
                    int get_bytes = 0;
                    try
                    {
                        get_bytes = getStream_from_connection.Read(bytes_received, 0, bytes_received.Length);

                    }
                    catch (IOException)
                    {
                        MessageBox.Show(hostname + " dong ket noi", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    string_converted_from_bytes = Encoding.UTF8.GetString(bytes_received);
                    if (hostname == null)
                    {
                        hostname = string_converted_from_bytes.Split(':')[0];
                    }
                    else
                    {
                        lstChatServer.Invoke(new MethodInvoker(delegate
                        {
                            lstChatServer.Items.Add(string_converted_from_bytes);
                        }));
                    }
                }

            }
        }

        private void bt_Start_Click(object sender, EventArgs e)
        {
            Thread Thread1 = new Thread(Server_Listener);
            Thread1.Start();
            bt_Start.Enabled = false;
        }
        private void bt_Exit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
