using ResponseDataStructure;
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
    public partial class RedCards_Form : Form
    {
        public RedCards_Form()
        {
            InitializeComponent();
        }

        public RedCards_Form(Root_Response_Player_and_Statistic playerAndStat)
        {
            InitializeComponent();
            this._topRed = playerAndStat.response;
            foreach (var index in _topRed)
            {
                redcards_listbox.Items.Add($"{index.Statistics[0].Cards.Red}            {index.Player.name}");
            }
        }
        Response_player_and_statistics[] _topScore;
        Response_player_and_statistics[] _topAssist;
        Response_player_and_statistics[] _topYellow;
        Response_player_and_statistics[] _topRed;


        private void RedCards_Form_Load(object sender, EventArgs e)
        {

        }

        private void RedCards_Form_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // Get the index of the item that was double-clicked
            int clickedIndex = redcards_listbox.IndexFromPoint(e.Location);
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
    }
}
