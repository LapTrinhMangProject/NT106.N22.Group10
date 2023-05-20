using Library_football;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Response
{
    public class Reponse_Standing
    {
        public StandingOfLeagues league { get; set; }
      
    }
    public class Root_Reponse_standing
    {
        public Reponse_Standing[] response { get; set; }
    }
}
