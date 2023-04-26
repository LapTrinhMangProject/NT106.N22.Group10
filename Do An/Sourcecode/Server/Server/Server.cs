using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http.Headers;
using System.Net.Http;
using System.IO;
using Response;
using Newtonsoft.Json;
using Library_football;
using Get_response_using_API;
namespace Server
{
    public partial class Server : Form
    {
        public Server()
        {
            InitializeComponent();
        }

        private void Server_Load(object sender, EventArgs e)
        {

        }

        Root_teams_and_venue teams_and_venues;
        private  void button1_Click(object sender, EventArgs e)
        {
           API api = new API();
          api.Get_all_players_from_league("39");
        }
    }
}
