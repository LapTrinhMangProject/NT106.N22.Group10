using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Response
{
    public class Page
    {
        public int current { get; set; }
        public int total { get; set; }
    }
    public class Root_page
    {
        public Page paging { get; set; }
    }
}
