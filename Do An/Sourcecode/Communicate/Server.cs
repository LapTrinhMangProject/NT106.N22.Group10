using communicate_client_server;
using Newtonsoft.Json;
using SQL_Connection;
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
using Forms;
using Get_response_using_API;
using System.ComponentModel.Design.Serialization;
using Response;
using Library_football;

namespace Communicate
{
    public partial class Server_form : Form
    {
        public Server_form()
        {
            InitializeComponent();
        }
        SQL_user sqlUser = new SQL_user();

        private void Server_Load(object sender, EventArgs e)
        {
            Thread thread1 = new Thread(Server_Listener);
            thread1.IsBackground = true;
            thread1.Start();
        }
        TcpListener server;
        public void Server_Listener()
        {
            try
            {
                IPAddress ipAddress = IPAddress.Parse("127.0.0.1");
                server = new TcpListener(ipAddress, 8080);
                server.Start();
                while (true)
                {

                    TcpClient client = server.AcceptTcpClient();
                    client.ReceiveBufferSize = 1048576;
                    client.SendBufferSize = 1048576;
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
            Reponse reponse = new Reponse(stream);

            while (client.Connected)
            {
                int bytes_read = 0;
                byte[] header = new byte[4];
                    bytes_read += stream.Read(header, 0, 4);
                int length = BitConverter.ToInt32(header, 0);
                bytes_read = 0;
                byte[] buffer = new byte[length];
                while (bytes_read < length)
                    bytes_read += stream.Read(buffer, bytes_read, length - bytes_read);
                string data = Encoding.UTF8.GetString(buffer, 0, length);
                string code = data.Substring(0, 5);
                    switch (code)
                    {
                        case "00000":
                            reponse.Check_Credential(data.Substring(5));
                        break;
                        case "00001":
                            reponse.Get_All_Players();
                        break;
                    }
            }
        }
    }
}

