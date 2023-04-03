using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Net.Http;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace Server
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        NetworkStream getStream_from_connection;
        TcpClient establish_connection_to_client;
        void Server_Listener()
        {
                TcpListener server;
            while (true)
            {
                try
                {
                    server = new TcpListener(IPAddress.Parse(severip_textbox.Text), 8080);
                    server.Start();
                }
                catch (Exception)
                {
                    MessageBox.Show("Dia chi ip khong hop le hoac khong ton tai", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    severip_textbox.Invoke(new MethodInvoker(delegate
                    {
                        severip_textbox.Text = Microsoft.VisualBasic.Interaction.InputBox("Nhap lai dia chi ip: ");
                    }));
                    continue;
                }
                break;
            }
            Byte[] bytes_received = new byte[256];
            string string_converted_from_bytes;
            IPAddress ip_from_client;
            while (true)
            {
                status_textbox.Invoke(new MethodInvoker(delegate
                {
                    status_textbox.Text = "Waiting for incoming connection";
                }));
                establish_connection_to_client = server.AcceptTcpClient();
            //    multiple_connection();
                string_converted_from_bytes = null;
                getStream_from_connection = establish_connection_to_client.GetStream();
               ip_from_client = ((IPEndPoint)establish_connection_to_client.Client.RemoteEndPoint).Address;

                List_connection.Invoke(new MethodInvoker(delegate
                {
                    List_connection.Items.Add("Connected from " + ip_from_client);

                }));
                while (true)
                {
                    int get_bytes = 0;
                    try
                    {
                        
                         get_bytes = getStream_from_connection.Read(bytes_received, 0, bytes_received.Length);
                    }
                    catch (IOException e)
                    {
                        MessageBox.Show(ip_from_client+" dong ket noi", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        List_connection.Invoke(new MethodInvoker(delegate
                        {
                            List_connection.Items.Add("Disconnected from " + ip_from_client);
                        }));
                    }
                    if (get_bytes == 0)
                        break;
                    string_converted_from_bytes = Encoding.ASCII.GetString(bytes_received);
                        chat.Invoke(new MethodInvoker(delegate
                        {
                            chat.Items.Add("Get message from " + ip_from_client + ": " + string_converted_from_bytes);
                        }));
                        //  chat.Items.Add("Get message from " + establish_connection_to_client.Client.RemoteEndPoint + ": " + data_converted_from_bytes);
           
                }
                establish_connection_to_client.Close();
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void chat_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void send_button_Click(object sender, EventArgs e)
        {
            byte[] data_converted_from_string = new byte[256];
            data_converted_from_string = Encoding.ASCII.GetBytes(send_textbox.Text);
            getStream_from_connection.Write(data_converted_from_string,0,data_converted_from_string.Length);
            chat.Items.Add("Sever: "+send_textbox.Text);
        }

        private void runserver_button_Click(object sender, EventArgs e)
        {
            Thread thread1;
            thread1 = new Thread(Server_Listener);
            thread1.IsBackground = true;
            thread1.Start();
            runserver_button.Enabled = false;
        }
        void multiple_connection()
        {
            Thread thread1;
            thread1 = new Thread(Server_Listener);
            thread1.IsBackground = true;
            thread1.Start();
        }
    }
}
