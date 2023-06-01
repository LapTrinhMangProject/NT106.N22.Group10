using Library_football;
using Newtonsoft.Json;
using ResponseDataStructure;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows.Forms;
using SQL_Connection;
using System.ComponentModel;

namespace Get_response_using_API

{

    public class API
    {
        public Root_Response_Player_and_Statistic playerAndstatistic = new Root_Response_Player_and_Statistic();
        public Root_Reponse_standing responseStanding = new Root_Reponse_standing();
        public async Task<List<Root_Response_Player_and_Statistic>> Get_all_players_from_league(string leagueId, string seasonId = null)
        {
            List<Root_Response_Player_and_Statistic> _responsePlayerAndStatistic = new List<Root_Response_Player_and_Statistic>();
            var client = new HttpClient();
            Root_page page_from_API;
            int page_current = 1;
            do
            {
                {
                    Root_Response_Player_and_Statistic player_and_statistics;
                    if (seasonId == null)
                    {
                        seasonId = (DateTime.Now.Year - 1).ToString();
                    }
                    HttpRequestMessage request = new HttpRequestMessage
                    {
                        Method = HttpMethod.Get,
                        RequestUri = new Uri($"https://api-football-v1.p.rapidapi.com/v3/players?league={leagueId}&season={seasonId}&page={page_current}"),
                        Headers =
    {
        { "X-RapidAPI-Key", ConfigurationManager.AppSettings["API_key"] },
        { "X-RapidAPI-Host", "api-football-v1.p.rapidapi.com" },
    },
                    };
                    using (var response = await client.SendAsync(request))
                    {
                        response.EnsureSuccessStatusCode();
                        var body = await response.Content.ReadAsStringAsync();
                        player_and_statistics = JsonConvert.DeserializeObject<Root_Response_Player_and_Statistic>(body);
                        _responsePlayerAndStatistic.Add(player_and_statistics);
                        page_from_API = JsonConvert.DeserializeObject<Root_page>(body);
                    }

                    await Task.Delay(2000);
                }
                page_current++;
            } while (page_current != page_from_API.paging.total);
            return _responsePlayerAndStatistic;
        }
        public async Task<Root_Response_Player_and_Statistic> Get_Specific_player(string playerId, string leagueId = null, string seasonId = null)
        {
            if (seasonId == null)
            {
                seasonId = (DateTime.Now.Year - 1).ToString();
            }
            var client = new HttpClient();

            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"https://api-football-v1.p.rapidapi.com/v3/players?id={playerId}&league={leagueId}&season={seasonId}"),
                Headers =
    {
        { "X-RapidAPI-Key", ConfigurationManager.AppSettings["API_key"] },
        { "X-RapidAPI-Host", "api-football-v1.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                playerAndstatistic = JsonConvert.DeserializeObject<Root_Response_Player_and_Statistic>(body);
                return playerAndstatistic;
            }
        }
        public async Task<Root_Reponse_standing> Get_Standing(string leagueId)
        {

            var client = new HttpClient();

            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"https://api-football-v1.p.rapidapi.com/v3/standings?season=2022&league={leagueId}"),
                Headers =
    {
        { "X-RapidAPI-Key", ConfigurationManager.AppSettings["API_key"] },
        { "X-RapidAPI-Host", "api-football-v1.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                responseStanding = JsonConvert.DeserializeObject<Root_Reponse_standing>(body);
                return responseStanding;
            }
        }
        public async Task<Root_Response_Player_and_Statistic> Get_Top_Score(string leagueId)
        {
            Root_Response_Player_and_Statistic responsePlayerAndstatistic = new Root_Response_Player_and_Statistic();
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"https://api-football-v1.p.rapidapi.com/v3/players/topscorers?league={leagueId}&season=2022"),
                Headers =
    {
        { "X-RapidAPI-Key", ConfigurationManager.AppSettings["API_key"] },
        { "X-RapidAPI-Host", "api-football-v1.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                responsePlayerAndstatistic = JsonConvert.DeserializeObject<Root_Response_Player_and_Statistic>(body);
            }
            return responsePlayerAndstatistic;
        }
        public async Task<Root_Response_Player_and_Statistic> Get_Top_Assists(string leagueId)
        {
            Root_Response_Player_and_Statistic responsePlayerAndStatistic = new Root_Response_Player_and_Statistic();
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"https://api-football-v1.p.rapidapi.com/v3/players/topassists?league={leagueId}&season=2022"),
                Headers =
    {
        { "X-RapidAPI-Key", ConfigurationManager.AppSettings["API_key"] },
        { "X-RapidAPI-Host", "api-football-v1.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                responsePlayerAndStatistic = JsonConvert.DeserializeObject<Root_Response_Player_and_Statistic>(body);
            }
            return responsePlayerAndStatistic;
        }
        public async Task<Root_Response_Player_and_Statistic> Get_Top_Red_Cards(string leagueId)
        {
            Root_Response_Player_and_Statistic responsePlayerAndStatistic = new Root_Response_Player_and_Statistic();
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"https://api-football-v1.p.rapidapi.com/v3/players/topredcards?league={leagueId}&season=2022"),
                Headers =
    {
        { "X-RapidAPI-Key", ConfigurationManager.AppSettings["API_key"] },
        { "X-RapidAPI-Host", "api-football-v1.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                responsePlayerAndStatistic = JsonConvert.DeserializeObject<Root_Response_Player_and_Statistic>(body);
            }
            return responsePlayerAndStatistic;
        }
        public async Task<Root_Response_Player_and_Statistic> Get_Top_Yellow_Cards(string leagueId)
        {
            Root_Response_Player_and_Statistic responsePlayerAndStatistic = new Root_Response_Player_and_Statistic();
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"https://api-football-v1.p.rapidapi.com/v3/players/topyellowcards?league=39&season=2022"),
                Headers =
    {
        { "X-RapidAPI-Key", ConfigurationManager.AppSettings["API_key"] },
        { "X-RapidAPI-Host", "api-football-v1.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                responsePlayerAndStatistic = JsonConvert.DeserializeObject<Root_Response_Player_and_Statistic>(body);
            }
            return responsePlayerAndStatistic;
        }
        public async Task<Root_teams_and_venue> Get_Teams_from_Leagues(League league)
        {
            Root_teams_and_venue teamAndVenue = new Root_teams_and_venue();
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"https://api-football-v1.p.rapidapi.com/v3/teams?league={league.id}&season=2022"),
                Headers =
    {
        { "X-RapidAPI-Key", ConfigurationManager.AppSettings["API_key"] },
        { "X-RapidAPI-Host", "api-football-v1.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                teamAndVenue = JsonConvert.DeserializeObject<Root_teams_and_venue>(body);
            }
            teamAndVenue.league = league;
            return teamAndVenue;
        }
        public async Task<List<Team>> Get_Teams_from_Leagues(League league, bool onlyteam = true)
        {
            List<Team> _teams = new List<Team>();
            Root_teams_and_venue teamAndVenue = new Root_teams_and_venue();
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"https://api-football-v1.p.rapidapi.com/v3/teams?league={league.id}&season=2022"),
                Headers =
    {
        { "X-RapidAPI-Key", ConfigurationManager.AppSettings["API_key"] },
        { "X-RapidAPI-Host", "api-football-v1.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                teamAndVenue = JsonConvert.DeserializeObject<Root_teams_and_venue>(body);
            }
            foreach (var index in teamAndVenue.response)
                _teams.Add(index.team);
            return _teams;
        }
        public async Task<RootLeagueWhoSessionIsRunning> GetLeagueWhoSessionIsRunning(string countryCode)
        {
            RootLeagueWhoSessionIsRunning rootLeagueWhoSessionIsRunning = new RootLeagueWhoSessionIsRunning();
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"https://api-football-v1.p.rapidapi.com/v3/leagues?code={countryCode}&season=2022&type=league&current=true"),
                Headers =
    {
        { "X-RapidAPI-Key", ConfigurationManager.AppSettings["API_key"] },
        { "X-RapidAPI-Host", "api-football-v1.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                rootLeagueWhoSessionIsRunning = JsonConvert.DeserializeObject<RootLeagueWhoSessionIsRunning>(body);
                FileStream file = new FileStream("LeagueActive.txt", FileMode.Create, FileAccess.Write);
                StreamWriter writer = new StreamWriter(file);
                foreach (var index in rootLeagueWhoSessionIsRunning.response)
                {
                    string nameLeague = index.league.name;
                    string countryName = index.country.name;
                    string query = $"insert into active_list values('{nameLeague}','{countryName}')";
                    SQL_user sqlUser = new SQL_user();
                    sqlUser.CustomAddRecord(query);
                }
            }
            MessageBox.Show("done");
            return rootLeagueWhoSessionIsRunning;
        }

    }
}
