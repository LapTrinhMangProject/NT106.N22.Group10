using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace communicate_client_server
{
    public class Com_Server
    {
        TcpListener server;
       public void Server_Listener()
        {
            try
            {
                IPAddress ipAddress = IPAddress.Parse("192.168.1.8");
                server = new TcpListener(ipAddress, 3004);
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
                if(code == "00000")
                {
                    Login login = JsonConvert.DeserializeObject<Login>(data.Substring(5));
                    MessageBox.Show($"username: {login.username} with pass: {login.password}");
                }
            }
        }
    }
}
