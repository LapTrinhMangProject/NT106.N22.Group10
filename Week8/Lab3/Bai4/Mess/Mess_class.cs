using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using Newtonsoft.Json;

namespace TCP_Connection
{
    public class Mess
    {
        public string sender_name { get; set; }
        public string recipient_name { get; set; }
        public string body { get; set; }
    }
  
}
