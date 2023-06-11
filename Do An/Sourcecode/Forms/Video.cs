using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AxWMPLib;
using JellyFinAPI;
using WMPLib;

namespace Forms
{
    public partial class Video : Form
    {
        public Video()
        {
            InitializeComponent();
        }
        private HttpClient _httpClient = new HttpClient();
        private void Video_Load(object sender, EventArgs e)
        {
            Jellyfin jellyfin = new Jellyfin();
            jellyfin.GetList();
            foreach (var index in Jellyfin.requestStreamItems)
            {
                listBox1.Items.Add(index.Key);
            }



        }
        public void TestStreaming(string streamUrl)
        {
            axWindowsMediaPlayer1.URL = null;
            axWindowsMediaPlayer1.URL = "memory://" + streamUrl;
            var media = axWindowsMediaPlayer1.newMedia(streamUrl);
            axWindowsMediaPlayer1.currentPlaylist.appendItem(media);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            TestStreaming(Jellyfin.requestStreamItems[listBox1.SelectedItems[0].ToString()]);

        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {
        }
    }
}
