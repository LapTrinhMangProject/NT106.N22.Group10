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
using WMPLib;

namespace Forms
{
    public partial class Video : Form
    {
        public Video()
        {
            InitializeComponent();
        }
        public Video(Dictionary<string, string> _linkStream)
        {
            this._linkStream = _linkStream;
            InitializeComponent();
        }
        Dictionary<string, string> _linkStream = new Dictionary<string, string>();
        private HttpClient _httpClient = new HttpClient();
        private void Video_Load(object sender, EventArgs e)
        {
            foreach (var index in _linkStream)
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
            TestStreaming(_linkStream[listBox1.SelectedItems[0].ToString()]);

        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {
        }
    }
}
