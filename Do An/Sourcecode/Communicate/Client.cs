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
        public static Dashboard dashboardForm = new Dashboard();
        public static Team_form teamForm = new Team_form();
        public static Player_form playerForm = new Player_form();
        public static Administrator_form administrator = new Administrator_form();
        public static League_form leagueForm = new League_form();
        public static List<IPAddress> _ipAddress = new List<IPAddress>();
        public static Video videoForm;
        public static int index = 0;
        public Client()
        {
            InitializeComponent();
            try
            {
                ipAddress = _ipAddress[index];
            }
            catch
            {
                MessageBox.Show("Không thể kết nối được tới Server, ứng dụng sẽ thoát", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                Application.Exit();
            }
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
                try
                {
                    bytes_read += stream.Read(header, 0, 4);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Server chính hỏng, chuyển sang server phụ");
                    index++;
                    this.Invoke(new Action(() =>
                    {
                        Form1.client.Close();
                        Form1.ReloadClientForm();
                        administrator.Hide();
                        teamForm.Hide();
                        dashboardForm.Hide();
                        playerForm.Hide();
                        leagueForm.Hide();
                        Form1.client.Show();

                    }));
                    return;
                }
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
                                leagueForm = new League_form(login._league, requestUser);
                                Form1.client.Hide();
                                leagueForm.Show();
                            }
                            else if (login.valid && login.typeUser == "administrator")
                            {
                                administrator = new Administrator_form(login, requestUser);
                                Form1.client.Hide();
                                administrator.Show();

                            }
                            else
                                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng", "Lỗi đăng nhập", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                            break;
                        case "00001":
                            List<Player> _player = JsonConvert.DeserializeObject<List<Player>>(jsonData);
                            playerForm = new Player_form(_player);
                            playerForm.Show();
                            break;
                        case "00011":
                            SQL_BothTeamAndVenue dataGeneral = JsonConvert.DeserializeObject<SQL_BothTeamAndVenue>(jsonData);
                            Team_form teamForm = new Team_form(dataGeneral._teams, dataGeneral.teamAndvenue);
                            teamForm.Show();
                            break;
                        case "00100":

                            Root_Reponse_standing responseStanding = JsonConvert.DeserializeObject<Root_Reponse_standing>(jsonData);
                            dashboardForm = new Dashboard(responseStanding, requestUser);
                            leagueForm.Hide();
                            dashboardForm.Show();
                            break;
                        case "00111":
                            Dictionary<string, string> _linkStream = JsonConvert.DeserializeObject<Dictionary<string, string>>(jsonData);
                            Client.videoForm = new Video(_linkStream);
                            Client.videoForm.ShowDialog();
                            break;
                        case "11111":
                            Root_Response_Player_and_Statistic playerAndStat = JsonConvert.DeserializeObject<Root_Response_Player_and_Statistic>(jsonData);
                            Topscore_form newForm = new Topscore_form(playerAndStat);
                            newForm.Show();
                            break;

                    }
                }));
            }
        }
        private void Client_Load(object sender, EventArgs e)
        {
            try
            {
                client.Connect(ipAddress, 2509);
            }
            catch (SocketException ex)
            {
                MessageBox.Show("Lỗi Server chính, chuyển sang Server phụ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                index++;
                try
                {
                    ipAddress = _ipAddress[index];
                    client.Connect(ipAddress, 2509);
                }
                catch (SocketException ei)
                {
                    MessageBox.Show("Không Thể kết nối tới Server, đóng ứng dụng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    Application.Exit();
                    return;
                }
            }

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
