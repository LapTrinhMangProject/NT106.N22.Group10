using communicate_client_server;
using Library_football;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Communicate
{
    public class Request
    {
        Stream stream;
        public Request(Stream stream)
        {
            this.stream = stream;
        }
        string jsonData = null;
        public void Send(string code, string username = null, string password = null)
        {
            if (code == "00000")
                jsonData = JsonConvert.SerializeObject(new Login(username, password));
            byte[] header = new byte[4];
            byte[] buffer = Encoding.UTF8.GetBytes(code + jsonData);
            header = BitConverter.GetBytes(buffer.Length);
            stream.Write(header, 0, header.Length);
            stream.Write(buffer, 0, buffer.Length);
            stream.Flush();
        }
        public void Send(string code, League league)
        {
            byte[] header = new byte[4];
            jsonData = JsonConvert.SerializeObject(league);
            string payload = code + jsonData;
            byte[] buffer = Encoding.UTF8.GetBytes(payload);
            header = BitConverter.GetBytes(buffer.Length);
            stream.Write(header, 0, header.Length);
            stream.Write(buffer, 0, buffer.Length);
            stream.Flush();
        }
    }
}
