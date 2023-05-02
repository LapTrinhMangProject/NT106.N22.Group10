using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net.Sockets;
using System.Net;
using System.Threading;
using System.Windows.Forms;
namespace ex3_lab3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread thread1 = new Thread(tcp_listent_and_connect);
            button1.Enabled = false;
            thread1.Start();
        }
        void tcp_listent_and_connect()
        {
            TcpListener server = null;
            try
            {
                // initialize socket
                Int32 port = 8080;
                IPAddress localAddr = IPAddress.Parse("127.0.0.1");
                server = new TcpListener(localAddr, port);
                // start listening for client requests
                server.Start();
                // buffer for reading data
                Byte[] bytes = new Byte[256];
                String data = null;

                // Enter the listening loop
                while (true)
                {
                    richTextBox1.Invoke((MethodInvoker)delegate
                    {
                        richTextBox1.AppendText("Waiting for a connection... ");
                    });
                    // Perform a blocking call to accept requests.
                    // You could also use server.AcceptSocket() here.
                    TcpClient client = null;
                    try
                    {
                        client = server.AcceptTcpClient();
                        richTextBox1.Invoke((MethodInvoker)delegate
                        {
                            richTextBox1.AppendText("\r\nConnected!");
                        });
                        data = null;
                        NetworkStream stream = client.GetStream();

                        int i;

                        // Loop to receive all the data sent by the client.
                        while ((i = stream.Read(bytes, 0, bytes.Length)) != 0)
                        {
                            // Translate data bytes to a ASCII string.
                            data = System.Text.Encoding.UTF8.GetString(bytes, 0, i);
                            richTextBox1.Invoke((MethodInvoker)delegate
                            {
                                richTextBox1.AppendText("\r\n" + data);
                            });
                        }
                    }
                    finally
                    {
                        client?.Dispose();
                    }
                }

            }
            catch (SocketException e)
            {
                richTextBox1.Invoke((MethodInvoker)delegate
                {
                    richTextBox1.AppendText(string.Format("\r\nSocketException: {0}", e.Message));
                });
            }
            finally
            {
                server.Stop();
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
