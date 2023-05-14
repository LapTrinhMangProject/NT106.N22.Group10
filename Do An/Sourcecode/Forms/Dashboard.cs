using Get_response_using_API;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Get_response_using_API;
using Response;

namespace Forms
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }
        API api = new API();
        private async void  Dashboard_Load(object sender, EventArgs e)
        {
            Root_Reponse_standing responseStanding = new Root_Reponse_standing();
           responseStanding = await api.Get_Standing("39");
            foreach(var index in responseStanding.response[0].league.standings[0])
            {
                standing_listbox.Items.Add(index.Rank +" " + index.Team.Name +"Point: "+index.Points);
            }
        }

        private void find_player_button_Click(object sender, EventArgs e)
        {
            new Player_form().Show();
        }

        private void topscore_button_Click(object sender, EventArgs e)
        {
            new Topscore_form().Show();
        }
    }
}
