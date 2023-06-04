using LibraryFootBall;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponseDataStructure
{
    public class Reponse_Standing
    {
        public StandingOfLeagues league { get; set; }

    }
    public class Root_Reponse_standing
    {
        public Reponse_Standing[] response { get; set; }
        public League League { get; set; }
    }
}
