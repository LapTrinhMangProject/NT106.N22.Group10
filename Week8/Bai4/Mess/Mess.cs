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
using Microsoft.Win32;
using System.Security.Cryptography;

namespace TCP_Connection
{
    public class Mess
    {
        public string sender_name { get; set; }
        public string recipient_name { get; set; }
        public string body { get; set; }
        public file_transfer file { get; set; }
       public Mess(){
            file = new file_transfer();

            }
    }
    public class file_transfer
    {
        public string fileName { get; set; }
        public List<string> content = new List<string>();
        public file_transfer()
        {

        }
    }
}
