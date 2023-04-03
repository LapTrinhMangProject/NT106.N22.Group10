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

namespace Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        IPEndPoint client_ip_port;
        Socket client_socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        bool skip = false;
        private void Form1_Load(object sender, EventArgs e)
        {
            send_button.Enabled = false;
        }
        void Establish_Connection()
        {
            Thread thread1 = new Thread(Client_listener);
            thread1.IsBackground = true;
            thread1.Start();
            connect_buton.Text = "Connected";
            connect_buton.Enabled = false;   
        }
        void Client_listener()
        {
            while (true)
            {
                byte[] bytes_from_sever = new byte[256];
                try
                {
                    client_socket.Receive(bytes_from_sever);
                }
                catch (SocketException e)
                {
                    MessageBox.Show("Sever da dong ket noi","error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    connect_buton.Invoke(new MethodInvoker(delegate
                    {
                        connect_buton.Text = "Connect";
                        connect_buton.Enabled = true;
                    }));
                    send_button.Invoke(new MethodInvoker(delegate
                    {
                        send_button.Enabled = false;
                    }));
                    CancellationTokenSource cts = new CancellationTokenSource();
                    cts.Cancel();

                    return;
                
                }
                string string_converted_from_bytes = Encoding.ASCII.GetString(bytes_from_sever);
                chat_listbox.Invoke(new MethodInvoker(delegate
                {
                    chat_listbox.Items.Add("Message from Sever: " + string_converted_from_bytes);
                }));
            }
        }

         void connect_buton_Click(object sender, EventArgs e)
        {
            if (!skip)
            {
                try
                {
                    client_ip_port = new IPEndPoint(IPAddress.Parse(Ipclient_textbox.Text), 11000);
                    client_socket.Bind(client_ip_port);
                }
                catch (SocketException)
                {
                    MessageBox.Show("Dia chi ip khong ton tai trong local", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                skip = true;
            }
            try
            {
                client_socket.Connect(IPAddress.Parse(IP_textbox.Text), Int32.Parse(port_textbox.Text));
            }
            catch (FormatException)
            {
                MessageBox.Show("Server IP khong hop le", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            catch (SocketException)
            {
                MessageBox.Show("Server IP khong ton tai", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Establish_Connection();
            send_button.Enabled = true;
        }

        private void send_button_Click(object sender, EventArgs e)
        {
            byte[] bytes_converted_from_string = new byte[256];
            bytes_converted_from_string = Encoding.UTF8.GetBytes(send_textbox.Text);
            client_socket.Send(bytes_converted_from_string);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
