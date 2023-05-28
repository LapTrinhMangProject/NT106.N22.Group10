using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SQL_Connection;
using Library_football;
using Communicate;
using Newtonsoft.Json;

namespace Forms
{
    public partial class League_form : Form
    {
        public League_form()
        {
            InitializeComponent();
        }
        public League_form(List<League> _league, Request requestUser)
        {
            InitializeComponent();
            this._league = _league;
            this.requestUser = requestUser;
        }
        List<League> _league = new List<League>();
        Request requestUser;

        private void League_form_Load(object sender, EventArgs e)
        {
            foreach (var league in _league)
                selecte_leagues_combobox.Items.Add(league.name);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = selecte_leagues_combobox.SelectedItem as string;
            foreach (var league in _league)
                if (name == league.name)
                {
                    string jsonData = JsonConvert.SerializeObject(league);
                    requestUser.Send("00100" + jsonData);
                }

        }
    }
}
