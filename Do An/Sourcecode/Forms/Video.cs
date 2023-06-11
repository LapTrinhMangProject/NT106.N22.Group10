using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JellyFinAPI;

namespace Forms
{
    public partial class Video : Form
    {
        public Video()
        {
            InitializeComponent();
        }

        private void Video_Load(object sender, EventArgs e)
        {
            Jellyfin jellyfin = new Jellyfin();
            jellyfin.GetList();
            foreach (var index in Jellyfin.requestStreamItems)
            {
                listBox1.Items.Add(index.Key);
            }
        }
    }
}
