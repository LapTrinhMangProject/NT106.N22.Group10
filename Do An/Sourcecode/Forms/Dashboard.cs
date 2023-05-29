using Get_response_using_API;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Get_response_using_API;
using ResponseDataStructure;
using System.IO;
using Communicate;
using System.Net;
using Library_football;
using Newtonsoft.Json;

namespace Forms
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }
        Request request;
        public Dashboard(Root_Reponse_standing reponseStanding, Request request)
        {
            InitializeComponent();
            this.responseStanding = reponseStanding;
            this.request = request;
        }

        Root_Reponse_standing responseStanding = new Root_Reponse_standing();

        private void Dashboard_Load(object sender, EventArgs e)
        {
            foreach (var index in responseStanding.response[0].league.standings[0])
            {
                standing_listbox.Items.Add(index.Rank + " " + index.Team.Name + "Point: " + index.Points);
            }
            string urlLogo = responseStanding.League.logo;
            Display_Photo(urlLogo);
            void Display_Photo(string url)
            {
                WebClient client = new WebClient();
                byte[] imageData = client.DownloadData(url);
                MemoryStream ms = new MemoryStream(imageData);
                Bitmap image = new Bitmap(ms);
                logo_picturebox.SizeMode = PictureBoxSizeMode.StretchImage;
                logo_picturebox.Image = image;
            }
        }

        private void find_player_button_Click(object sender, EventArgs e)
        {
            League league = responseStanding.League;
            string jsonData = JsonConvert.SerializeObject(league);
            string payload = "00001" + jsonData;
            request.Send(payload);
        }

        private void topscore_button_Click(object sender, EventArgs e)
        {
            // request.Send("00010");
        }

        private void find_teams_button_Click(object sender, EventArgs e)
        {
            League league = responseStanding.League;
            string jsonData = JsonConvert.SerializeObject(league);
            string payload = "00011" + jsonData;
            request.Send(payload);
        }
    }
}
