using Get_response_using_API;
using Library_football;
using SQL_Connection;
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
    public partial class Administrator_form : Form
    {
        public Administrator_form()
        {
            InitializeComponent();
        }
        public Administrator_form(List<League> _league)
        {
            InitializeComponent();
            this._league = _league;
        }
        List<League> _league = new List<League>();
        SQL_user sqlUser = new SQL_user();
        API api = new API();
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Administrator_form_Load(object sender, EventArgs e)
        {
            AutoCompleteStringCollection autoCompleteStringCollection = new AutoCompleteStringCollection();
            foreach (var league in _league)
                active_leagues_listbox.Items.Add(league.name);
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
        }
        private async void add_league_button_Click(object sender, EventArgs e)
        {
            League league = new League();
            league.id = 61;
            var _teams = await api.Get_Teams_from_Leagues(league);
            string leagueName = _league[1].name;
            foreach (var index in _teams.response)
            {
                sqlUser.AddTeam(index.team, leagueName);
            }

        }
    }
}
