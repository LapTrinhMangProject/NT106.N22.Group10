using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Apis.Services;
using Google.Apis.YouTube.v3;
using System.Windows.Forms;

namespace async_api
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            
        }

        private async void Search_Click(object sender, EventArgs e)
        {
            var service = new YouTubeService(new BaseClientService.Initializer()
            {
                ApiKey = "AIzaSyCuluNp5CtyBPK6JixKotUqpG_AogtjnTE"
            });
            var request = service.Videos.List("snippet");
            request.Chart = VideosResource.ListRequest.ChartEnum.MostPopular;
            request.RegionCode = "vn";

            var results = await request.ExecuteAsync();
            if (results.Items.Count <= 0)
            {
                rich_tb.AppendText("No videos");
            }

            foreach (var video in results.Items)
            {
                rich_tb.AppendText($"{video.Snippet.Title} (https://www.youtube.com/watch?v={video.Id}");
            }
        }
    }
}
