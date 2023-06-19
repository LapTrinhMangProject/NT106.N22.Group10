using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using ResponseDataStructure;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;

namespace Forms
{
    public partial class Assist_Form : Form
    {
        public Assist_Form()
        {
            InitializeComponent();
        }
        public Assist_Form(Root_Response_Player_and_Statistic playerAndStat)
        {
            InitializeComponent();
            this._topAssist = playerAndStat.response;
            foreach (var index in _topAssist)
            {
                assist_listbox.Items.Add($"{index.Statistics[0].Goals.Assists}            {index.Player.name}");

            }
        }
        Response_player_and_statistics[] _topScore;
        Response_player_and_statistics[] _topAssist;
        Response_player_and_statistics[] _topYellow;
        Response_player_and_statistics[] _topRed;
        private void assist_listbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void assist_listbox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // Get the index of the item that was double-clicked
            int clickedIndex = assist_listbox.IndexFromPoint(e.Location);
            string imageUrl = this._topAssist[clickedIndex].Player.photo;
            // Display the image in the picture box
            // Create a request for the URL
            WebRequest request = WebRequest.Create(imageUrl);

            // Get the response
            using (WebResponse response = request.GetResponse())
            {
                // Get the response stream
                using (Stream stream = response.GetResponseStream())
                {
                    // Create an image object from the stream
                    Image image = Image.FromStream(stream);

                    // Set the image in the picture box
                    image_player.Image = image;
                }
            }
        }

        private void Assist_Form_Load(object sender, EventArgs e)
        {

        }
    }
    
}
