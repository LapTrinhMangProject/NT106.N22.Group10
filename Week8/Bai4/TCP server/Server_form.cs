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
            byte[] bytes = new byte[1024];
            NetworkStream stream = client.GetStream();

            // Loop to receive all the data sent by the client
            int i;
            while ((i = stream.Read(bytes, 0, bytes.Length)) != 0)
            {
            Mess mess = new Mess();
                // Convert the data bytes to a string
                string data = Encoding.UTF8.GetString(bytes, 0, i);
                MessageBox.Show(data,"server read:");
                string code = data.Substring(0, 2);
                switch (code)
                {
                    case "00":
                        mess = JsonConvert.DeserializeObject<Mess>(data.Substring(2));

                        List_connection.Invoke(new Action(() => {
                            List_connection.Items.Add("Connected from " + mess.sender_name);
                        }));
                        _mess.Add(mess);
                        _mapping[mess.sender_name] = client;
                        break;
                    case "01":
                     //   MessageBox.Show(data.Substring(2));
                      mess = JsonConvert.DeserializeObject<Mess>(data.Substring(2));
                        chat.Invoke(new Action(() => {
                            chat.Items.Add($"{mess.sender_name}: {mess.body}");
                        }));
                        Broadcast(mess, client);
                        break;
                    case "10":
                        MessageBox.Show(data.Substring(2));

                        mess = JsonConvert.DeserializeObject<Mess>(data.Substring(2));

                        TcpClient client_forward;
                        if (_mapping.TryGetValue(mess.recipient_name, out client_forward))
                        {
                          
                            bytes = Encoding.UTF8.GetBytes("01"+data.Substring(2));
                            Stream stream_forwarding = client_forward.GetStream();
                            stream_forwarding.Write(bytes, 0, bytes.Length);
                            stream_forwarding.Flush();
                        }
                        break;
                    case "11":
                            string json_data = JsonConvert.SerializeObject(_mess);
                       string data_return = code+json_data;
                        bytes = Encoding.UTF8.GetBytes(data_return);   
                        stream.Write(bytes, 0, bytes.Length);
                        stream.Flush();
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
        void Broadcast(Mess mess,TcpClient exclude)
        {
            string json_data = JsonConvert.SerializeObject(mess);
            string data = "01" + json_data;
            byte[] bytes = new byte[254];
            bytes = Encoding.UTF8.GetBytes(data);
            lock (_lock)
            {
                foreach (TcpClient c in _clients)
                {
                    if (c == exclude)
                        continue;
                    NetworkStream stream = c.GetStream();
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
