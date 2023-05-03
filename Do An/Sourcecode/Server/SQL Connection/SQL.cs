using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Library_football;
namespace SQL_Connection
{
    public class SQL_user
    {
        string connectionString = "Data Source=LAPTOP-68GCST1P\\SQLEXPRESS02;Initial Catalog = API_football; Integrated Security = True";
        SqlConnection sqlConnection = null;
        SqlCommand command = null;
        SqlDataReader reader;
        public SQL_user()
        {
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
        }
        public List<League> Get_Name_leagues(string name =null)
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
                _leagues.Add(league);
            }
            return _leagues;
        }
        public List<Player> Get_Players(string name = null) 
        {
            List<Player> _players = new List<Player>();
            string query = $"select * from player where name like '%{name}%'";
            command = new SqlCommand(query, sqlConnection);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                Player player = new Player();
                player.id = reader.GetInt32(0);
                player.name = reader.GetString(1); 
                _players.Add(player);
            }
            return _players;
        }
    }
    }

