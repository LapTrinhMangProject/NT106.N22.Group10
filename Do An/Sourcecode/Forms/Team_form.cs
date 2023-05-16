using Get_response_using_API;
using Response;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms
{
    public partial class Team_form : Form
    {
        public Team_form()
        {
            InitializeComponent();
        }
        public Team_form(string leagueId)
        {
            InitializeComponent();
            this.leagueId = leagueId;

        }
        string leagueId; 
        private async void Team_form_Load(object sender, EventArgs e)
        {
            API aPI = new API();
            Root_teams_and_venue teamsAndVenue = new Root_teams_and_venue();
            teamsAndVenue = await aPI.Get_Teams_from_Leagues("39");
            foreach(var index in teamsAndVenue.response)
            {
                teams_listsbox.Items.Add(index.team.name);   
            }
            string url_image = teamsAndVenue.response[0].team.logo;
            Display_Photo(url_image);
            Display_Infor_Team();
            void Display_Photo(string url)
            {
                WebClient client = new WebClient();
                byte[] imageData = client.DownloadData(url);
                MemoryStream ms = new MemoryStream(imageData);
                Bitmap image = new Bitmap(ms);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1.Image = image;
            }
            
            void Display_Infor_Team()
            {
                infor_teams_listsbox.Items.Clear();
                infor_teams_listsbox.Items.Add($"Tên đội: {teamsAndVenue.response[0].team.name}");
                infor_teams_listsbox.Items.Add($"Ki hiệu: {teamsAndVenue.response[0].team.code}");
                infor_teams_listsbox.Items.Add($"Thành lập: {teamsAndVenue.response[0].team.founded}");
                infor_teams_listsbox.Items.Add($"Quốc gia: {teamsAndVenue.response[0].team.country}");
                infor_teams_listsbox.Items.Add($"Đội tuyển quốc gia: {teamsAndVenue.response[0].team.national}");
            }
        }
        public async void Display_All_Teams()
        {

        }
    }
}
