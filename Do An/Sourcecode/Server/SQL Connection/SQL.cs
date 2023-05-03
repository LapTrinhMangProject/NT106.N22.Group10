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
        string connectionString;
        SqlConnection sqlConnection = null;
        SqlCommand command = null;
        public SQL_user(string connectionString)
        {
            this.connectionString = connectionString;
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
        }
        public List<League> Get_Name_leagues(string name)
        {
            string query = $"SELECT * from leagues where name like '%{name}%'";
            command = new SqlCommand(query, sqlConnection);
            SqlDataReader reader = command.ExecuteReader();
            List<League> _leagues = new List<League> ();
            while(reader.Read())
            {
                League league = new League();
                league.id = reader.GetInt32(0);
                league.name = reader.GetString(1);
                _leagues.Add( league );
            }

            return _leagues;
        }

    }
}
