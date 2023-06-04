using Newtonsoft.Json;
using SQLConnection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Forms;
using API;
using System.ComponentModel.Design.Serialization;
using ResponseDataStructure;
using LibraryFootBall;
using System.Net.Http;

namespace Communicate
{
    public partial class Server_form : Form
    {
        public Server_form()
        {
            InitializeComponent();
        }
        SqlUser sqlUser = new SqlUser();
        ApiUser api = new ApiUser();
        TcpListener server;
        TcpListener serverCheckHealthProbe;

        private async void Server_Load(object sender, EventArgs e)
        {
            Thread thread1 = new Thread(Server_Listener);
            thread1.IsBackground = true;
            thread1.Start();
            Thread thread2 = new Thread(ServerCheckHealthProbe);
            thread2.IsBackground = true;
            thread2.Start();

        }
        public void Server_Listener()
        {
            try
            {
                IPAddress ipAddress = IPAddress.Parse("127.0.0.1");
                server = new TcpListener(IPAddress.Any, 2509);
                server.Start();
                while (true)
                {
                    TcpClient client = server.AcceptTcpClient();
                    client.ReceiveBufferSize = 1048576;
                    client.SendBufferSize = 1048576;
                    Thread thread2 = new Thread(() => Establish(client));

                    thread2.IsBackground = true;
                    thread2.Start();


                }
            }
            catch (Exception e)
            {
                MessageBox.Show($"{e}");
                server.Stop();
            }
        }
        public void ServerCheckHealthProbe()
        {
            try
            {
                serverCheckHealthProbe = new TcpListener(IPAddress.Any, 3004);
                serverCheckHealthProbe.Start();
                while (true)
                {
                    TcpClient client = serverCheckHealthProbe.AcceptTcpClient();
                    this.Invoke(new Action(() =>
                    {
                        listBox1.Items.Add("health check OK");
                    }));
                }
            }
            catch (Exception e)
            {
                MessageBox.Show($"{e}");
                server.Stop();
            }
        }

        void Establish(TcpClient client)
        {
            NetworkStream stream = client.GetStream();
            Response reponse = new Response(stream);
            IPEndPoint remoteEndPoint = (IPEndPoint)client.Client.RemoteEndPoint;
            string ipRemote = remoteEndPoint.Address.ToString();
            this.Invoke(new Action(() =>
            {
                status_listbox.Items.Add($"Nhận kết nối từ {ipRemote}");
            }));
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
                string data = Encoding.UTF8.GetString(buffer, 0, length);
                string jsonData = data.Substring(5);
                string code = data.Substring(0, 5);
                //     MessageBox.Show(jsonData);
                League league = JsonConvert.DeserializeObject<League>(jsonData);
                this.Invoke(new Action(async () =>
                {
                    switch (code)
                    {
                        case "00000":
                            string result = null;
                            reponse.Check_Credential(jsonData, ref result, ipRemote);
                            status_listbox.Items.Add(result);
                            break;
                        case "00001":
                            reponse.Get_All_Players(league);
                            status_listbox.Items.Add($"{ipRemote} Yêu cầu lấy thông tin danh sách cầu thủ");
                            status_listbox.Items.Add($"Trả về danh sách cầu thủ giải đấu {league.name}");
                            break;
                        case "00011":
                            reponse.Get_All_Teams_And_venue(league);
                            status_listbox.Items.Add($"{ipRemote} Yêu cầu lấy thông tin danh sách đội");
                            status_listbox.Items.Add($"Trả về danh sách danh sách đội cho giải đấu {league.name}");
                            break;
                        case "00100":
                            reponse.Get_Team_Standing(league);
                            status_listbox.Items.Add($"{ipRemote} Yêu cầu lấy thông tin bảng xếp hạng cho giải đấu");
                            status_listbox.Items.Add($"Trả về bảng xếp hạng giải đấu {league.name}");
                            break;
                        case "00101":
                            string leagueId = league.id.ToString();
                            status_listbox.Items.Add($"{ipRemote} yêu cầu Thêm giải {league.name}, request API ");
                            var temp = await api.Get_all_players_from_league(leagueId);
                            status_listbox.Items.Add($"Đang cập nhật cầu thủ cho giải đấu {league.name}");
                            foreach (var index in temp)
                                foreach (var player in index.response)
                                    sqlUser.AddPlayers(player);
                            status_listbox.Items.Add($"Cập nhật xong cầu thủ cho giải đấu {league.name}");
                            status_listbox.Items.Add($"Đang cập nhật đội cho giải đấu {league.name}");
                            List<Team> _teams = await api.Get_Teams_from_Leagues(league, true);
                            foreach (var team in _teams)
                                sqlUser.AddTeam(team, league.name);
                            status_listbox.Items.Add($"Cập nhật xong các đội cho giải đấu {league.name}");

                            break;
                    }
                    status_listbox.TopIndex = status_listbox.Items.Count - 1;
                    status_listbox.Refresh();
                }));
            }



        }

        private void status_listbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

