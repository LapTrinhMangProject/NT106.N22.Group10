using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Library_football
{
    public class Statistics
    {
        public Team Team { get; set; }
        public League League { get; set; }
        public Games Games { get; set; }
        public Substitutes Substitutes { get; set; }
        public Shots Shots { get; set; }
        public Goals Goals { get; set; }
        public Passes Passes { get; set; }
        public Tackles Tackles { get; set; }
        public Duels Duels { get; set; }
        public Dribbles Dribbles { get; set; }
        public Fouls Fouls { get; set; }
        public Cards Cards { get; set; }
        public Penalty Penalty { get; set; }
    }
    public class Games
    {
        public int Appearances { get; set; }
        public int Lineups { get; set; }
        public int Minutes { get; set; }
        public int? Number { get; set; }
        public string Position { get; set; }
        public float? Rating { get; set; }
        public bool Captain { get; set; }
    }

    public class Substitutes
    {
        public int In { get; set; }
        public int Out { get; set; }
        public int Bench { get; set; }
    }

    public class Shots
    {
        public int? Total { get; set; }
        public int? On { get; set; }
    }

    public class Goals
    {
        public int Total { get; set; }
        public int Conceded { get; set; }
        public int? Assists { get; set; }
        public int? Saves { get; set; }
    }

    public class Passes
    {
        public int? Total { get; set; }
        public int? Key { get; set; }
        public float? Accuracy { get; set; }
    }

    public class Tackles
    {
        public int? Total { get; set; }
        public int? Blocks { get; set; }
        public int? Interceptions { get; set; }
    }

    public class Duels
    {
        public int? Total { get; set; }
        public int? Won { get; set; }
    }

    public class Dribbles
    {
        public int? Attempts { get; set; }
        public int? Success { get; set; }
        public int? Past { get; set; }
    }

    public class Fouls
    {
        public int? Drawn { get; set; }
        public int? Committed { get; set; }
    }

    public class Cards
    {
        public int Yellow { get; set; }
        public int YellowRed { get; set; }
        public int Red { get; set; }
    }

    public class Penalty
    {
        public int? Won { get; set; }
        public int? Committed { get; set; }
        public int Scored { get; set; }
        public int Missed { get; set; }
        public int? Saved { get; set; }
    }
}
