using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library_football;

namespace ReponseJsonDataStructure
{

    public class root_league
    {
        public response_league[] response { get; set; }
    }
    public class response_league
    {
        public League league { get; set; }
        public Country country { get; set; }
        public Season season { get; set; }
    }
}
