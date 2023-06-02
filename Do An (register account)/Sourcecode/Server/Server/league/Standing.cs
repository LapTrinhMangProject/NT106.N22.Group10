using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_football
{
    public class TeamStanding
    {
        public int Rank { get; set; }
        public TeamData Team { get; set; }
        public int Points { get; set; }
        public int GoalsDiff { get; set; }
        public string Group { get; set; }
        public string Form { get; set; }
        public string Status { get; set; }
        public string Description { get; set; }
        public StandingData All { get; set; }
        public StandingData Home { get; set; }
        public StandingData Away { get; set; }
        public DateTime Update { get; set; }
    }

    public class TeamData
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Logo { get; set; }
    }

    public class StandingData
    {
        public int Played { get; set; }
        public int Win { get; set; }
        public int Draw { get; set; }
        public int Lose { get; set; }
        public GoalsData Goals { get; set; }
    }

    public class GoalsData
    {
        public int For { get; set; }
        public int Against { get; set; }
    }
    public class StandingOfLeagues
    {
        public List<List<TeamStanding>> standings { get; set; }
    }

}
