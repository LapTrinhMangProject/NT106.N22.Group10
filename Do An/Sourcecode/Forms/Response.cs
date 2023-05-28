using communicate_client_server;
using Get_response_using_API;
using Library_football;
using Newtonsoft.Json;
using ReponseJsonDataStructure;
using SQL_Connection;
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

namespace Communicate
{
    public class Response
    {
        NetworkStream stream;
        API api = new API();
        SQL_user sqlUser = new SQL_user();
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
                            login.reponseStanding = null;
                            login._league = sqlUser.Get_Name_leagues();
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
