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
            Mess mess;
            byte[] bytes = new byte[254];
            NetworkStream stream = client.GetStream();

            // Loop to receive all the data sent by the client
            bool first_time = true;
            int i;
            while ((i = stream.Read(bytes, 0, bytes.Length)) != 0)
            {
                // Convert the data bytes to a string
                string json_data = Encoding.UTF8.GetString(bytes, 0, i);
                mess = JsonConvert.DeserializeObject<Mess>(json_data);
               
                if (first_time)
                {

                    List_connection.Invoke(new Action(() => {
                        List_connection.Items.Add("Connected from " + mess.sender_name);
                    }));
                    first_time = false;
                    continue;
                }
                chat.Invoke(new Action(() => {
                    chat.Items.Add($"{mess.sender_name}: {mess.body}");
                }));
                Broadcast(mess, client);
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
            byte[] bytes = new byte[254];
            bytes = Encoding.UTF8.GetBytes(json_data);
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
