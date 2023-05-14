using Get_response_using_API;
using Response;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms
{
    public partial class Topscore_form : Form
    {
        public Topscore_form()
        {
            InitializeComponent();
        }
        Dictionary<string,string> dicPlayer = new Dictionary<string,string>();
        private async void Topscore_form_Load(object sender, EventArgs e)
        {
            API aPI = new API();
            Root_Response_Player_and_Statistic responsePlayerAndStatistic = new Root_Response_Player_and_Statistic();
            responsePlayerAndStatistic = await aPI.Get_Top_Score("39");
            foreach (var index in  responsePlayerAndStatistic.response) 
            {
                topscore_listbox.Items.Add($"{index.Statistics[0].Goals.Total}            {index.Player.name}");
                if (dicPlayer.ContainsKey(index.Player.name))
                    continue;
                dicPlayer.Add(index.Player.name,index.Player.id.ToString());
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void topscore_listbox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string idPlayer = dicPlayer[topscore_listbox.SelectedItems[0].ToString().Substring(14)];
            Player_form player = new Player_form(idPlayer);
            player.Display_All_Statistic_Of_specific();
            player.ShowDialog();  
        }
    }
}
