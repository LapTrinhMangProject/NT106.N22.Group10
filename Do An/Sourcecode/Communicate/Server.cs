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

namespace Communicate
{
    public partial class Server_form : Form
    {
        public Server_form()
        {
            InitializeComponent();
        }

        private void Server_Load(object sender, EventArgs e)
        {
            Thread thread1 = new Thread(Server_Listener);
            thread1.IsBackground = true;
            thread1.Start();
        }
        SQL_user sqlUser = new SQL_user();
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
                    MessageBox.Show("new");
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
            StreamWriter writer = new StreamWriter(stream);
            // Loop to receive all the data sent by the client
            while (client.Connected)
            {

                int bytes_read = 0;
                byte[] header = new byte[4];
                while (bytes_read < 4)
                {
                    bytes_read += stream.Read(header, 0, header.Length);
                }
                int length = BitConverter.ToInt32(header, 0);
                bytes_read = 0;
                byte[] buffer = new byte[length];
                while (bytes_read < length)
                {
                    bytes_read += stream.Read(buffer, bytes_read, length - bytes_read);
                }

                string data = Encoding.UTF8.GetString(buffer, 0, length);
                string code = data.Substring(0, 5);
                if (code == "00000")
                {
                    Login login = JsonConvert.DeserializeObject<Login>(data.Substring(5));
                    if (sqlUser.Check_Credential(login.username, login.password))
                    {
                     

                        Send_Login("1");

                    }
                    else
                        Send_Login("0");

                }
            }
            async void Send_Login(string target)
            {
                byte[] header = new byte[4];
                string code = "00000";

                API aPI = new API();
                Root_Reponse_standing reponseStanding = await aPI.Get_Standing("39");
                string jsonData = JsonConvert.SerializeObject(reponseStanding);
                // serialize the dashboard object to a JSON string
                byte[] buffer = Encoding.UTF8.GetBytes(code + target+jsonData);
                int lengthOfdata = buffer.Length;
                header = BitConverter.GetBytes(lengthOfdata);
                stream.Write(header, 0, 4);
                stream.Write(buffer, 0, lengthOfdata);
            }
        }

    }
}

