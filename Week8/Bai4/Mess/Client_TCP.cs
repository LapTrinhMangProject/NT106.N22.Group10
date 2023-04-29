using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using Newtonsoft.Json;

namespace TCP_Connection
{
    public class Mess
    {
        public string sender_name { get; set; }
        public string recipient_name { get; set; }
        public string body { get; set; }
    }
    public class Client_TCP
    {
        public Mess mess = new Mess();
       IPAddress ipAddress;
        TcpClient client = new TcpClient();
        NetworkStream stream;

       public void Try_connect(string server_ip, int port)
        {
            try
            {
                // Set the IP address and port number for the server
                 ipAddress = IPAddress.Parse(server_ip);
                // Create a TcpClient object and connect to the server
                client = new TcpClient();
                client.Connect(ipAddress, port);

                // Get a stream object for reading and writing
                stream = client.GetStream();
            }
            catch (Exception e)
            {
                MessageBox.Show($"Exception: {e}");
            }
        }
     public void send(string sender, string body = null)
        {
          mess.sender_name = sender;
            mess.body = body;
            string json_data = JsonConvert.SerializeObject(mess);
            byte[] buffer = Encoding.UTF8.GetBytes(json_data);
            stream.Write(buffer, 0, buffer.Length);
            stream.Flush();
        }
    }
}
