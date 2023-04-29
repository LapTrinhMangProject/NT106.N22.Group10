using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Threading;

namespace TCP_Connection
{
    public class TCP_Server
    {
        TcpListener server = null;

        public void listening(string server_ip,int port=8080)
        {
            try
            {
                // Set the IP address and port number for the server
                IPAddress ipAddress = IPAddress.Parse(server_ip);

                // Create a TcpListener object
                server = new TcpListener(ipAddress, port);

                // Start listening for connections
                server.Start();
                MessageBox.Show("waitting to connect");
                // Enter the listening loop
                while (true)
                {

                    // Accept the client connection
                    TcpClient client = server.AcceptTcpClient();
                    Thread thread2 = new Thread(() => Establish(client));
                    thread2.IsBackground = true;
                    thread2.Start();
                    MessageBox.Show("Connected!");
                  
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: {0}", e);
                server.Stop();
            }

            Console.WriteLine("\nHit enter to continue...");
            Console.Read();
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
                    
            }
        }
    }
}
