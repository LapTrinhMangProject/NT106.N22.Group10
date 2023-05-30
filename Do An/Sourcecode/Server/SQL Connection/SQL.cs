using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Library_football;
using System.Windows.Forms;
using ResponseDataStructure;

namespace SQL_Connection
{
    public class SQL_user
    {
        // string connectionString = "Data Source=1.54.12.231,1433;Network Library=DBMSSOCN; Initial Catalog=API_football;User ID=laptrinhmang;Password=h?T<e)>5ePtf{P8L;";
        string connectionString = "Server=tcp:databaselaptrinhmang.database.windows.net,1433;Initial Catalog=API_football;Persist Security Info=False;User ID=laptrinhmang;Password=h?T<e)>5ePtf{P8L;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;e";

        SqlConnection sqlConnection = null;
        SqlCommand command = null;
        SqlDataReader reader;
        public SQL_user()
        {
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
        }
        public List<League> Get_Name_leagues(string name = null)
        {
            string query = $"SELECT * from leagues where name like '%{name}%'";
            command = new SqlCommand(query, sqlConnection);
            reader = command.ExecuteReader();
            List<League> _leagues = new List<League>();
            while (reader.Read())
            {
                League league = new League();
                league.id = reader.GetInt32(0);
                league.name = reader.GetString(1);
                league.logo = reader.GetString(2);
                _leagues.Add(league);
            }
            reader.Close();
            return _leagues;
        }
        public List<Player> Get_Players(string leagueName, string namePlayer = null)
        {
            List<Player> _players = new List<Player>();
            string query = $"select * from player where name like '%{namePlayer}%' and league='{leagueName}'";
            command = new SqlCommand(query, sqlConnection);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                Player player = new Player();
                player.id = reader.GetInt32(0);
                player.name = reader.GetString(1);
                _players.Add(player);
            }
            reader.Close();
            return _players;
        }
        public List<Team> Get_Teams(string leagueName, string name = null)
        {
            List<Team> _teams = new List<Team>();
            string query = $"select * from Teams where name like '%{name}%'and league = '{leagueName}'";
            command = new SqlCommand(query, sqlConnection);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                Team team = new Team();
                team.name = reader.GetString(1);
                team.id = reader.GetInt32(0);
                team.code = reader.GetString(2);
                team.country = reader.GetString(3);
                team.founded = reader.GetInt32(4);
                team.logo = reader.GetString(6);
                _teams.Add(team);
            }
            reader.Close();
            return _teams;
        }
        public List<LeagueWhoSessionIsRunning> GetLeagueWhoSessionIsRunning()
        {
            List<LeagueWhoSessionIsRunning> _leagueWhoSessionIsRunning = new List<LeagueWhoSessionIsRunning>();
            string query = "select * from active_list";
            command = new SqlCommand(query, sqlConnection);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                LeagueWhoSessionIsRunning temp = new LeagueWhoSessionIsRunning();
                temp.league.name = reader.GetString(0);
                temp.country.name = reader.GetString(1);
                _leagueWhoSessionIsRunning.Add(temp);
            }
            return _leagueWhoSessionIsRunning;
        }
        public bool Check_Credential(string username, string password, ref string typeUser)
        {
            string query = $"select * from users where username = '{username}' and password ='{password}'";
            command = new SqlCommand(query, sqlConnection);
            reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                reader.Read();
                typeUser = reader.GetString(2);
                reader.Close();
                return true;
            }
            reader.Close();
            return false;


        }
        public void AddTeam(Team team, string leagueName)
        {
            string query = $"insert into teams values({team.id},'{team.name}','{team.code}','{team.country}','{team.founded}','{team.national}','{team.logo}','{leagueName}')";
            command = new SqlCommand(query, sqlConnection);
            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

            }
        }
        public void AddPlayers(Response_player_and_statistics player)
        {
            string query = $"insert into player values({player.Player.id},'{player.Player.name}','{player.Statistics[0].Team.name}','{player.Statistics[0].League.name}'";
            command = new SqlCommand(query, sqlConnection);
            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

            }
        }
        public void CustomAddRecord(string query)
        {
            command = new SqlCommand(query, sqlConnection);
            command.ExecuteNonQuery();
        }
        public void AddAllFromNewLeague(List<Player> _player, List<Team> teams, League league)
        {

        }


    }
}

