using communicate_client_server;
using Get_response_using_API;
using Library_football;
using Newtonsoft.Json;
using Response;
using SQL_Connection;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Net.Sockets;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Communicate
{
    public class Reponse
    {
        NetworkStream stream;
        API api= new API();
        SQL_user sqlUser = new SQL_user(); 
        string payload = null;
        string jsonData = null;
        public Reponse(NetworkStream stream)
        {
            this.stream = stream;
        }
        public void Check_Credential(string jsonData)
        {
            Login login = JsonConvert.DeserializeObject<Login>(jsonData);
            if(sqlUser.Check_Credential(login.username, login.password))
                Login_Access(true);
            else 
                Login_Access(false);
            async void Login_Access(bool valid)
        {
            payload = null;
             jsonData = null;
            if (valid == true)
            {
                login.reponseStanding = await api.Get_Standing("39");
                login.valid = true;
            }
            else 
                login.valid =false;
                jsonData = JsonConvert.SerializeObject(login);
                payload = "00000"+jsonData;
                Send(payload);
        }
        }
        public void Get_All_Players()
        {
            List<Player> _player = sqlUser.Get_Players();
            string jsonData = JsonConvert.SerializeObject(_player);
            string payload = "00001" + jsonData;
            Send(payload);
        }
        public async void Get_All_Teams_And_venue()
        {
            List<Team> _teams = sqlUser.Get_Teams();
            Root_teams_and_venue teamAndVenue = await api.Get_Teams_from_Leagues("39");
            SQL_BothTeamAndVenue data = new SQL_BothTeamAndVenue(_teams,teamAndVenue);
            payload = "00011"+JsonConvert.SerializeObject(data);
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
