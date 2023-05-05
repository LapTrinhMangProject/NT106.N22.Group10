using communicate_client_server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Communicate
{
    public partial class Server : Form
    {
        public Server()
        {
            InitializeComponent();
        }

      

        private void Server_Load(object sender, EventArgs e)
        {
            Com_Server server = new Com_Server();
            Thread thread1 = new Thread(server.Server_Listener);
            thread1.IsBackground = true;
            thread1.Start();
        }
    }
}
