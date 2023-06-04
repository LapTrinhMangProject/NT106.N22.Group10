using Communicate;
using communicate_client_server;
using Get_response_using_API;
using Library_football;
using ResponseDataStructure;
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
        public Administrator_form(Login login, Request requestUser)
        {
            InitializeComponent();
            this._league = login._league;
            this._leagueWhoSessionIsRunning = login._leagueWhoSessionIsRunning;
            this.requestUser = requestUser;
        }
        Request requestUser;
        public List<League> _league = new List<League>();
        List<LeagueWhoSessionIsRunning> _leagueWhoSessionIsRunning = new List<LeagueWhoSessionIsRunning>();
        SQL_user sqlUser = new SQL_user();
        API api = new API();
        private void button1_Click(object sender, EventArgs e)
        {

        }

        public void Administrator_form_Load(object sender, EventArgs e)
        {
            foreach (var index in _leagueWhoSessionIsRunning)
            {
                if (countrycode_combobox.Items.Contains(index.country.name))
                    continue;
                countrycode_combobox.Items.Add(index.country.name);
            }
            countrycode_combobox.SelectedIndex = 0;
            AutoCompleteStringCollection autoCompleteStringCollection = new AutoCompleteStringCollection();
            foreach (var index in _league)
                active_leagues_listbox.Items.Add(index.name);
            foreach (var index in _leagueWhoSessionIsRunning)
                if (index.country.name == countrycode_combobox.SelectedItem.ToString())
                    list_league_api_support.Items.Add(index.league.name);
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
        }
        private async void add_league_button_Click(object sender, EventArgs e)
        {
            if (list_league_api_support.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn giải đấu muốn thêm", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string leagueSelected = list_league_api_support.SelectedItems[0].ToString();
            MessageBox.Show(leagueSelected);
            foreach (var index in _leagueWhoSessionIsRunning)
                if (index.league.name == leagueSelected)
                {
                    League league = index.league;
                    requestUser.Send("00101", league);
                    MessageBox.Show("sent");
                    await Task.Delay(5000);
                    return;
                }
        }

        private void countrycode_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            list_league_api_support.Items.Clear();
            foreach (var index in _leagueWhoSessionIsRunning)
                if (index.country.name == countrycode_combobox.SelectedItem.ToString())
                    list_league_api_support.Items.Add(index.league.name);
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            list_league_api_support.Items.Clear();
            foreach (var index in _leagueWhoSessionIsRunning)
                if (index.league.name.Contains(find_textbox.Text) && index.country.name == countrycode_combobox.SelectedItem.ToString())
                    list_league_api_support.Items.Add(index.league.name);
        }
    }
}
