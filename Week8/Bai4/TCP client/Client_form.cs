using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TCP_Connection;

namespace Client
{
    public partial class Client_form : Form
    {
        public Client_form()
        {
            InitializeComponent();
        }
         Mess mess = new Mess();
        IPAddress ipAddress;
        TcpClient client = new TcpClient();
        NetworkStream stream;
        private void Form1_Load(object sender, EventArgs e)
        {
            send_button.Enabled = false;
        }
       

         void connect_buton_Click(object sender, EventArgs e)
        {
            
                // Set the IP address and port number for the server
                ipAddress = IPAddress.Parse(IP_textbox.Text);
                // Create a TcpClient object and connect to the server
                client = new TcpClient();
                client.Connect(ipAddress, Int32.Parse(port_textbox.Text));
                // Get a stream object for reading and writing
            mess.sender_name = hostname_textbox.Text;
                stream = client.GetStream();
            Thread thread1 = new Thread(() => Client_listening(stream));
            thread1.IsBackground = true;
            thread1.Start();
            connect_buton.Enabled = false;
            connect_buton.Text = "Connected";
            send_bytes();
            send_button.Enabled = true;
        }

        private void send_button_Click(object sender, EventArgs e)
        {
            send_bytes(send_textbox.Text);
            chat_listbox.Items.Add($"You: {send_textbox.Text}");
        }
        void send_bytes(string text=null)
        {
            mess.body = text;
            string json_data = JsonConvert.SerializeObject(mess);
            byte[] bytes = new byte[254];
            bytes = Encoding.UTF8.GetBytes(json_data);
            stream.Write(bytes, 0, bytes.Length);
            stream.Flush();
        }

        void Client_listening(NetworkStream stream)
        {
            Mess mess_from_server = new Mess();
            int i;
            byte[] bytes = new byte[254];
            while ((i = stream.Read(bytes, 0, bytes.Length)) != 0)
            {
                // Convert the data bytes to a string
                string json_data = Encoding.UTF8.GetString(bytes, 0, i);
                mess_from_server = JsonConvert.DeserializeObject<Mess>(json_data);
                chat_listbox.Invoke(new Action(() => {
                    chat_listbox.Items.Add($"{mess_from_server.sender_name}: {mess_from_server.body}");
                }));

            }
            }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
