﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai1
{
    public partial class Bai1_form : Form
    {
        public Bai1_form()
        {
            InitializeComponent();
        }

        private void udpserver_Click(object sender, EventArgs e)
        {
            UDPServer serverForm = new UDPServer();
            serverForm.Show();
        }

        private void udpclient_Click(object sender, EventArgs e)
        {
            UDPClient clientForm = new UDPClient();
            clientForm.Show();
        }

        private void Bai1_form_Load(object sender, EventArgs e)
        {

        }
    }
}
