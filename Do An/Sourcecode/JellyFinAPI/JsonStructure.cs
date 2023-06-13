using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JellyFinAPI
{
    public class ResponseJsonStructure
    {
        public List<item> items = new List<item>();
    }
    public class item
    {
        public string name { get; set; }
        public string id { get; set; }
    }
}
