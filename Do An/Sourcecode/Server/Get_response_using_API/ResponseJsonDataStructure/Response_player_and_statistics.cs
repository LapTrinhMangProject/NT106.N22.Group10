using LibraryFootBall;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponseDataStructure
{
    public class Response_player_and_statistics
    {
        public Player Player { get; set; }
        public Statistics[] Statistics { get; set; }
    }
    public class Root_Response_Player_and_Statistic
    {
        public Response_player_and_statistics[] response { get; set; }
        public Page paging { get; set; }
    }
}
