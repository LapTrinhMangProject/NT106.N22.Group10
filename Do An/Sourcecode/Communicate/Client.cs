using communicate_client_server;
using Forms;
using Library_football;
using Newtonsoft.Json;
using Response;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using Forms;
namespace Communicate
{
    public partial class Client : Form
    {
        TcpClient client = new TcpClient();
        NetworkStream stream;
        IPAddress ipAddress;
        Request requestUser;
        public Client()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void login_button_Click(object sender, EventArgs e)
        {
            requestUser.Send("00000",username_textbox.Text,pass_textbox.Text);
        }
        public void Client_listening()
        {
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
                string data = Encoding.UTF8.GetString(buffer);
                string code = data.Substring(0, 5);
                        switch (code) 
                        {
                            case "00000":
                                this.Invoke(new Action(() =>
                                {
                                    if (data.Substring(5, 1) == "1")
                                    {
                                        Root_Reponse_standing responseStanding = JsonConvert.DeserializeObject<Root_Reponse_standing>(data.Substring(6));
                                        Dashboard dashboardForm = new Dashboard(responseStanding, requestUser);
                                        this.Close();
                                        dashboardForm.Show();
                                    }
                                    else
                                        MessageBox.Show("Tài khoản hoặc mật khẩu không đúng", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }));
                             break;
                             case "00001":
                                  List<Player> _player = JsonConvert.DeserializeObject<List<Player>>(data.Substring(5));
                                  Player_form playerForm = new Player_form(_player);
                                  playerForm.ShowDialog();
                             break;
                        }
            }
        }
        private void Client_Load(object sender, EventArgs e)
        {
            ipAddress = IPAddress.Parse("127.0.0.1");
            client.Connect(ipAddress, 8080);
            stream = client.GetStream();
            requestUser = new Request(stream);
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
