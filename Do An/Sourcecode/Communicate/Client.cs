using communicate_client_server;
using Forms;
using Newtonsoft.Json;
using Response;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace Communicate
{
    public partial class Client : Form
    {
        TcpClient client = new TcpClient();
        Stream stream;
        IPAddress ipAddress;
        public Client()
        {
            InitializeComponent();
        }
  
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void login_button_Click(object sender, EventArgs e)
        {
            Send_login(username_textbox.Text, pass_textbox.Text);
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
                byte[] buffer = new byte[length];
                while (bytes_read < length)
                    bytes_read += stream.Read(buffer, 0, length - bytes_read);
                string data = Encoding.UTF8.GetString(buffer);
                string code = data.Substring(0, 5);
                
                    this.Invoke(new Action(() => 
                    {
                        if (code == "00000" && data.Substring(5,1) == "1")
                        {
                            Root_Reponse_standing responseStanding = JsonConvert.DeserializeObject<Root_Reponse_standing>(data.Substring(6));
                            Dashboard dashboard = new Dashboard(responseStanding);
                            this.Hide();
                            dashboard.ShowDialog();
                        }
                        else
                            MessageBox.Show("Tài khoản hoặc mật khẩu không đúng", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }));



            }

        }
        public void Send_login(string username, string password)
        {
            byte[] header = new byte[4];
            Login login_data = new Login(username, password);
            string code = "00000";
            string json_data = JsonConvert.SerializeObject(login_data);
            byte[] buffer = Encoding.UTF8.GetBytes(code + json_data);
            int lengthOfdata = buffer.Length;
            header = BitConverter.GetBytes(lengthOfdata);
            stream.Write(header, 0, 4);
            stream.Write(buffer, 0, lengthOfdata);
        }
        private void Client_Load(object sender, EventArgs e)
        {
            ipAddress = IPAddress.Parse("127.0.0.1");
            client.Connect(ipAddress, 8080);
            stream = client.GetStream();
            Thread thread1 = new Thread(Client_listening); 
            thread1.IsBackground = true;
            thread1.Start();
        }
        private void pass_textbox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter) 
            {
               login_button.PerformClick();
            }
        }
    }
}
