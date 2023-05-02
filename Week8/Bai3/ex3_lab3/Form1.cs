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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        TcpClient client = null;
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        
        int number_of_ip_usage = 192;
        private void button1_Click(object sender, EventArgs e)
        {
            Thread thread1 = new Thread(initialize_and_connect);
            thread1.Start();
        }
        void initialize_and_connect()
        {
            number_of_ip_usage++;
            button1.Invoke((MethodInvoker)delegate
            {
                button1.Enabled = false;
            });
            //initialize client socket
            IPAddress localAddr = IPAddress.Parse("127.0.0." + number_of_ip_usage.ToString());
            Int32 localPort = 8080;
            client = new TcpClient(new IPEndPoint(localAddr, localPort));
            //get server's socket
            Int32 serverPort = 8080;
            IPAddress serverAddr = IPAddress.Parse("127.0.0.1");
            client.Connect(serverAddr, serverPort);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }
        NetworkStream stream = null;
        private void button2_Click(object sender, EventArgs e)
        {
            // Translate the passed message into ASCII and store it as a Byte array.
            Byte[] data = null;
            textBox1.Invoke((MethodInvoker)delegate
            {
                data = System.Text.Encoding.UTF8.GetBytes(textBox1.Text);
            });
            //get network stream object for communication with the server
            stream = client.GetStream();

            // Send the message to the connected TcpServer.
            var message = System.Text.Encoding.UTF8.GetBytes("From client: ");
            data = message.Concat(data).ToArray();

            stream.Write(data, 0, data.Length);
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                button2.PerformClick();
                textBox1.Text = "";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var message = System.Text.Encoding.UTF8.GetBytes("The client has disconnected\n");
            stream.Write(message, 0, message.Length);
            client.Close();
            button1.Enabled = true;
        }
    }
}
