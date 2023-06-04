using LibraryFootBall;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponseDataStructure
{
    public class LeagueWhoSessionIsRunning
    {
        public League league = new League();
        public Country country = new Country();
        public Season season = new Season();
    }
    public class RootLeagueWhoSessionIsRunning
    {
        public List<LeagueWhoSessionIsRunning> response { get; set; }
    }

}
