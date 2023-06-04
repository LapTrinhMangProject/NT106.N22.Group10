using communicate_client_server;
using Forms;
using LibraryFootBall;
using Newtonsoft.Json;
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
using ResponseDataStructure;

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
            requestUser.Send("00000", username_textbox.Text, pass_textbox.Text);
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
                string jsonData = data.Substring(5);
                this.Invoke(new Action(() =>
                {
                    switch (code)
                    {
                        case "00000":
                            Login login = JsonConvert.DeserializeObject<Login>(jsonData);
                            if (login.valid && login.typeUser == "normal")
                            {
                                League_form leagueForm = new League_form(login._league, requestUser);
                                this.Hide();
                                leagueForm.Show();
                            }
                            else if (login.valid && login.typeUser == "administrator")
                            {
                                Administrator_form administrator = new Administrator_form(login, requestUser);
                                this.Hide();
                                administrator.Show();

                            }
                            else
                                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        case "00001":
                            List<Player> _player = JsonConvert.DeserializeObject<List<Player>>(jsonData);
                            Player_form playerForm = new Player_form(_player);
                            playerForm.ShowDialog();
                            break;
                        case "00011":
                            SQL_BothTeamAndVenue dataGeneral = JsonConvert.DeserializeObject<SQL_BothTeamAndVenue>(jsonData);
                            Team_form teamForm = new Team_form(dataGeneral._teams, dataGeneral.teamAndvenue);
                            teamForm.ShowDialog();
                            break;
                        case "00100":
                            Root_Reponse_standing responseStanding = JsonConvert.DeserializeObject<Root_Reponse_standing>(jsonData);
                            Dashboard dashboardForm = new Dashboard(responseStanding, requestUser);
                            this.Hide();
                            dashboardForm.Show();
                            break;

                    }
                }));
            }
        }
        private void Client_Load(object sender, EventArgs e)
        {
            ipAddress = IPAddress.Parse("20.24.132.202");
            //ipAddress = IPAddress.Parse("127.0.0.1");
            client.Connect(ipAddress, 80);
            stream = client.GetStream();
            requestUser = new Request(stream);
            Thread thread1 = new Thread(Client_listening);
            thread1.IsBackground = true;
            thread1.Start();
        }
        private void pass_textbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                login_button.PerformClick();
            }
        }

        private void bt_Dangky_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Register f3 = new Form_Register();
            f3.ShowDialog();
        }
    }
}
