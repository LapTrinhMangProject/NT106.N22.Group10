using Library_football;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Response
{
    public class Response_player_and_statistics
    {
        Player Player { get; set; }
        Statistics Statistics { get; set; }
    }
    public class Root_Response_player_and_statistics
    {
        public Response_player_and_statistics response { get; set; }
    }
}
