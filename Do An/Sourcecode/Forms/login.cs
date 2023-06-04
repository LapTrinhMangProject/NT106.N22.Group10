using LibraryFootBall;
using ResponseDataStructure;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace communicate_client_server
{
    public class Login
    {
        public string username { get; set; }
        public string password { get; set; }
        public bool valid = false;
        public Root_Reponse_standing reponseStanding = new Root_Reponse_standing();
        public List<League> _league = new List<League>();
        public List<LeagueWhoSessionIsRunning> _leagueWhoSessionIsRunning = new List<LeagueWhoSessionIsRunning>();
        public string typeUser;
        public Login(string username = null, string password = null)
        {
            this.username = username;
            this.password = password;
        }
        public Login(bool valid) { this.valid = valid; }
        public Login()
        {

        }
    }
}
