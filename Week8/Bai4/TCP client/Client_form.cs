using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TCP_Connection;

namespace Client
{
    public partial class Client_form : Form
    {
        public Client_form()
        {
            InitializeComponent();
        }
         Mess mess = new Mess();
        IPAddress ipAddress;
        TcpClient client = new TcpClient();
        NetworkStream stream;
        private void Form1_Load(object sender, EventArgs e)
        {
            send_button.Enabled = false;
        }
       

         void connect_buton_Click(object sender, EventArgs e)
        {
            
                // Set the IP address and port number for the server
                ipAddress = IPAddress.Parse(IP_textbox.Text);
                // Create a TcpClient object and connect to the server
                client = new TcpClient();
                client.Connect(ipAddress, Int32.Parse(port_textbox.Text));
                // Get a stream object for reading and writing
            mess.sender_name = hostname_textbox.Text;
                stream = client.GetStream();
            Thread thread1 = new Thread(() => Client_listening(stream));
            thread1.IsBackground = true;
            thread1.Start();
            connect_buton.Enabled = false;
            connect_buton.Text = "Connected";
            send_bytes("00");
            send_button.Enabled = true;
           
        }

        private void send_button_Click(object sender, EventArgs e)
        {
            if (specific_client_check_box.Checked)
            {
                mess.recipient_name = list_client_listbox.SelectedItems.ToString();
                send_bytes("10", send_textbox.Text);
            }
            else
            {
                send_bytes("01", send_textbox.Text);
                chat_listbox.Items.Add($"You: {send_textbox.Text}");
            }
        }
        void send_bytes(string code,string text=null)
        {
            byte[] bytes = new byte[1024];
            if (code == "11")
            {
                bytes = Encoding.UTF8.GetBytes("11");

            }
            else
            {
                mess.body = text;
                string data = code + JsonConvert.SerializeObject(mess);
                bytes = Encoding.UTF8.GetBytes(data);
            }

                stream.Write(bytes, 0, bytes.Length);
         stream.Flush();
        }

        void Client_listening(NetworkStream stream)
        {
            Mess mess_from_server = new Mess();
            int i;
            byte[] bytes = new byte[254];
            while ((i = stream.Read(bytes, 0, bytes.Length)) != 0)
            {
                string data = Encoding.UTF8.GetString(bytes, 0, i);
                string code = data.Substring(0, 2);
               switch (code)
                {
                    case "01":
                        string json_data = data.Substring(2);
                mess_from_server = JsonConvert.DeserializeObject<Mess>(json_data);
                chat_listbox.Invoke(new Action(() => {
                    chat_listbox.Items.Add($"{mess_from_server.sender_name}: {mess_from_server.body}");
                }));
                        break;
                    case "11":
                        List<Mess> list = JsonConvert.DeserializeObject<List<Mess>>(data.Substring(2));
                       foreach(Mess name in list)
                        {
                            if (name.sender_name == mess.sender_name)
                                continue;
                            list_client_listbox.Invoke(new Action(() =>
                            {
                                list_client_listbox.Items.Add(name.sender_name);
                            }));
                        }
                        break;
                }

            }
            }
        void request_update_clients()
        {
          
                list_client_listbox.Invoke(new Action(() =>
                {
                    list_client_listbox.Items.Clear();
                }));
                send_bytes("11");
            
        }
        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            request_update_clients();
        }
    }
}
