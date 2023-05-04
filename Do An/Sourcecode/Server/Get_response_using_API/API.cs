using Library_football;
using Newtonsoft.Json;
using Response;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Get_response_using_API
       
{
    
    public class API
    {
       public Root_Response_player_and_statistics player_and_statistics = new Root_Response_player_and_statistics();

        public async void Get_all_players_from_league(string league_id,string season_id=null)
        {
            var client = new HttpClient();

            Root_page page_from_API;
            FileStream myfile = new FileStream("test.txt", FileMode.Create, FileAccess.Write);
            StreamWriter writerr = new StreamWriter(myfile);
            int page_current = 1; 
            do
            {
                {
                    Root_Response_player_and_statistics player_and_statistics;
                    if (season_id == null)
                    {
                        season_id = (DateTime.Now.Year - 1).ToString();
                    }
                    HttpRequestMessage request = new HttpRequestMessage
                    {
                        Method = HttpMethod.Get,
                        RequestUri = new Uri($"https://api-football-v1.p.rapidapi.com/v3/players?league={league_id}&season={season_id}&page={page_current}"),
                        Headers =
    {
        { "X-RapidAPI-Key", "759c532019msh63e52ce5ea468afp113769jsnc64419692369" },
        { "X-RapidAPI-Host", "api-football-v1.p.rapidapi.com" },
    },
                    };
                    using (var response = await client.SendAsync(request))
                    {
                        response.EnsureSuccessStatusCode();
                        var body = await response.Content.ReadAsStringAsync();
                        player_and_statistics = JsonConvert.DeserializeObject<Root_Response_player_and_statistics>(body);
                        page_from_API = JsonConvert.DeserializeObject<Root_page>(body);
                    }


                    for (int i = 0; i < player_and_statistics.response.Length; i++)
                    {
                        int id = player_and_statistics.response[i].Player.id;
                        string name = player_and_statistics.response[i].Player.name;
                        writerr.WriteLine($"insert into player values({id},'{name}')");
                    }
                    await Task.Delay(1000);
                }
                page_current++;
            } while (page_current!=page_from_API.paging.total);
            writerr.Flush();
            
        MessageBox.Show("done");
        }
      public async Task<Root_Response_player_and_statistics> Get_Specific_player(string player_id,string league_id=null,string season_id = null)
        {
            if (season_id == null)
            {
                season_id = (DateTime.Now.Year - 1).ToString();
            }
            var client = new HttpClient();

            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"https://api-football-v1.p.rapidapi.com/v3/players?id={player_id}&league={league_id}&season={season_id}"),
                Headers =
    {
        { "X-RapidAPI-Key", "759c532019msh63e52ce5ea468afp113769jsnc64419692369" },
        { "X-RapidAPI-Host", "api-football-v1.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                player_and_statistics = JsonConvert.DeserializeObject<Root_Response_player_and_statistics>(body);
                return player_and_statistics;
            }
        }
      
    }
}
