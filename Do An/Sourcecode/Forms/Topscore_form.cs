using API;
using ResponseDataStructure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace Forms
{
    public partial class Topscore_form : Form
    {
        public Topscore_form()
        {
            InitializeComponent();
        }
        public Topscore_form(Root_Response_Player_and_Statistic playerAndStat)
        {
            InitializeComponent();
            this._topScore = playerAndStat.response;
            foreach (var index in this._topScore)
            {
                topscore_listbox.Items.Add($"{index.Statistics[0].Goals.Total}            {index.Player.name}");

            }
        }
        Response_player_and_statistics[] _topScore;
        Response_player_and_statistics[] _topAssist;
        Response_player_and_statistics[] _topYellow;
        Response_player_and_statistics[] _topRed;

        private void Topscore_form_Load(object sender, EventArgs e)
        {
            /*ApiUser aPI = new ApiUser();
            async void Display_Get_Top_Score()
            {
                Root_Response_Player_and_Statistic responsePlayerAndStatistic = new Root_Response_Player_and_Statistic();
                responsePlayerAndStatistic = await aPI.Get_Top_Score("39");
                _topScore = responsePlayerAndStatistic.response;
                foreach (var index in _topScore)
                {
                    topscore_listbox.Items.Add($"{index.Statistics[0].Goals.Total}            {index.Player.name}");

                }
            }
            async void Display_Get_Top_Assist()
            {
                Root_Response_Player_and_Statistic responsePlayerAndStatistic = new Root_Response_Player_and_Statistic();
                responsePlayerAndStatistic = await aPI.Get_Top_Assists("39");
                _topAssist = responsePlayerAndStatistic.response;
                int i = 0;
                foreach (var index in _topAssist)
                {
                    assist_listbox.Items.Add($"{index.Statistics[0].Goals.Assists}            {index.Player.name}");
                    i++;

                }
            }
            async void Display_Get_Top_Red_Cards()
            {
                Root_Response_Player_and_Statistic responsePlayerAndStatistic = new Root_Response_Player_and_Statistic();
                responsePlayerAndStatistic = await aPI.Get_Top_Assists("39");
                _topRed = responsePlayerAndStatistic.response;
                foreach (var index in _topRed)
                {
                    redcard_listbox.Items.Add($"{index.Statistics[0].Cards.Red}            {index.Player.name}");

                }

            }
            async void Display_Get_Top_Yellow_Cards()
            {
                Root_Response_Player_and_Statistic responsePlayerAndStatistic = new Root_Response_Player_and_Statistic();
                responsePlayerAndStatistic = await aPI.Get_Top_Assists("39");
                _topYellow = responsePlayerAndStatistic.response;
                foreach (var index in _topYellow)
                {
                    yellowcard_listbox.Items.Add($"{index.Statistics[0].Cards.Yellow}            {index.Player.name}");

                }
            }
            //Display_Get_Top_Red_Cards();
            //Display_Get_Top_Yellow_Cards();
            //Display_Get_Top_Score();
           // Display_Get_Top_Assist(); */
        } 


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void topscore_listbox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // Get the index of the item that was double-clicked
            int clickedIndex = topscore_listbox.IndexFromPoint(e.Location);
            string imageUrl = this._topScore[clickedIndex].Player.photo;
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
                        pictureBox1.Image = image;
                    }
                }
        }

       /* private void assist_listbox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Display_player(_topAssist, assist_listbox.SelectedIndex);
        }

        private void redcard_listbox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Display_player(_topRed, redcard_listbox.SelectedIndex);

        }

        private void yellowcard_listbox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Display_player(_topYellow, yellowcard_listbox.SelectedIndex);
        }
        void Display_player(Response_player_and_statistics[] _top, int index)
        {
            string idPlayer = _top[index].Player.id.ToString();
            Player_form player = new Player_form(idPlayer);
            player.Display_All_Statistic_Of_specific();
            player.ShowDialog();
        } */
    }
}
