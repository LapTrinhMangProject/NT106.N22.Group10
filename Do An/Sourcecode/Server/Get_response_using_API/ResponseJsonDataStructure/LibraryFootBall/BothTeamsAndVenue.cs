using ResponseDataStructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace LibraryFootBall
{
    public class SQL_BothTeamAndVenue
    {
        public List<Team> _teams { get; set; }
        public Root_teams_and_venue teamAndvenue { get; set; }
        public SQL_BothTeamAndVenue(List<Team> _teams, Root_teams_and_venue teamAndVenue)
        {
            this._teams = _teams;
            this.teamAndvenue = teamAndVenue;
        }
    }
}
