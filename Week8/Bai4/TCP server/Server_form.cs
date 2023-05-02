using Newtonsoft.Json;
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
using TCP_Connection;
namespace Server
{
    public partial class Server_form : Form
    {
        public Server_form()
        {
            InitializeComponent();
        }
        TcpListener server;
        static readonly object _lock = new object();
        static readonly List<TcpClient> _clients = new List<TcpClient>();
        static readonly List<Mess> _mess = new List<Mess>();
        static readonly Dictionary<string, TcpClient> _mapping = new Dictionary<string, TcpClient>();
        void Server_Listener()
        {
            try
            {
                // Set the IP address and port number for the server
                IPAddress ipAddress = IPAddress.Parse(severip_textbox.Text);

                // Create a TcpListener object
                server = new TcpListener(ipAddress, 8080);

                // Start listening for connections
                server.Start();
                status_textbox.Invoke(new Action(() => {
                    status_textbox.Text = "Waitting to connect";
                }));
                // Enter the listening loop
                while (true)
                {

                    // Accept the client connection
                    TcpClient client = server.AcceptTcpClient();
                    client.ReceiveBufferSize = 1048576;
                    client.SendBufferSize = 1048576;
               lock (_lock) _clients.Add(client);
                    Thread thread2 = new Thread(() => Establish(client));
                    thread2.IsBackground = true;
                    thread2.Start();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show($"{e}");
                server.Stop();
            }
        }
        void Establish(TcpClient client)
        {
            NetworkStream stream = client.GetStream();
            
            // Loop to receive all the data sent by the client
            while (client.Connected) {
              
                    int bytes_read = 0;
                    byte[] header = new byte[4];
                    while (bytes_read < 4)
                    {
                        bytes_read += stream.Read(header,0, header.Length);
                    }
                    int length = BitConverter.ToInt32(header, 0);
                    bytes_read = 0;
                    byte[] buffer = new byte[length];
                    while(bytes_read < length)
                    {
                        bytes_read += stream.Read(buffer, bytes_read, length-bytes_read);
                    }
                    
                    Mess mess = new Mess();
                    string data = Encoding.UTF8.GetString(buffer, 0, length);
                    string code = data.Substring(0, 2);
                    switch (code)
                    {
                        case "00":
                            mess = JsonConvert.DeserializeObject<Mess>(data.Substring(2));

                            List_connection.Invoke(new Action(() =>
                            {
                                List_connection.Items.Add("Connected from " + mess.sender_name);
                            }));
                            _mess.Add(mess);
                            _mapping[mess.sender_name] = client;
                            break;
                        case "01":
                            //   MessageBox.Show(data.Substring(2));
                            mess = JsonConvert.DeserializeObject<Mess>(data.Substring(2));
                            chat.Invoke(new Action(() =>
                            {
                                chat.Items.Add($"{mess.sender_name}: {mess.body}");
                            }));
                            Broadcast(mess, client, "01");
                            break;
                        case "10":

                            mess = JsonConvert.DeserializeObject<Mess>(data.Substring(2));
                            TcpClient client_forward;
                            lock (_lock)
                            {
                                if (_mapping.TryGetValue(mess.recipient_name, out client_forward))
                                {

                                    buffer = Encoding.UTF8.GetBytes("01" + data.Substring(2));
                                    Stream stream_forwarding = client_forward.GetStream();
                                header = BitConverter.GetBytes(buffer.Length);
                                stream_forwarding.Write(header, 0, header.Length);
                                    stream_forwarding.Write(buffer, 0, buffer.Length);
                                    stream_forwarding.Flush();
                                }
                            }
                            break;
                        case "11":
                            string json_data = JsonConvert.SerializeObject(_mess);
                            string data_return = code + json_data;
                            buffer = Encoding.UTF8.GetBytes(data_return);
                         header = BitConverter.GetBytes(buffer.Length);
                            stream.Write(header, 0, header.Length);
                            stream.Write(buffer, 0, buffer.Length);
                            stream.Flush();
                            break;
                        case "fb":
                             mess = JsonConvert.DeserializeObject<Mess>(data.Substring(2));
                            chat.Invoke(new Action(() =>
                            {
                                chat.Items.Add($"Server nhan duoc file {mess.file.fileName} tu {mess.sender_name}");
                            }));
                               Broadcast(mess, client,"fs");
                            break;
                        case "fs":
                             mess = JsonConvert.DeserializeObject<Mess>(data.Substring(2));
                            chat.Invoke(new Action(() =>
                            {
                                chat.Items.Add($"Server nhan duoc file {mess.file.fileName} tu {mess.sender_name}");
                            }));
                            TcpClient client_forward_file;
                            lock (_lock)
                            {
                                if (_mapping.TryGetValue(mess.recipient_name, out client_forward_file))
                                {

                                    buffer = Encoding.UTF8.GetBytes("fs" + data.Substring(2));
                                    Stream stream_forwarding = client_forward_file.GetStream();
                                     header = BitConverter.GetBytes(buffer.Length);
                                     stream_forwarding.Write(header, 0, header.Length);
                                    stream_forwarding.Write(buffer, 0, buffer.Length);
                                    stream_forwarding.Flush();
                                }
                            }
                            break;
                        case "ib":
                              mess = JsonConvert.DeserializeObject<Mess>(data.Substring(2));
                            chat.Invoke(new Action(() =>
                            {
                                chat.Items.Add($"Server nhan duoc file {mess.file.fileName} tu {mess.sender_name}");
                            }));
                              Broadcast(mess, client,"ib");
                            break;
                    case "is":
                        mess = JsonConvert.DeserializeObject<Mess>(data.Substring(2));
                        chat.Invoke(new Action(() =>
                        {
                            chat.Items.Add($"Server nhan duoc file {mess.file.fileName} tu {mess.sender_name}");
                        }));
                        TcpClient client_forward_image;
                        lock (_lock)
                        {
                            if (_mapping.TryGetValue(mess.recipient_name, out client_forward_image))
                            {

                                buffer = Encoding.UTF8.GetBytes("ib" + data.Substring(2));
                                Stream stream_forwarding = client_forward_image.GetStream();
                                 header = BitConverter.GetBytes(buffer.Length);
                                stream_forwarding .Write(header, 0, header.Length);
                                stream_forwarding.Write(buffer, 0, buffer.Length);
                                stream_forwarding.Flush();
                            }
                        }
                        break;

                    }
                
            }
        }
        private void runserver_button_Click(object sender, EventArgs e)
        {
            Thread Thread1 = new Thread(Server_Listener);
            Thread1.IsBackground = true;
            Thread1.Start();
            runserver_button.Text = "Running";
            runserver_button.Enabled = false;
        }
        void Broadcast(Mess mess,TcpClient exclude,string code)
        {
            string json_data = JsonConvert.SerializeObject(mess);
            string data = code + json_data;
            byte[] bytes;
            bytes = Encoding.UTF8.GetBytes(data);
            byte[] header = BitConverter.GetBytes(bytes.Length);
            lock (_lock)
            {
                foreach (TcpClient c in _clients)
                {
                    if (c == exclude)
                        continue;
                    NetworkStream stream = c.GetStream();
                    stream.Write(header, 0, header.Length);
                    stream.Write(bytes, 0, bytes.Length);
                    stream.Flush();
                }
            }
        }










        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void chat_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void List_connection_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
