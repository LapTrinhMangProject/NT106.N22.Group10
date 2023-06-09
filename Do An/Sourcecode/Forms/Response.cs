﻿using communicate_client_server;
using API;
using LibraryFootBall;
using Newtonsoft.Json;
using ResponseDataStructure;
using SQLConnection;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JellyFinAPI;

namespace Communicate
{
    public class Response
    {
        NetworkStream stream;
        ApiUser api = new ApiUser();
        SqlUser sqlUser = new SqlUser();
        string payload = null;
        string jsonData = null;
        public Response(NetworkStream stream)
        {
            this.stream = stream;
        }
        public void Check_Credential(string jsonData, ref string result, string ipAddress)
        {
            string typeUser = null;
            Login login = JsonConvert.DeserializeObject<Login>(jsonData);
            if (sqlUser.Check_Credential(login.username, login.password, ref typeUser))
            {
                login.valid = true;
                login.typeUser = typeUser; ;
                result = $"{ipAddress} Đăng nhập thành công với User: {login.username}";
            }
            else
            {
                login.valid = false;
                result = $"{ipAddress} gửi sai thông tin đăng nhập ";
            }
            Response();
            void Response()
            {
                payload = null;
                jsonData = null;
                if (login.valid == true)
                    switch (login.typeUser)
                    {
                        case "normal":
                            login._league = sqlUser.Get_Name_leagues();
                            login.valid = true;
                            break;
                        case "administrator":
                            login._league = sqlUser.Get_Name_leagues();
                            login._leagueWhoSessionIsRunning = sqlUser.GetLeagueWhoSessionIsRunning();
                            break;
                    }
                jsonData = JsonConvert.SerializeObject(login);
                payload = "00000" + jsonData;
                Send(payload);
            }

        }
        public async void Get_Team_Standing(League league)
        {
            Root_Reponse_standing responseTeamStanding = await api.Get_Standing(league.id.ToString());
            responseTeamStanding.League = league;
            string jsonData = JsonConvert.SerializeObject(responseTeamStanding);
            payload = "00100" + jsonData;
            Send(payload);
        }
        public void Get_All_Players(League league)
        {
            List<Player> _player = sqlUser.Get_Players(league.name);
            _player[0].League = league;
            string jsonData = JsonConvert.SerializeObject(_player);
            string payload = "00001" + jsonData;
            Send(payload);
        }
        public async void Get_All_Teams_And_venue(League league)
        {
            List<Team> _teams = sqlUser.Get_Teams(league.name);
            Root_teams_and_venue teamAndVenue = await api.Get_Teams_from_Leagues(league);
            SQL_BothTeamAndVenue data = new SQL_BothTeamAndVenue(_teams, teamAndVenue);
            payload = "00011" + JsonConvert.SerializeObject(data);
            Send(payload);
        }
        public async Task<String> Get_Top_Score(string a)
        {
            Root_Response_Player_and_Statistic playerAndStat = await api.Get_Top_Score(a);
            string jsonData = JsonConvert.SerializeObject(playerAndStat);
            payload = "11111" + jsonData;
            return payload;
        }
        public async Task<String> Get_Assist(string a)
        {
            Root_Response_Player_and_Statistic playerAndStat = await api.Get_Top_Assists(a);
            string jsonData = JsonConvert.SerializeObject(playerAndStat);
            payload = "10000" + jsonData;
            return payload;
        }
        public async Task<String> Get_RedCards(string a)
        {
            Root_Response_Player_and_Statistic playerAndStat = await api.Get_Top_Red_Cards(a);
            string jsonData = JsonConvert.SerializeObject(playerAndStat);
            payload = "10001" + jsonData;
            return payload;
        }
        public void GetListVideo()
        {
            Dictionary<string, string> _linkStream = new Dictionary<string, string>();
            Jellyfin jellyfin = new Jellyfin();
            jellyfin.GetList();
            foreach (var index in Jellyfin.requestStreamItems)
                _linkStream[index.Key] = index.Value;
            string jsonData = JsonConvert.SerializeObject(_linkStream);
            payload = "00111" + jsonData;
            Send(payload);
        }

        public void Send(string payload)
        {
            byte[] header = new byte[4];
            byte[] buffer = Encoding.UTF8.GetBytes(payload);
            header = BitConverter.GetBytes(buffer.Length);
            stream.Write(header, 0, 4);
            stream.Write(buffer, 0, buffer.Length);
            stream.Flush();
        }
    }
}
