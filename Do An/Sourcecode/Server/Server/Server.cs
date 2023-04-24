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
namespace Server
{
    public partial class Server : Form
    {
        root_teams_and_venue teams_and_venues;
        public Server()
        {
            InitializeComponent();
        }

        private void Server_Load(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://api-football-v1.p.rapidapi.com/v3/teams?league=39&season=2022"),
                Headers =
    {
        { "X-RapidAPI-Key", "23bef34f7emshb79a95e739f4a1ep1e36cdjsnab3db44eb3eb" },
        { "X-RapidAPI-Host", "api-football-v1.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                MessageBox.Show(body);
                teams_and_venues = JsonConvert.DeserializeObject<root_teams_and_venue>(body);
            }

            FileStream myfile = new FileStream("test.txt", FileMode.Create, FileAccess.Write);

            StreamWriter writerr = new StreamWriter(myfile);

            for(int i = 0;i< teams_and_venues.response.Length; i++)
            {
                int id = teams_and_venues.response[i].team.id;
                string name = teams_and_venues.response[i].team.name;
                string country = teams_and_venues.response[i].team.country;
                int founded = teams_and_venues.response[i].team.founded;
                string code = teams_and_venues.response[i].team.code;
                int is_national = teams_and_venues.response[i].team.national ? 1 : 0;
                string logo = teams_and_venues.response[i].team.logo;
                writerr.WriteLine($"INSERT INTO teams values({id}, '{name}', '{code}', '{country}', '{founded}', {is_national}, '{logo}')");
            }
            writerr.Flush();
            MessageBox.Show("done");
        }
    }
}
