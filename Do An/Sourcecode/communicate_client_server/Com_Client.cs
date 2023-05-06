using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace communicate_client_server
{
    public class Com_Client
    {
        IPAddress ipAddress;
        TcpClient client = new TcpClient();
        NetworkStream stream;
       
      public  Com_Client()
        {
            ipAddress = IPAddress.Parse("42.119.166.156");
            client.Connect(ipAddress, 3004);
            stream = client.GetStream();
        }
        public void Client_listening()
        {
            while (client.Connected)
            {
                int bytes_read = 0;
                byte[] header = new byte[4];
                while (bytes_read < 4)
                {
                    bytes_read += stream.Read(header, 0, header.Length - bytes_read);
                }
                int length = BitConverter.ToInt32(header, 0);
                bytes_read = 0;
                byte[] data = new byte[length];
                while(bytes_read < length)
                {
                    bytes_read += stream.Read(data, 0, length - bytes_read);
                }


            }

        }
      public  void Send_login(string username,string password)
        {
            byte[] header = new byte[4];   
            Login login_data = new Login(username, password);
            string code = "00000";
            string json_data = JsonConvert.SerializeObject(login_data);
            byte[] buffer = Encoding.UTF8.GetBytes(code+json_data);
            int lengthOfdata = buffer.Length;
            header = BitConverter.GetBytes(lengthOfdata);
            stream.Write(header, 0, 4);
            stream.Write(buffer, 0, lengthOfdata);
        }
    }
}
