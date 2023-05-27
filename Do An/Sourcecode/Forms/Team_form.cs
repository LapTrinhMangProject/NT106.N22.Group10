using Get_response_using_API;
using Library_football;
using ReponseJsonDataStructure;
using SQL_Connection;
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
        public Team_form(List<Team> _teams,Root_teams_and_venue teamAndVenue) 
        {
            InitializeComponent();
            this._teams = _teams;
            this.teamsAndVenue = teamAndVenue;
        }
        public Team_form(List<Team> _team)
        {
            InitializeComponent();
            this._teams = _team;
        }
        string leagueId; 
        Root_teams_and_venue teamsAndVenue = new Root_teams_and_venue();
        List<Team> _teams = new List<Team>();
        private async void Team_form_Load(object sender, EventArgs e)
        {
            foreach(var index in _teams)
            {
                teams_listsbox.Items.Add(index.name);   
            }
            Display_All(0);
            textBox1.Focus();
        }
        void Display_All(int index)
        {
            infor_statistic_listbox.Items.Clear();
            infor_teams_listsbox.Items.Clear();
            string url_image = teamsAndVenue.response[index].team.logo;
            Display_Photo(url_image);
            Display_Infor_Team(index);
        }
        void Display_Photo(string url)
        {
            WebClient client = new WebClient();
            byte[] imageData = client.DownloadData(url);
            MemoryStream ms = new MemoryStream(imageData);
            Bitmap image = new Bitmap(ms);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = image;
        }
        void Display_Infor_Team(int index)
        {
            infor_teams_listsbox.Items.Clear();
            infor_teams_listsbox.Items.Add($"Tên đội: {teamsAndVenue.response[index].team.name}");
            infor_teams_listsbox.Items.Add($"Ki hiệu: {teamsAndVenue.response[index].team.code}");
            infor_teams_listsbox.Items.Add($"Thành lập: {teamsAndVenue.response[index].team.founded}");
            infor_teams_listsbox.Items.Add($"Quốc gia: {teamsAndVenue.response[index].team.country}");
            infor_teams_listsbox.Items.Add($"Đội tuyển quốc gia: {teamsAndVenue.response[index].team.national}");
            infor_teams_listsbox.Items.Add($"Sân vận động: {teamsAndVenue.response[index].venue.name}");
            infor_teams_listsbox.Items.Add($"Sức chứa: {teamsAndVenue.response[index].venue.capacity}");
            infor_teams_listsbox.Items.Add($"Địa chỉ: {teamsAndVenue.response[index].venue.address}");
            infor_teams_listsbox.Items.Add($"Thành phố: {teamsAndVenue.response[index].venue.city}");



        }
        void Display_Statistic_Team(int index)
        {
            infor_statistic_listbox.Items.Clear();
            infor_statistic_listbox.Items.Add(teamsAndVenue.response[index]);
        }
      
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void teams_listsbox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            for (int index = 0; index < teamsAndVenue.response.Length; index++)
                if (teamsAndVenue.response[index].team.name == teams_listsbox.SelectedItems[0].ToString())
                    Display_All(index);
                    


  
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            teams_listsbox.Items.Clear();
            SQL_user userSql = new SQL_user();
            foreach (var index in userSql.Get_Teams(textBox1.Text.ToString()))
            {
                teams_listsbox.Items.Add(index.name);
            }
        }
    }
}
