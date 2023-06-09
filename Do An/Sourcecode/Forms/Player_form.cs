﻿using LibraryFootBall;
using SQLConnection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using API;
using ResponseDataStructure;
using System.Net;
using System.IO;
using System.Net.Http;

namespace Forms
{
    public partial class Player_form : Form
    {
        public Player_form()
        {
            InitializeComponent();
        }
        public Player_form(string idPlayer)
        {
            InitializeComponent();
            this.idPlayer = idPlayer;
        }
        public Player_form(List<Player> _player)
        {
            InitializeComponent();
            this._player = _player;
            this.leagueId = _player[0].League.id.ToString();
        }
        List<Player> _player;
        Dictionary<string, string> playerDic = new Dictionary<string, string>();
        string leagueId = null;
        string idPlayer = null;
        private void Player_form_Load(object sender, EventArgs e)
        {
            foreach (Player player in _player)
            {
                list_player_listbox.Items.Add(player.name);
                if (playerDic.ContainsKey(player.name))
                    continue;
                playerDic.Add(player.name, player.id.ToString());
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            list_player_listbox.Items.Clear();
            foreach (var index in _player)
            {
                if (index.name.Contains(find_textbox.Text))
                    list_player_listbox.Items.Add(index.name);
            }
        }

        public async void list_player_listbox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Display_All_Statistic_Of_specific();
        }
        public async void Display_All_Statistic_Of_specific()
        {
            {
                ApiUser aPI = new ApiUser();
                Root_Response_Player_and_Statistic responsePlayer = new Root_Response_Player_and_Statistic();
                string id;
                if (idPlayer != null)
                {
                    id = idPlayer;
                    idPlayer = null;
                }
                else
                    id = playerDic[list_player_listbox.SelectedItems[0].ToString()];
                responsePlayer = await aPI.Get_Specific_player(id, leagueId);
                infor_player_listbox.Items.Clear();
                statistic_1_listbox.Items.Clear();
                statistic2_list_box.Items.Clear();
                Display_basic_infor();
                Display_statistic();

                void Display_basic_infor()
                {
                    infor_player_listbox.Items.Add($"Tên: {responsePlayer.response[0].Player.name}");
                    infor_player_listbox.Items.Add($"Firstname: {responsePlayer.response[0].Player.firstname}");
                    infor_player_listbox.Items.Add($"Lastname : {responsePlayer.response[0].Player.lastname}");
                    infor_player_listbox.Items.Add($"Tuổi: {responsePlayer.response[0].Player.age}");
                    infor_player_listbox.Items.Add($"Ngày sinh: {responsePlayer.response[0].Player.birth.date}");
                    infor_player_listbox.Items.Add($"Nơi sinh: {responsePlayer.response[0].Player.birth.place}");
                    infor_player_listbox.Items.Add($"Quốc gia: {responsePlayer.response[0].Player.birth.country}");
                    infor_player_listbox.Items.Add($"Quốc gia: {responsePlayer.response[0].Player.nationality}");
                    infor_player_listbox.Items.Add($"Cân nặng: {responsePlayer.response[0].Player.weight}");
                    infor_player_listbox.Items.Add("Bị thương: " + (responsePlayer.response[0].Player.injured ? "Có" : "Không"));
                    Display_photo(responsePlayer.response[0].Player.photo);
                    async void Display_photo(string url)
                    {
                        //   WebClient client = new WebClient();
                        // byte[] imageData = client.DownloadData(url);
                        HttpClient client = new HttpClient();
                        byte[] imageData = await client.GetByteArrayAsync(url);
                        MemoryStream ms = new MemoryStream(imageData);
                        Bitmap image = new Bitmap(ms);
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBox1.Image = image;
                    }
                }
                void Display_statistic()
                {
                    statistic_1_listbox.Items.Add($"Tên đội {responsePlayer.response[0].Statistics[0].Team.name}");
                    statistic_1_listbox.Items.Add("Số lần shút: " + responsePlayer.response[0].Statistics[0].Shots.Total.ToString());
                    statistic_1_listbox.Items.Add("Số cú shút trúng đích: " + responsePlayer.response[0].Statistics[0].Shots.On);
                    statistic_1_listbox.Items.Add("Số bàn thắng: " + responsePlayer.response[0].Statistics[0].Goals.Total);
                    statistic_1_listbox.Items.Add("Kiến tạo: " + responsePlayer.response[0].Statistics[0].Goals.Assists);
                    statistic_1_listbox.Items.Add("Tổng đường chuyền: " + responsePlayer.response[0].Statistics[0].Passes.Total);
                    statistic_1_listbox.Items.Add("Đường chuyền quyết định: " + responsePlayer.response[0].Statistics[0].Passes.Key);
                    statistic_1_listbox.Items.Add("chính xác: " + responsePlayer.response[0].Statistics[0].Passes.Accuracy);
                    statistic2_list_box.Items.Add("Số lần rê bóng: " + responsePlayer.response[0].Statistics[0].Dribbles.Attempts);
                    statistic2_list_box.Items.Add("Số lần rê bóng thành công : " + responsePlayer.response[0].Statistics[0].Dribbles.Success);
                    statistic2_list_box.Items.Add("Past: " + responsePlayer.response[0].Statistics[0].Dribbles.Past);



                }

            }
        }
    }
}
